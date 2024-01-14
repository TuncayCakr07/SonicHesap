namespace SonicHesap.BackOffice.Kasa
{
    partial class FrmKasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasa));
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.ımageMenu = new System.Windows.Forms.ImageList(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnFormKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltreKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltrele = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridContKasalar = new DevExpress.XtraGrid.GridControl();
            this.gridKasalar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContKasalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasalar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.simpleButton1);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnGuncelle);
            this.grpMenu.Controls.Add(this.btnSil);
            this.grpMenu.Controls.Add(this.btnDuzenle);
            this.grpMenu.Controls.Add(this.btnEkle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 660);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1365, 83);
            this.grpMenu.TabIndex = 7;
            this.grpMenu.Text = "Menü";
            // 
            // btnAra
            // 
            this.btnAra.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAra.ImageOptions.ImageIndex = 12;
            this.btnAra.ImageOptions.ImageList = this.ımageMenu;
            this.btnAra.Location = new System.Drawing.Point(566, 28);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(111, 53);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // ımageMenu
            // 
            this.ımageMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageMenu.ImageStream")));
            this.ımageMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageMenu.Images.SetKeyName(0, "add.png");
            this.ımageMenu.Images.SetKeyName(1, "delete.png");
            this.ımageMenu.Images.SetKeyName(2, "funnel.png");
            this.ımageMenu.Images.SetKeyName(3, "funnel_delete.png");
            this.ımageMenu.Images.SetKeyName(4, "KasaDuzenle.png");
            this.ımageMenu.Images.SetKeyName(5, "KasaEkle.png");
            this.ımageMenu.Images.SetKeyName(6, "KasaHareket.png");
            this.ımageMenu.Images.SetKeyName(7, "KasaSil.png");
            this.ımageMenu.Images.SetKeyName(8, "pencil.png");
            this.ımageMenu.Images.SetKeyName(9, "refresh.png");
            this.ımageMenu.Images.SetKeyName(10, "replace2.png");
            this.ımageMenu.Images.SetKeyName(11, "safe.png");
            this.ımageMenu.Images.SetKeyName(12, "view.png");
            this.ımageMenu.Images.SetKeyName(13, "folder_out.png");
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton1.ImageOptions.ImageIndex = 6;
            this.simpleButton1.ImageOptions.ImageList = this.ımageMenu;
            this.simpleButton1.Location = new System.Drawing.Point(446, 28);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(120, 53);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Kasa\r\nHareket";
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.ImageOptions.ImageIndex = 13;
            this.btnKapat.ImageOptions.ImageList = this.ımageMenu;
            this.btnKapat.Location = new System.Drawing.Point(1269, 28);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(94, 53);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGuncelle.ImageOptions.ImageIndex = 9;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageMenu;
            this.btnGuncelle.Location = new System.Drawing.Point(335, 28);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(111, 53);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSil.ImageOptions.ImageIndex = 7;
            this.btnSil.ImageOptions.ImageList = this.ımageMenu;
            this.btnSil.Location = new System.Drawing.Point(224, 28);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(111, 53);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDuzenle.ImageOptions.ImageIndex = 4;
            this.btnDuzenle.ImageOptions.ImageList = this.ımageMenu;
            this.btnDuzenle.Location = new System.Drawing.Point(113, 28);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(111, 53);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEkle.ImageOptions.ImageIndex = 5;
            this.btnEkle.ImageOptions.ImageList = this.ımageMenu;
            this.btnEkle.Location = new System.Drawing.Point(2, 28);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 53);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 66);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFormKapat);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltreKapat);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltrele);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContKasalar);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1365, 677);
            this.splitContainerControl1.SplitterPosition = 214;
            this.splitContainerControl1.TabIndex = 8;
            // 
            // btnFormKapat
            // 
            this.btnFormKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormKapat.ImageOptions.ImageIndex = 13;
            this.btnFormKapat.ImageOptions.ImageList = this.ımageMenu;
            this.btnFormKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnFormKapat.Location = new System.Drawing.Point(1293, 159);
            this.btnFormKapat.Name = "btnFormKapat";
            this.btnFormKapat.Size = new System.Drawing.Size(69, 53);
            this.btnFormKapat.TabIndex = 1;
            this.btnFormKapat.Click += new System.EventHandler(this.btnFormKapat_Click);
            // 
            // btnFiltreKapat
            // 
            this.btnFiltreKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltreKapat.ImageOptions.ImageIndex = 3;
            this.btnFiltreKapat.ImageOptions.ImageList = this.ımageMenu;
            this.btnFiltreKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnFiltreKapat.Location = new System.Drawing.Point(1223, 159);
            this.btnFiltreKapat.Name = "btnFiltreKapat";
            this.btnFiltreKapat.Size = new System.Drawing.Size(69, 53);
            this.btnFiltreKapat.TabIndex = 1;
            this.btnFiltreKapat.Click += new System.EventHandler(this.btnFiltreKapat_Click);
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrele.ImageOptions.ImageIndex = 2;
            this.btnFiltrele.ImageOptions.ImageList = this.ımageMenu;
            this.btnFiltrele.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnFiltrele.Location = new System.Drawing.Point(1153, 159);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(69, 53);
            this.btnFiltrele.TabIndex = 1;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.NodeSeparatorHeight = 2;
            this.filterControl1.ShowActionButtonMode = DevExpress.XtraEditors.ShowActionButtonMode.Default;
            this.filterControl1.Size = new System.Drawing.Size(1365, 214);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.SourceControl = this.gridContKasalar;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridContKasalar
            // 
            this.gridContKasalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContKasalar.Location = new System.Drawing.Point(0, 0);
            this.gridContKasalar.MainView = this.gridKasalar;
            this.gridContKasalar.Name = "gridContKasalar";
            this.gridContKasalar.Size = new System.Drawing.Size(1365, 451);
            this.gridContKasalar.TabIndex = 0;
            this.gridContKasalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKasalar});
            // 
            // gridKasalar
            // 
            this.gridKasalar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKasaKodu,
            this.colKasaAdi,
            this.colYetkiliKodu,
            this.colYetkiliAdi,
            this.colAciklama,
            this.colKasaGiris,
            this.colKasaCikis,
            this.colBakiye});
            this.gridKasalar.GridControl = this.gridContKasalar;
            this.gridKasalar.Name = "gridKasalar";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
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
            this.lblBaslik.Size = new System.Drawing.Size(1365, 66);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "Kasalar";
            // 
            // FrmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 743);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmKasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasalar";
            this.Load += new System.EventHandler(this.FrmKasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContKasalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private System.Windows.Forms.ImageList ımageMenu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnFormKapat;
        private DevExpress.XtraEditors.SimpleButton btnFiltreKapat;
        private DevExpress.XtraEditors.SimpleButton btnFiltrele;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraGrid.GridControl gridContKasalar;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKasalar;
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