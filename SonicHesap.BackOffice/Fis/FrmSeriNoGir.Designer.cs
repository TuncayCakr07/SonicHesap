namespace SonicHesap.BackOffice.Fis
{
    partial class FrmSeriNoGir
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeriNoGir));
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.grpBilgi = new DevExpress.XtraEditors.GroupControl();
            this.txtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.listSeriNo = new DevExpress.XtraEditors.ListBoxControl();
            this.groupAltMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnVazgeç = new DevExpress.XtraEditors.SimpleButton();
            this.BtnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grpBilgi)).BeginInit();
            this.grpBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSeriNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAltMenu)).BeginInit();
            this.groupAltMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl16.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl16.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl16.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl16.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl16.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl16.ImageOptions.Image")));
            this.labelControl16.Location = new System.Drawing.Point(0, 0);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(595, 66);
            this.labelControl16.TabIndex = 15;
            this.labelControl16.Text = "Seri No Bilgileri";
            // 
            // grpBilgi
            // 
            this.grpBilgi.Controls.Add(this.txtSeriNo);
            this.grpBilgi.Controls.Add(this.labelControl20);
            this.grpBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBilgi.Enabled = false;
            this.grpBilgi.Location = new System.Drawing.Point(0, 66);
            this.grpBilgi.Name = "grpBilgi";
            this.grpBilgi.Size = new System.Drawing.Size(595, 61);
            this.grpBilgi.TabIndex = 16;
            this.grpBilgi.Text = "Seri No Bilgileri";
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(113, 32);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(476, 22);
            this.txtSeriNo.TabIndex = 1;
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Options.UseTextOptions = true;
            this.labelControl20.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl20.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl20.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl20.Location = new System.Drawing.Point(8, 31);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(98, 24);
            this.labelControl20.TabIndex = 0;
            this.labelControl20.Text = "Seri No :";
            // 
            // listSeriNo
            // 
            this.listSeriNo.Location = new System.Drawing.Point(8, 133);
            this.listSeriNo.Name = "listSeriNo";
            this.listSeriNo.Size = new System.Drawing.Size(581, 268);
            this.listSeriNo.TabIndex = 17;
            // 
            // groupAltMenu
            // 
            this.groupAltMenu.Controls.Add(this.btnKapat);
            this.groupAltMenu.Controls.Add(this.btnVazgeç);
            this.groupAltMenu.Controls.Add(this.BtnYeni);
            this.groupAltMenu.Controls.Add(this.btnSil);
            this.groupAltMenu.Controls.Add(this.btnKaydet);
            this.groupAltMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupAltMenu.Location = new System.Drawing.Point(0, 408);
            this.groupAltMenu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupAltMenu.Name = "groupAltMenu";
            this.groupAltMenu.Size = new System.Drawing.Size(595, 92);
            this.groupAltMenu.TabIndex = 18;
            this.groupAltMenu.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnKapat.Appearance.Options.UseFont = true;
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(474, 30);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(115, 60);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "add.png");
            this.ımageList1.Images.SetKeyName(2, "delete.png");
            this.ımageList1.Images.SetKeyName(3, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(4, "floppy_disk_delete.png");
            // 
            // btnVazgeç
            // 
            this.btnVazgeç.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnVazgeç.Appearance.Options.UseFont = true;
            this.btnVazgeç.Enabled = false;
            this.btnVazgeç.ImageOptions.ImageIndex = 4;
            this.btnVazgeç.ImageOptions.ImageList = this.ımageList1;
            this.btnVazgeç.Location = new System.Drawing.Point(357, 30);
            this.btnVazgeç.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnVazgeç.Name = "btnVazgeç";
            this.btnVazgeç.Size = new System.Drawing.Size(115, 60);
            this.btnVazgeç.TabIndex = 3;
            this.btnVazgeç.Text = "Vazgeç";
            this.btnVazgeç.Click += new System.EventHandler(this.btnVazgeç_Click);
            // 
            // BtnYeni
            // 
            this.BtnYeni.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeni.Appearance.Options.UseFont = true;
            this.BtnYeni.ImageOptions.ImageIndex = 1;
            this.BtnYeni.ImageOptions.ImageList = this.ımageList1;
            this.BtnYeni.Location = new System.Drawing.Point(4, 30);
            this.BtnYeni.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnYeni.Name = "BtnYeni";
            this.BtnYeni.Size = new System.Drawing.Size(115, 60);
            this.BtnYeni.TabIndex = 2;
            this.BtnYeni.Text = "Yeni";
            this.BtnYeni.Click += new System.EventHandler(this.BtnYeni_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.ImageIndex = 2;
            this.btnSil.ImageOptions.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(122, 30);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(115, 60);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.ImageOptions.ImageIndex = 3;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(240, 30);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(115, 60);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmSeriNoGir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 500);
            this.Controls.Add(this.groupAltMenu);
            this.Controls.Add(this.listSeriNo);
            this.Controls.Add(this.grpBilgi);
            this.Controls.Add(this.labelControl16);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeriNoGir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seri No Bilgileri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSeriNoGir_FormClosing);
            this.Load += new System.EventHandler(this.FrmSeriNoGir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpBilgi)).EndInit();
            this.grpBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSeriNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAltMenu)).EndInit();
            this.groupAltMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.GroupControl grpBilgi;
        private DevExpress.XtraEditors.TextEdit txtSeriNo;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.ListBoxControl listSeriNo;
        private DevExpress.XtraEditors.GroupControl groupAltMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnVazgeç;
        private DevExpress.XtraEditors.SimpleButton BtnYeni;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.ImageList ımageList1;
    }
}