using SonicHesap.Entities.Context;
using SonicHesap.Entities.Tools;
using System;
using System.Data.Entity;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.Backup
{
    public partial class FrmBackup : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context = new SonicHesapContext();
        private bool otomatikYedekAl;
        private Timer yedeklemeZamanlayici;

        public FrmBackup()
        {
            InitializeComponent();

            // Otomatik yedek alma özelliğini ayarlardan oku ve kontrolü gerçekleştir
            string otomatikYedek = SettingsTool.AyarOku(SettingsTool.Ayarlar.YedeklemeAyarlari_OtomatikYedekAl);
            otomatikYedekAl = !string.IsNullOrEmpty(otomatikYedek) && otomatikYedek.ToLower() == "true";

            if (otomatikYedekAl)
            {
                YedekleAsync();
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.YedeklemeAyarlari_OtomatikYedekleme, "true");
                SettingsTool.Save();
            }

            txtYedekKonum.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.YedeklemeAyarlari_YedeklemeKonumu);
            dateYedekTarihi.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.YedeklemeAyarlari_KaydedilmisTarih);

            // Timer oluştur
            yedeklemeZamanlayici = new Timer();
            yedeklemeZamanlayici.Interval = 60000; // Her dakika kontrol etmek için, istediğiniz sıklığı ayarlayabilirsiniz
            yedeklemeZamanlayici.Tick += YedeklemeZamanlayici_Tick;

            // Timer'ı başlat
            yedeklemeZamanlayici.Start();
        }


        private async void YedeklemeZamanlayici_Tick(object sender, EventArgs e)
        {
            // Belirlenen tarih ve saat geldiğinde yedekleme işlemini gerçekleştir
            DateTime? savedDateTime = GetSavedDateTime();
            if (savedDateTime != null && savedDateTime.Value == DateTime.Now)
            {
                await YedekleAsync();
            }
        }

        private async void FrmBackup_Load(object sender, EventArgs e)
        {
            if (otomatikYedekAl)
            {
                await YedekleAsync();
            }
        }

        private async Task YedekleAsync()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string yedekKonum = txtYedekKonum.Text + "\\SonicHesap.bak";

                // Eğer tarih seçiliyse, tarih bilgisini de yedek dosya adına ekle
                if (dateYedekTarihi.EditValue != null)
                {
                    string tarihFormati = ((DateTime)dateYedekTarihi.EditValue).ToString("yyyyMMdd");
                    yedekKonum = $"{txtYedekKonum.Text}\\SonicHesap_{tarihFormati}.bak";
                }

                string sqlWord = $"USE SonicHesap;BACKUP DATABASE SonicHesap TO DISK='{yedekKonum}'";
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

        private void txtYedekKonum_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog form = new FolderBrowserDialog();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtYedekKonum.Text = form.SelectedPath;
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.YedeklemeAyarlari_YedeklemeKonumu, txtYedekKonum.Text);
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

        private async void CheckOtomatikYedekleme_CheckedChanged(object sender, EventArgs e)
        {
            otomatikYedekAl = checkOtomatikYedekleme.Checked;
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.YedeklemeAyarlari_OtomatikYedekAl, otomatikYedekAl.ToString());
            SettingsTool.Save();

            // Otomatik yedekleme özelliği seçiliyse, her seferinde yedek alma işlemini gerçekleştir
            if (otomatikYedekAl)
            {
                await YedekleAsync();
            }
        }


        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            DateTime? savedDateTime = null;
            if (dateYedekTarihi.EditValue != null)
            {
                savedDateTime = (DateTime)dateYedekTarihi.EditValue;
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.YedeklemeAyarlari_KaydedilmisTarih, savedDateTime.Value.ToString("dd.MM.yyyy HH:mm:ss"));
                SettingsTool.Save();
                yedeklemeZamanlayici.Start();
            }
            else
            {
                MessageBox.Show("Lütfen yedekleme tarihini seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Otomatik yedekleme özelliği seçiliyse her kaydetme işleminde yedek al
            if (checkOtomatikYedekleme.Checked)
            {
                await YedekleAsync();
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.YedeklemeAyarlari_OtomatikYedekleme, "true");
                SettingsTool.Save();
                MessageBox.Show("Yedek görevleri ayarlara kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.YedeklemeAyarlari_OtomatikYedekleme, "false");
                SettingsTool.Save();
                MessageBox.Show("Yedek görevleri ayarlara kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private async void checkOtomatikYedekleme_CheckedChanged(object sender, EventArgs e)
        {
            otomatikYedekAl = checkOtomatikYedekleme.Checked;
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.YedeklemeAyarlari_OtomatikYedekleme, otomatikYedekAl.ToString());
            SettingsTool.Save();

            if (otomatikYedekAl)
            {
                await YedekleAsync();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DateTime? GetSavedDateTime()
        {
            string savedDateTimeString = SettingsTool.AyarOku(SettingsTool.Ayarlar.YedeklemeAyarlari_KaydedilmisTarih);
            SettingsTool.Save();

            if (!string.IsNullOrEmpty(savedDateTimeString) && DateTime.TryParseExact(savedDateTimeString, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime savedDateTime))
            {
                return savedDateTime;
            }
            else if (dateYedekTarihi.EditValue != null)
            {
                return (DateTime)dateYedekTarihi.EditValue;
            }

            return null;
        }

        private async void btnYedekle_Click(object sender, EventArgs e)
        {
            await YedekleAsync();
        }
    }
}
