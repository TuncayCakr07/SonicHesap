namespace SonicHesap.BackOffice.Kasa
{
    partial class FrmKasaSecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasaSecim));
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.gridContSecim = new DevExpress.XtraGrid.GridControl();
            this.gridSecim = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContSecim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSecim)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnSec);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 641);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1361, 83);
            this.grpMenu.TabIndex = 9;
            this.grpMenu.Text = "Menü";
            // 
            // btnSec
            // 
            this.btnSec.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSec.Appearance.Options.UseFont = true;
            this.btnSec.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSec.ImageOptions.ImageIndex = 0;
            this.btnSec.ImageOptions.ImageList = this.ımageList1;
            this.btnSec.Location = new System.Drawing.Point(1171, 28);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(94, 53);
            this.btnSec.TabIndex = 1;
            this.btnSec.Text = "Seç";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "check.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            // 
            // btnKapat
            // 
            this.btnKapat.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Appearance.Options.UseFont = true;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(1265, 28);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(94, 53);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
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
            this.lblBaslik.Size = new System.Drawing.Size(1361, 66);
            this.lblBaslik.TabIndex = 8;
            this.lblBaslik.Text = "Kasa Seçim Ekranı";
            // 
            // gridContSecim
            // 
            this.gridContSecim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContSecim.Location = new System.Drawing.Point(0, 66);
            this.gridContSecim.MainView = this.gridSecim;
            this.gridContSecim.Name = "gridContSecim";
            this.gridContSecim.Size = new System.Drawing.Size(1361, 575);
            this.gridContSecim.TabIndex = 10;
            this.gridContSecim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSecim});
            // 
            // gridSecim
            // 
            this.gridSecim.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKasaKodu,
            this.colKasaAdi,
            this.colYetkiliKodu,
            this.colYetkiliAdi,
            this.colAciklama,
            this.colKasaGiris,
            this.colKasaCikis,
            this.colBakiye});
            this.gridSecim.GridControl = this.gridContSecim;
            this.gridSecim.Name = "gridSecim";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 8;
            this.colId.Width = 94;
            // 
            // colKasaKodu
            // 
            this.colKasaKodu.Caption = "Kasa Kodu";
            this.colKasaKodu.FieldName = "KasaKodu";
            this.colKasaKodu.MinWidth = 25;
            this.colKasaKodu.Name = "colKasaKodu";
            this.colKasaKodu.OptionsColumn.AllowEdit = false;
            this.colKasaKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colKasaKodu.Visible = true;
            this.colKasaKodu.VisibleIndex = 0;
            this.colKasaKodu.Width = 94;
            // 
            // colKasaAdi
            // 
            this.colKasaAdi.Caption = "Kasa Adı";
            this.colKasaAdi.FieldName = "KasaAdi";
            this.colKasaAdi.MinWidth = 25;
            this.colKasaAdi.Name = "colKasaAdi";
            this.colKasaAdi.OptionsColumn.AllowEdit = false;
            this.colKasaAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colKasaAdi.Visible = true;
            this.colKasaAdi.VisibleIndex = 1;
            this.colKasaAdi.Width = 94;
            // 
            // colYetkiliKodu
            // 
            this.colYetkiliKodu.Caption = "Yetkili Kodu";
            this.colYetkiliKodu.FieldName = "YetkiliKodu";
            this.colYetkiliKodu.MinWidth = 25;
            this.colYetkiliKodu.Name = "colYetkiliKodu";
            this.colYetkiliKodu.OptionsColumn.AllowEdit = false;
            this.colYetkiliKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colYetkiliKodu.Visible = true;
            this.colYetkiliKodu.VisibleIndex = 2;
            this.colYetkiliKodu.Width = 94;
            // 
            // colYetkiliAdi
            // 
            this.colYetkiliAdi.Caption = "Yetkili Adı";
            this.colYetkiliAdi.FieldName = "YetkiliAdi";
            this.colYetkiliAdi.MinWidth = 25;
            this.colYetkiliAdi.Name = "colYetkiliAdi";
            this.colYetkiliAdi.OptionsColumn.AllowEdit = false;
            this.colYetkiliAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colYetkiliAdi.Visible = true;
            this.colYetkiliAdi.VisibleIndex = 3;
            this.colYetkiliAdi.Width = 94;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.OptionsColumn.ShowInCustomizationForm = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 4;
            this.colAciklama.Width = 94;
            // 
            // colKasaGiris
            // 
            this.colKasaGiris.Caption = "Kasa Giriş";
            this.colKasaGiris.DisplayFormat.FormatString = "C2";
            this.colKasaGiris.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKasaGiris.FieldName = "KasaGiris";
            this.colKasaGiris.MinWidth = 25;
            this.colKasaGiris.Name = "colKasaGiris";
            this.colKasaGiris.OptionsColumn.AllowEdit = false;
            this.colKasaGiris.OptionsColumn.ShowInCustomizationForm = false;
            this.colKasaGiris.Visible = true;
            this.colKasaGiris.VisibleIndex = 5;
            this.colKasaGiris.Width = 94;
            // 
            // colKasaCikis
            // 
            this.colKasaCikis.Caption = "Kasa Çıkış";
            this.colKasaCikis.DisplayFormat.FormatString = "C2";
            this.colKasaCikis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKasaCikis.FieldName = "KasaCikis";
            this.colKasaCikis.MinWidth = 25;
            this.colKasaCikis.Name = "colKasaCikis";
            this.colKasaCikis.OptionsColumn.AllowEdit = false;
            this.colKasaCikis.OptionsColumn.ShowInCustomizationForm = false;
            this.colKasaCikis.Visible = true;
            this.colKasaCikis.VisibleIndex = 6;
            this.colKasaCikis.Width = 94;
            // 
            // colBakiye
            // 
            this.colBakiye.Caption = "Bakiye";
            this.colBakiye.DisplayFormat.FormatString = "C2";
            this.colBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBakiye.FieldName = "Bakiye";
            this.colBakiye.MinWidth = 25;
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.OptionsColumn.AllowEdit = false;
            this.colBakiye.OptionsColumn.ShowInCustomizationForm = false;
            this.colBakiye.Visible = true;
            this.colBakiye.VisibleIndex = 7;
            this.colBakiye.Width = 94;
            // 
            // FrmKasaSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 724);
            this.Controls.Add(this.gridContSecim);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmKasaSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Seçim Ekranı";
            this.Load += new System.EventHandler(this.FrmKasaSecim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContSecim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSecim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraGrid.GridControl gridContSecim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSecim;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaGiris;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colBakiye;
    }
}