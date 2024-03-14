namespace SonicHesap.Update
{
    partial class FrmGuncelleme
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblIndirilenVeri = new DevExpress.XtraEditors.LabelControl();
            this.progressFile = new DevExpress.XtraEditors.ProgressBarControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblIndirilenVeri);
            this.groupControl1.Controls.Add(this.progressFile);
            this.groupControl1.Controls.Add(this.grpMenu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(785, 263);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Güncelleme İşlemleri";
            // 
            // lblIndirilenVeri
            // 
            this.lblIndirilenVeri.Location = new System.Drawing.Point(13, 99);
            this.lblIndirilenVeri.Name = "lblIndirilenVeri";
            this.lblIndirilenVeri.Size = new System.Drawing.Size(0, 16);
            this.lblIndirilenVeri.TabIndex = 11;
            // 
            // progressFile
            // 
            this.progressFile.Location = new System.Drawing.Point(6, 37);
            this.progressFile.Name = "progressFile";
            this.progressFile.Size = new System.Drawing.Size(771, 55);
            this.progressFile.TabIndex = 10;
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.simpleButton1);
            this.grpMenu.Controls.Add(this.simpleButton2);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(2, 148);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(781, 113);
            this.grpMenu.TabIndex = 9;
            this.grpMenu.Text = "Menü";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(441, 28);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(169, 83);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Güncellemeyi İndir";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(610, 28);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(169, 83);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Kapat";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // FrmGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 263);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncelleme";
            this.Load += new System.EventHandler(this.FrmGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.ProgressBarControl progressFile;
        private DevExpress.XtraEditors.LabelControl lblIndirilenVeri;
    }
}

