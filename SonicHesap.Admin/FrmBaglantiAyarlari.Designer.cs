namespace SonicHesap.Admin
{
    partial class FrmBaglantiAyarlari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaglantiAyarlari));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.chkWindows = new DevExpress.XtraEditors.CheckButton();
            this.chkSql = new DevExpress.XtraEditors.CheckButton();
            this.txtServer = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.btnTest = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblBaslik.ImageOptions.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblBaslik.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslik.ImageOptions.Image")));
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(488, 66);
            this.lblBaslik.TabIndex = 14;
            this.lblBaslik.Text = "Bağlantı Ayarları";
            // 
            // chkWindows
            // 
            this.chkWindows.Checked = true;
            this.chkWindows.GroupIndex = 1;
            this.chkWindows.Location = new System.Drawing.Point(12, 72);
            this.chkWindows.Name = "chkWindows";
            this.chkWindows.Size = new System.Drawing.Size(231, 181);
            this.chkWindows.TabIndex = 15;
            this.chkWindows.Text = "Windows Authentication";
            // 
            // chkSql
            // 
            this.chkSql.GroupIndex = 1;
            this.chkSql.Location = new System.Drawing.Point(249, 72);
            this.chkSql.Name = "chkSql";
            this.chkSql.Size = new System.Drawing.Size(231, 181);
            this.chkSql.TabIndex = 15;
            this.chkSql.TabStop = false;
            this.chkSql.Text = "SQL Server Authentication";
            this.chkSql.CheckedChanged += new System.EventHandler(this.chkSql_CheckedChanged);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(126, 261);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(350, 22);
            this.txtServer.TabIndex = 17;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(12, 259);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 24);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Server Adı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(12, 286);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 24);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Enabled = false;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(126, 288);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(350, 22);
            this.txtKullaniciAdi.TabIndex = 17;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(12, 314);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(108, 24);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Parola :";
            // 
            // txtParola
            // 
            this.txtParola.Enabled = false;
            this.txtParola.Location = new System.Drawing.Point(126, 316);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(350, 22);
            this.txtParola.TabIndex = 17;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 344);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(231, 64);
            this.btnTest.TabIndex = 18;
            this.btnTest.Text = "Server Test";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(249, 344);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(231, 64);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmBaglantiAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 497);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.chkSql);
            this.Controls.Add(this.chkWindows);
            this.Controls.Add(this.lblBaslik);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBaglantiAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bağlantı Ayarları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBaglantiAyarlari_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.CheckButton chkWindows;
        private DevExpress.XtraEditors.CheckButton chkSql;
        private DevExpress.XtraEditors.TextEdit txtServer;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.SimpleButton btnTest;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
    }
}