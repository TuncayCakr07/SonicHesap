namespace SonicHesap.Backup
{
    partial class FrmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackup));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.btnYedekle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGeriYukle = new DevExpress.XtraEditors.SimpleButton();
            this.txtYedekKonum = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtYedekKonum.Properties)).BeginInit();
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
            this.lblBaslik.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslik.ImageOptions.Image")));
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(530, 66);
            this.lblBaslik.TabIndex = 8;
            this.lblBaslik.Text = "Yedekleme Ve Geri Yükleme";
            // 
            // btnYedekle
            // 
            this.btnYedekle.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYedekle.Appearance.Options.UseFont = true;
            this.btnYedekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYedekle.ImageOptions.Image")));
            this.btnYedekle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnYedekle.Location = new System.Drawing.Point(26, 85);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(237, 238);
            this.btnYedekle.TabIndex = 9;
            this.btnYedekle.Text = "Yedekleme";
            this.btnYedekle.Click += new System.EventHandler(this.btnYedekle_Click);
            // 
            // btnGeriYukle
            // 
            this.btnGeriYukle.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriYukle.Appearance.Options.UseFont = true;
            this.btnGeriYukle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGeriYukle.ImageOptions.Image")));
            this.btnGeriYukle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnGeriYukle.Location = new System.Drawing.Point(269, 85);
            this.btnGeriYukle.Name = "btnGeriYukle";
            this.btnGeriYukle.Size = new System.Drawing.Size(237, 238);
            this.btnGeriYukle.TabIndex = 10;
            this.btnGeriYukle.Text = "Geri Yükleme";
            this.btnGeriYukle.Click += new System.EventHandler(this.btnGeriYukle_Click);
            // 
            // txtYedekKonum
            // 
            this.txtYedekKonum.Location = new System.Drawing.Point(165, 344);
            this.txtYedekKonum.Name = "txtYedekKonum";
            this.txtYedekKonum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtYedekKonum.Size = new System.Drawing.Size(341, 22);
            this.txtYedekKonum.TabIndex = 11;
            this.txtYedekKonum.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtYedekKonum_ButtonClick);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(26, 342);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(133, 24);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Yedekleme Konumu :";
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 386);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtYedekKonum);
            this.Controls.Add(this.btnGeriYukle);
            this.Controls.Add(this.btnYedekle);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yedekleme Ve Geri Yükleme";
            ((System.ComponentModel.ISupportInitialize)(this.txtYedekKonum.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.SimpleButton btnYedekle;
        private DevExpress.XtraEditors.SimpleButton btnGeriYukle;
        private DevExpress.XtraEditors.ButtonEdit txtYedekKonum;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}

