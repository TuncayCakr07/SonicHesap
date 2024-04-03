namespace SonicHesap.BackOffice.Kasa_Hareketleri
{
    partial class FrmKasaHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasaHareketleri));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnFormKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageMenu = new System.Windows.Forms.ImageList(this.components);
            this.btnFiltreKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltrele = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridContKasaHareket = new DevExpress.XtraGrid.GridControl();
            this.gridKasaHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnDetayGor = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContKasaHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
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
            this.lblBaslik.Size = new System.Drawing.Size(1327, 66);
            this.lblBaslik.TabIndex = 12;
            this.lblBaslik.Text = "Kasa Hareketleri";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContKasaHareket);
            this.splitContainerControl1.Panel2.Controls.Add(this.grpMenu);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1327, 754);
            this.splitContainerControl1.SplitterPosition = 242;
            this.splitContainerControl1.TabIndex = 14;
            // 
            // btnFormKapat
            // 
            this.btnFormKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormKapat.ImageOptions.ImageIndex = 5;
            this.btnFormKapat.ImageOptions.ImageList = this.ımageMenu;
            this.btnFormKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnFormKapat.Location = new System.Drawing.Point(1257, 189);
            this.btnFormKapat.Name = "btnFormKapat";
            this.btnFormKapat.Size = new System.Drawing.Size(69, 53);
            this.btnFormKapat.TabIndex = 3;
            this.btnFormKapat.Click += new System.EventHandler(this.btnFormKapat_Click);
            // 
            // ımageMenu
            // 
            this.ımageMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageMenu.ImageStream")));
            this.ımageMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageMenu.Images.SetKeyName(0, "Alım Faturası.fw.png");
            this.ımageMenu.Images.SetKeyName(1, "arrow_left_red.png");
            this.ımageMenu.Images.SetKeyName(2, "brush.png");
            this.ımageMenu.Images.SetKeyName(3, "delete.png");
            this.ımageMenu.Images.SetKeyName(4, "factory.png");
            this.ımageMenu.Images.SetKeyName(5, "folder_out.png");
            this.ımageMenu.Images.SetKeyName(6, "funnel.png");
            this.ımageMenu.Images.SetKeyName(7, "funnel_delete.png");
            this.ımageMenu.Images.SetKeyName(8, "İade Faturaları.png");
            this.ımageMenu.Images.SetKeyName(9, "money.png");
            this.ımageMenu.Images.SetKeyName(10, "money48.png");
            this.ımageMenu.Images.SetKeyName(11, "note.png");
            this.ımageMenu.Images.SetKeyName(12, "note_add.png");
            this.ımageMenu.Images.SetKeyName(13, "note_delete.png");
            this.ımageMenu.Images.SetKeyName(14, "note_edit.png");
            this.ımageMenu.Images.SetKeyName(15, "note_information.png");
            this.ımageMenu.Images.SetKeyName(16, "note_ok.png");
            this.ımageMenu.Images.SetKeyName(17, "refresh.png");
            this.ımageMenu.Images.SetKeyName(18, "safe.png");
            this.ımageMenu.Images.SetKeyName(19, "Satış Faturası.fw.png");
            this.ımageMenu.Images.SetKeyName(20, "scroll.png");
            this.ımageMenu.Images.SetKeyName(21, "shopping_basket.png");
            this.ımageMenu.Images.SetKeyName(22, "shopping_cart.png");
            this.ımageMenu.Images.SetKeyName(23, "ticket_blue.png");
            this.ımageMenu.Images.SetKeyName(24, "user.png");
            this.ımageMenu.Images.SetKeyName(25, "user_headset.png");
            this.ımageMenu.Images.SetKeyName(26, "view.png");
            // 
            // btnFiltreKapat
            // 
            this.btnFiltreKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltreKapat.ImageOptions.ImageIndex = 7;
            this.btnFiltreKapat.ImageOptions.ImageList = this.ımageMenu;
            this.btnFiltreKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnFiltreKapat.Location = new System.Drawing.Point(1187, 189);
            this.btnFiltreKapat.Name = "btnFiltreKapat";
            this.btnFiltreKapat.Size = new System.Drawing.Size(69, 53);
            this.btnFiltreKapat.TabIndex = 4;
            this.btnFiltreKapat.Click += new System.EventHandler(this.btnFiltreKapat_Click);
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrele.ImageOptions.ImageIndex = 6;
            this.btnFiltrele.ImageOptions.ImageList = this.ımageMenu;
            this.btnFiltrele.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnFiltrele.Location = new System.Drawing.Point(1117, 189);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(69, 53);
            this.btnFiltrele.TabIndex = 5;
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
            this.filterControl1.Size = new System.Drawing.Size(1327, 242);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.SourceControl = this.gridContKasaHareket;
            this.filterControl1.TabIndex = 2;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridContKasaHareket
            // 
            this.gridContKasaHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContKasaHareket.Location = new System.Drawing.Point(0, 0);
            this.gridContKasaHareket.MainView = this.gridKasaHareket;
            this.gridContKasaHareket.Name = "gridContKasaHareket";
            this.gridContKasaHareket.Size = new System.Drawing.Size(1327, 420);
            this.gridContKasaHareket.TabIndex = 2;
            this.gridContKasaHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKasaHareket});
            // 
            // gridKasaHareket
            // 
            this.gridKasaHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colHareket,
            this.colKasaKodu,
            this.colKasaAdi,
            this.colOdemeTuruKodu,
            this.colOdemeTuruAdi,
            this.colCariKodu,
            this.colCariAdi,
            this.colTarih,
            this.colSaat,
            this.colTutar,
            this.colAciklama});
            this.gridKasaHareket.CustomizationFormBounds = new System.Drawing.Rectangle(1062, 322, 326, 271);
            this.gridKasaHareket.GridControl = this.gridContKasaHareket;
            this.gridKasaHareket.Name = "gridKasaHareket";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.Width = 108;
            // 
            // colFisKodu
            // 
            this.colFisKodu.Caption = "Fiş Kodu";
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.MinWidth = 25;
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 0;
            this.colFisKodu.Width = 78;
            // 
            // colHareket
            // 
            this.colHareket.Caption = "Hareket";
            this.colHareket.FieldName = "Hareket";
            this.colHareket.MinWidth = 25;
            this.colHareket.Name = "colHareket";
            this.colHareket.OptionsColumn.AllowEdit = false;
            this.colHareket.OptionsColumn.ShowInCustomizationForm = false;
            this.colHareket.Visible = true;
            this.colHareket.VisibleIndex = 1;
            this.colHareket.Width = 77;
            // 
            // colKasaKodu
            // 
            this.colKasaKodu.FieldName = "KasaKodu";
            this.colKasaKodu.MinWidth = 25;
            this.colKasaKodu.Name = "colKasaKodu";
            this.colKasaKodu.OptionsColumn.AllowEdit = false;
            this.colKasaKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colKasaKodu.Visible = true;
            this.colKasaKodu.VisibleIndex = 2;
            this.colKasaKodu.Width = 108;
            // 
            // colKasaAdi
            // 
            this.colKasaAdi.FieldName = "KasaAdi";
            this.colKasaAdi.MinWidth = 25;
            this.colKasaAdi.Name = "colKasaAdi";
            this.colKasaAdi.OptionsColumn.AllowEdit = false;
            this.colKasaAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colKasaAdi.Visible = true;
            this.colKasaAdi.VisibleIndex = 3;
            this.colKasaAdi.Width = 108;
            // 
            // colOdemeTuruKodu
            // 
            this.colOdemeTuruKodu.FieldName = "OdemeTuruKodu";
            this.colOdemeTuruKodu.MinWidth = 25;
            this.colOdemeTuruKodu.Name = "colOdemeTuruKodu";
            this.colOdemeTuruKodu.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colOdemeTuruKodu.Visible = true;
            this.colOdemeTuruKodu.VisibleIndex = 5;
            this.colOdemeTuruKodu.Width = 166;
            // 
            // colOdemeTuruAdi
            // 
            this.colOdemeTuruAdi.Caption = "Ödeme Türü";
            this.colOdemeTuruAdi.FieldName = "OdemeTuruAdi";
            this.colOdemeTuruAdi.MinWidth = 25;
            this.colOdemeTuruAdi.Name = "colOdemeTuruAdi";
            this.colOdemeTuruAdi.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colOdemeTuruAdi.Visible = true;
            this.colOdemeTuruAdi.VisibleIndex = 4;
            this.colOdemeTuruAdi.Width = 105;
            // 
            // colCariKodu
            // 
            this.colCariKodu.Caption = "Cari Kodu";
            this.colCariKodu.FieldName = "CariKodu";
            this.colCariKodu.MinWidth = 25;
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.OptionsColumn.AllowEdit = false;
            this.colCariKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 6;
            this.colCariKodu.Width = 88;
            // 
            // colCariAdi
            // 
            this.colCariAdi.Caption = "Cari Adı";
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.MinWidth = 25;
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.OptionsColumn.AllowEdit = false;
            this.colCariAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 7;
            this.colCariAdi.Width = 307;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.DisplayFormat.FormatString = "d";
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.MinWidth = 25;
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.OptionsColumn.ShowInCustomizationForm = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 8;
            this.colTarih.Width = 102;
            // 
            // colSaat
            // 
            this.colSaat.Caption = "Saat";
            this.colSaat.DisplayFormat.FormatString = "t";
            this.colSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaat.FieldName = "Tarih";
            this.colSaat.MinWidth = 25;
            this.colSaat.Name = "colSaat";
            this.colSaat.OptionsColumn.AllowEdit = false;
            this.colSaat.Visible = true;
            this.colSaat.VisibleIndex = 9;
            this.colSaat.Width = 83;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.DisplayFormat.FormatString = "C2";
            this.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.MinWidth = 25;
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.OptionsColumn.ShowInCustomizationForm = false;
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 11;
            this.colTutar.Width = 126;
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
            this.colAciklama.VisibleIndex = 10;
            this.colAciklama.Width = 331;
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnDetayGor);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.btnGuncelle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 420);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1327, 80);
            this.grpMenu.TabIndex = 5;
            this.grpMenu.Text = "Menü";
            // 
            // btnDetayGor
            // 
            this.btnDetayGor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDetayGor.ImageOptions.ImageIndex = 15;
            this.btnDetayGor.ImageOptions.ImageList = this.ımageMenu;
            this.btnDetayGor.Location = new System.Drawing.Point(113, 28);
            this.btnDetayGor.Name = "btnDetayGor";
            this.btnDetayGor.Size = new System.Drawing.Size(120, 50);
            this.btnDetayGor.TabIndex = 2;
            this.btnDetayGor.Text = "Detay Gör";
            this.btnDetayGor.Click += new System.EventHandler(this.btnDetayGor_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.ImageOptions.ImageIndex = 5;
            this.btnKapat.ImageOptions.ImageList = this.ımageMenu;
            this.btnKapat.Location = new System.Drawing.Point(1231, 28);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(94, 50);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 26;
            this.btnAra.ImageOptions.ImageList = this.ımageMenu;
            this.btnAra.Location = new System.Drawing.Point(233, 28);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(111, 54);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGuncelle.ImageOptions.ImageIndex = 17;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageMenu;
            this.btnGuncelle.Location = new System.Drawing.Point(2, 28);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(111, 50);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // FrmKasaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 754);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmKasaHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Hareketleri";
            this.Load += new System.EventHandler(this.FrmKasaHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContKasaHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridContKasaHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKasaHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraEditors.SimpleButton btnFormKapat;
        private DevExpress.XtraEditors.SimpleButton btnFiltreKapat;
        private DevExpress.XtraEditors.SimpleButton btnFiltrele;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private System.Windows.Forms.ImageList ımageMenu;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnDetayGor;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
    }
}