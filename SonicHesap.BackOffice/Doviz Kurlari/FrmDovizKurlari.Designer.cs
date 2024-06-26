﻿namespace SonicHesap.BackOffice.Doviz_Kurlari
{
    partial class FrmDovizKurlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDovizKurlari));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsım = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSembol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForexBuying = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForexSelling = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankNoteBuying = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankNoteSelling = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblUyari = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(874, 66);
            this.lblBaslik.TabIndex = 8;
            this.lblBaslik.Text = "Döviz Kurları";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.lblUyari);
            this.grpMenu.Controls.Add(this.btnKaydet);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 669);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(874, 89);
            this.grpMenu.TabIndex = 9;
            this.grpMenu.Text = "Menü";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKaydet.ImageOptions.ImageIndex = 2;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(617, 28);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(135, 59);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Güncelle";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            this.ımageList1.Images.SetKeyName(2, "refresh.png");
            // 
            // btnKapat
            // 
            this.btnKapat.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Appearance.Options.UseFont = true;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(752, 28);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(120, 59);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 66);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(874, 603);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsım,
            this.colSembol,
            this.colForexBuying,
            this.colForexSelling,
            this.colBankNoteBuying,
            this.colBankNoteSelling});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colIsım
            // 
            this.colIsım.Caption = "Isim";
            this.colIsım.FieldName = "Isim";
            this.colIsım.MinWidth = 25;
            this.colIsım.Name = "colIsım";
            this.colIsım.Visible = true;
            this.colIsım.VisibleIndex = 0;
            this.colIsım.Width = 94;
            // 
            // colSembol
            // 
            this.colSembol.Caption = "Sembol";
            this.colSembol.FieldName = "CurrencyCode";
            this.colSembol.MinWidth = 25;
            this.colSembol.Name = "colSembol";
            this.colSembol.Visible = true;
            this.colSembol.VisibleIndex = 1;
            this.colSembol.Width = 94;
            // 
            // colForexBuying
            // 
            this.colForexBuying.Caption = "Forex Alış";
            this.colForexBuying.FieldName = "ForexBuying";
            this.colForexBuying.MinWidth = 25;
            this.colForexBuying.Name = "colForexBuying";
            this.colForexBuying.Visible = true;
            this.colForexBuying.VisibleIndex = 2;
            this.colForexBuying.Width = 94;
            // 
            // colForexSelling
            // 
            this.colForexSelling.Caption = "Forex Satış";
            this.colForexSelling.FieldName = "ForexSelling";
            this.colForexSelling.MinWidth = 25;
            this.colForexSelling.Name = "colForexSelling";
            this.colForexSelling.Visible = true;
            this.colForexSelling.VisibleIndex = 3;
            this.colForexSelling.Width = 94;
            // 
            // colBankNoteBuying
            // 
            this.colBankNoteBuying.Caption = "Banknot Alış";
            this.colBankNoteBuying.FieldName = "BanknoteBuying";
            this.colBankNoteBuying.MinWidth = 25;
            this.colBankNoteBuying.Name = "colBankNoteBuying";
            this.colBankNoteBuying.Visible = true;
            this.colBankNoteBuying.VisibleIndex = 4;
            this.colBankNoteBuying.Width = 94;
            // 
            // colBankNoteSelling
            // 
            this.colBankNoteSelling.Caption = "Banknot Satış";
            this.colBankNoteSelling.FieldName = "BanknoteSelling";
            this.colBankNoteSelling.MinWidth = 25;
            this.colBankNoteSelling.Name = "colBankNoteSelling";
            this.colBankNoteSelling.Visible = true;
            this.colBankNoteSelling.VisibleIndex = 5;
            this.colBankNoteSelling.Width = 94;
            // 
            // lblUyari
            // 
            this.lblUyari.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyari.Appearance.Options.UseFont = true;
            this.lblUyari.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUyari.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblUyari.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUyari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblUyari.ImageOptions.Image")));
            this.lblUyari.Location = new System.Drawing.Point(5, 35);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(531, 47);
            this.lblUyari.TabIndex = 3;
            // 
            // FrmDovizKurlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 758);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDovizKurlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T.C. Merkez Bankası Döviz Kurları";
            this.Load += new System.EventHandler(this.FrmDovizKurlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsım;
        private DevExpress.XtraGrid.Columns.GridColumn colSembol;
        private DevExpress.XtraGrid.Columns.GridColumn colForexBuying;
        private DevExpress.XtraGrid.Columns.GridColumn colForexSelling;
        private DevExpress.XtraGrid.Columns.GridColumn colBankNoteBuying;
        private DevExpress.XtraGrid.Columns.GridColumn colBankNoteSelling;
        private DevExpress.XtraEditors.LabelControl lblUyari;
    }
}