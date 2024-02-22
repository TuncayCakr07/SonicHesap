using DevExpress.XtraEditors;
using SonicHesap.BackOffice.Stok;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Indirim
{
    public partial class FrmIndirimIslem : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context = new SonicHesapContext();
        IndirimDAL IndirimDal = new IndirimDAL();
        public FrmIndirimIslem()
        {
            InitializeComponent();
            gridContIndirimshr.DataSource = context.Indirimler.Local.ToBindingList();
        }

        private Entities.Tables.Indirim StokEkle(Entities.Tables.Stok entity)
        {
            Entities.Tables.Indirim _entity = new Entities.Tables.Indirim();
            _entity.StokKodu = entity.StokKodu;
            _entity.Barkod = entity.Barkod;
            _entity.StokAdi = entity.StokAdi;
            return _entity;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec(true);
            form.ShowDialog();
            if (form.secildi)
            {
                foreach (var itemStok in form.secilen)
                {
                    Entities.Tables.Indirim _entity = new Entities.Tables.Indirim();
                    _entity = StokEkle(itemStok);
                    var count = context.Indirimler.Count(c => c.StokKodu == itemStok.StokKodu);
                    if (count != 0)
                    {
                        if (MessageBox.Show("Seçili Olan Stoğa Daha Önceden Eklenmiş Bir İndirim Bulunmaktadır.Var Olan İndirimi Güncellemek İstermisiniz?", "Uyarı!", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var secilenId = context.Indirimler.SingleOrDefault(c => c.StokKodu == itemStok.StokKodu);
                            _entity.Id = secilenId.Id;
                            IndirimDal.AddOrUpdate(context, _entity);
                        }
                    }
                    else
                    {
                        IndirimDal.AddOrUpdate(context, _entity);
                    }
                }
            }
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            foreach (var itemIndirim in context.Indirimler.Local.ToList())
            {
          
                if (btnSuresiz.Checked)
                {
                    itemIndirim.IndirimTuru = "Süresiz";
                }
                else
                {
                    itemIndirim.BaslangicTarihi = dateBaslangic.DateTime;
                    itemIndirim.BitisTarihi = dateBitis.DateTime;
                    itemIndirim.IndirimTuru = "Tarihler Arasında";
                }
                itemIndirim.Durumu = true;
                itemIndirim.Aciklama = txtAciklama.Text;
            }
            MessageBox.Show("İndirim Oranları Güncellendi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            IndirimDal.Save(context);
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Listeden Çıkarmak İstediğinize Eminmisiniz?","Uyarı!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                var secilenStokKodu = gridIndirim.GetFocusedRowCellValue(colStokKodu).ToString();
                var secilen = IndirimDal.GetByFilter(context, c => c.StokKodu == secilenStokKodu);
                context.Entry(secilen).State = EntityState.Detached;
                MessageBox.Show("Stok Listeden Çıkarıldı!","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
           
        }
    }
}