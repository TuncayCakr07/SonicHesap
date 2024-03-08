using SonicHesap.Entities.Context;
using SonicHesap.Entities.Tools;
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

namespace SonicHesap.Backup
{
    public partial class FrmBackup : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context = new SonicHesapContext();
        public FrmBackup()
        {
            InitializeComponent();
            txtYedekKonum.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.YedeklemeAyarlari_YedeklemeKonumu);
        }

        private async void btnYedekle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yedekleme işlemi başlatılsın mı?", "Yedekleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    string sqlWord = $"USE SonicHesap;BACKUP DATABASE SonicHesap TO DISK='{txtYedekKonum.Text + "\\SonicHesap.bak"}'";
                    await context.Database.ExecuteSqlCommandAsync(TransactionalBehavior.DoNotEnsureTransaction, sqlWord);
                    MessageBox.Show("Yedekleme işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Yedekleme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            else
            {
                MessageBox.Show("Yedekleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtYedekKonum_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog form = new FolderBrowserDialog();
            if (form.ShowDialog()==DialogResult.OK)
            {
                txtYedekKonum.Text = form.SelectedPath;
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.YedeklemeAyarlari_YedeklemeKonumu,txtYedekKonum.Text);
                SettingsTool.Save();
            }
        }

        private async void btnGeriYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "SonicHesap Yedek Dosyası *.bak |*.bak";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("SonicHesap veritabanını bu yedeğe geri yüklemek istediğinize emin misiniz?",
                                                        "Onay",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    string sqlWord = $"USE master; ALTER DATABASE SonicHesap SET SINGLE_USER WITH ROLLBACK IMMEDIATE;ALTER DATABASE SonicHesap SET READ_ONLY;RESTORE DATABASE SonicHesap FROM DISK='{dialog.FileName}' ALTER DATABASE SonicHesap SET MULTI_USER;";

                    try
                    {
                        await Task.Run(() => {
                            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlWord);
                        });

                        MessageBox.Show("Yedekten geri yükleme işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Yedekten geri yükleme işlemi sırasında bir hata oluştu:\n" + ex.Message,
                                        "Hata",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Cursor.Current = Cursors.Default;
                    }
                }
            }
        }

    }
}
