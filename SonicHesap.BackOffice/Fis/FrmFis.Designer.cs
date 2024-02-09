namespace SonicHesap.BackOffice.Fis
{
    partial class FrmFis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFis));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.btnFormKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageMenu = new System.Windows.Forms.ImageList(this.components);
            this.btnFiltreKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltrele = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridContFis = new DevExpress.XtraGrid.GridControl();
            this.gridFis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlasiyerKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlasiyerAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdenen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKalanTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barAlisFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.barPerakendeSatisFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barToptanSatisFaturası = new DevExpress.XtraBars.BarButtonItem();
            this.barAlisIadeFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.barSatisIadeFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.barTahsilatFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barOdemeFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barCariDevirFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barSayimFazlasiFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barSayimEksigiFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barStokDevirFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContFis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(1365, 66);
            this.lblBaslik.TabIndex = 9;
            this.lblBaslik.Text = "Fiş Ve Faturalar";
            // 
            // btnFormKapat
            // 
            this.btnFormKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormKapat.ImageOptions.ImageIndex = 5;
            this.btnFormKapat.ImageOptions.ImageList = this.ımageMenu;
            this.btnFormKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnFormKapat.Location = new System.Drawing.Point(1293, 187);
            this.btnFormKapat.Name = "btnFormKapat";
            this.btnFormKapat.Size = new System.Drawing.Size(69, 53);
            this.btnFormKapat.TabIndex = 1;
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
            this.btnFiltreKapat.Location = new System.Drawing.Point(1223, 187);
            this.btnFiltreKapat.Name = "btnFiltreKapat";
            this.btnFiltreKapat.Size = new System.Drawing.Size(69, 53);
            this.btnFiltreKapat.TabIndex = 1;
            this.btnFiltreKapat.Click += new System.EventHandler(this.btnFiltreKapat_Click);
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrele.ImageOptions.ImageIndex = 6;
            this.btnFiltrele.ImageOptions.ImageList = this.ımageMenu;
            this.btnFiltrele.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnFiltrele.Location = new System.Drawing.Point(1153, 187);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(69, 53);
            this.btnFiltrele.TabIndex = 1;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
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
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContFis);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1365, 660);
            this.splitContainerControl1.SplitterPosition = 242;
            this.splitContainerControl1.TabIndex = 11;
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.NodeSeparatorHeight = 2;
            this.filterControl1.ShowActionButtonMode = DevExpress.XtraEditors.ShowActionButtonMode.Default;
            this.filterControl1.Size = new System.Drawing.Size(1365, 242);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridContFis
            // 
            this.gridContFis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContFis.Location = new System.Drawing.Point(0, 0);
            this.gridContFis.MainView = this.gridFis;
            this.gridContFis.Name = "gridContFis";
            this.gridContFis.Size = new System.Drawing.Size(1365, 406);
            this.gridContFis.TabIndex = 2;
            this.gridContFis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridFis});
            // 
            // gridFis
            // 
            this.gridFis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colFisTuru,
            this.colCariKodu,
            this.colCariAdi,
            this.colBelgeNo,
            this.colTarih,
            this.colSaat,
            this.colPlasiyerKodu,
            this.colPlasiyerAdi,
            this.colIskontoOrani,
            this.colIskontoTutar,
            this.colToplamTutar,
            this.colAciklama,
            this.colOdenen,
            this.colKalanTutar});
            this.gridFis.CustomizationFormBounds = new System.Drawing.Rectangle(1062, 322, 326, 271);
            this.gridFis.GridControl = this.gridContFis;
            this.gridFis.Name = "gridFis";
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
            this.colFisKodu.Width = 87;
            // 
            // colFisTuru
            // 
            this.colFisTuru.Caption = "Fiş Türü";
            this.colFisTuru.FieldName = "FisTuru";
            this.colFisTuru.MinWidth = 25;
            this.colFisTuru.Name = "colFisTuru";
            this.colFisTuru.OptionsColumn.AllowEdit = false;
            this.colFisTuru.OptionsColumn.ShowInCustomizationForm = false;
            this.colFisTuru.Visible = true;
            this.colFisTuru.VisibleIndex = 1;
            this.colFisTuru.Width = 137;
            // 
            // colCariKodu
            // 
            this.colCariKodu.Caption = "Cari Kodu";
            this.colCariKodu.FieldName = "CariKodu";
            this.colCariKodu.MinWidth = 25;
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 2;
            this.colCariKodu.Width = 93;
            // 
            // colCariAdi
            // 
            this.colCariAdi.Caption = "Cari Adı";
            this.colCariAdi.FieldName = "Cari Adı";
            this.colCariAdi.MinWidth = 25;
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 3;
            this.colCariAdi.Width = 161;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.Caption = "Belge No";
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.MinWidth = 25;
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.OptionsColumn.AllowEdit = false;
            this.colBelgeNo.OptionsColumn.ShowInCustomizationForm = false;
            this.colBelgeNo.Visible = true;
            this.colBelgeNo.VisibleIndex = 4;
            this.colBelgeNo.Width = 63;
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
            this.colTarih.VisibleIndex = 5;
            this.colTarih.Width = 67;
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
            this.colSaat.VisibleIndex = 6;
            this.colSaat.Width = 67;
            // 
            // colPlasiyerKodu
            // 
            this.colPlasiyerKodu.Caption = "Plasiyer Kodu";
            this.colPlasiyerKodu.FieldName = "PlasiyerKodu";
            this.colPlasiyerKodu.MinWidth = 25;
            this.colPlasiyerKodu.Name = "colPlasiyerKodu";
            this.colPlasiyerKodu.OptionsColumn.AllowEdit = false;
            this.colPlasiyerKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colPlasiyerKodu.Width = 94;
            // 
            // colPlasiyerAdi
            // 
            this.colPlasiyerAdi.Caption = "Plasiyer Adı";
            this.colPlasiyerAdi.FieldName = "PlasiyerAdi";
            this.colPlasiyerAdi.MinWidth = 25;
            this.colPlasiyerAdi.Name = "colPlasiyerAdi";
            this.colPlasiyerAdi.OptionsColumn.AllowEdit = false;
            this.colPlasiyerAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colPlasiyerAdi.Visible = true;
            this.colPlasiyerAdi.VisibleIndex = 7;
            this.colPlasiyerAdi.Width = 124;
            // 
            // colIskontoOrani
            // 
            this.colIskontoOrani.Caption = "İsk. Oranı";
            this.colIskontoOrani.DisplayFormat.FormatString = "\'%0\'";
            this.colIskontoOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIskontoOrani.FieldName = "IskontoOrani";
            this.colIskontoOrani.MinWidth = 25;
            this.colIskontoOrani.Name = "colIskontoOrani";
            this.colIskontoOrani.OptionsColumn.AllowEdit = false;
            this.colIskontoOrani.OptionsColumn.ShowInCustomizationForm = false;
            this.colIskontoOrani.Visible = true;
            this.colIskontoOrani.VisibleIndex = 9;
            this.colIskontoOrani.Width = 63;
            // 
            // colIskontoTutar
            // 
            this.colIskontoTutar.Caption = "İsk. Tutarı";
            this.colIskontoTutar.DisplayFormat.FormatString = "C2";
            this.colIskontoTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIskontoTutar.FieldName = "IskontoTutar";
            this.colIskontoTutar.MinWidth = 25;
            this.colIskontoTutar.Name = "colIskontoTutar";
            this.colIskontoTutar.OptionsColumn.AllowEdit = false;
            this.colIskontoTutar.OptionsColumn.ShowInCustomizationForm = false;
            this.colIskontoTutar.Visible = true;
            this.colIskontoTutar.VisibleIndex = 10;
            this.colIskontoTutar.Width = 97;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Caption = "Toplam Tutar";
            this.colToplamTutar.DisplayFormat.FormatString = "C2";
            this.colToplamTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplamTutar.FieldName = "ToplamTutar";
            this.colToplamTutar.MinWidth = 25;
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.OptionsColumn.AllowEdit = false;
            this.colToplamTutar.OptionsColumn.ShowInCustomizationForm = false;
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 11;
            this.colToplamTutar.Width = 138;
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
            this.colAciklama.VisibleIndex = 8;
            this.colAciklama.Width = 238;
            // 
            // colOdenen
            // 
            this.colOdenen.Caption = "Ödenen Tutar";
            this.colOdenen.DisplayFormat.FormatString = "C2";
            this.colOdenen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOdenen.FieldName = "Odenen";
            this.colOdenen.MinWidth = 25;
            this.colOdenen.Name = "colOdenen";
            this.colOdenen.OptionsColumn.AllowEdit = false;
            this.colOdenen.Width = 136;
            // 
            // colKalanTutar
            // 
            this.colKalanTutar.Caption = "Kalan Tutar";
            this.colKalanTutar.DisplayFormat.FormatString = "C2";
            this.colKalanTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKalanTutar.FieldName = "KalanOdeme";
            this.colKalanTutar.MinWidth = 25;
            this.colKalanTutar.Name = "colKalanTutar";
            this.colKalanTutar.OptionsColumn.AllowEdit = false;
            this.colKalanTutar.Width = 139;
            // 
            // btnKapat
            // 
            this.btnKapat.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Appearance.Options.UseFont = true;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.ImageOptions.ImageIndex = 5;
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
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.ImageIndex = 17;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageMenu;
            this.btnGuncelle.Location = new System.Drawing.Point(340, 28);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(111, 53);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.ImageIndex = 13;
            this.btnSil.ImageOptions.ImageList = this.ımageMenu;
            this.btnSil.Location = new System.Drawing.Point(228, 28);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(111, 53);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Appearance.Options.UseFont = true;
            this.btnDuzenle.ImageOptions.ImageIndex = 14;
            this.btnDuzenle.ImageOptions.ImageList = this.ımageMenu;
            this.btnDuzenle.Location = new System.Drawing.Point(116, 28);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(111, 53);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            // 
            // btnAra
            // 
            this.btnAra.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Appearance.Options.UseFont = true;
            this.btnAra.ImageOptions.ImageIndex = 26;
            this.btnAra.ImageOptions.ImageList = this.ımageMenu;
            this.btnAra.Location = new System.Drawing.Point(452, 28);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(111, 53);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.dropDownButton1);
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnGuncelle);
            this.grpMenu.Controls.Add(this.btnSil);
            this.grpMenu.Controls.Add(this.btnDuzenle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 660);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1365, 83);
            this.grpMenu.TabIndex = 10;
            this.grpMenu.Text = "Menü";
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dropDownButton1.Appearance.Options.UseFont = true;
            this.dropDownButton1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.dropDownButton1.DropDownControl = this.popupMenu1;
            this.dropDownButton1.ImageOptions.ImageIndex = 12;
            this.dropDownButton1.ImageOptions.ImageList = this.ımageMenu;
            this.dropDownButton1.Location = new System.Drawing.Point(4, 28);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(111, 53);
            this.dropDownButton1.TabIndex = 3;
            this.dropDownButton1.Text = "Ekle";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barAlisFaturasi
            // 
            this.barAlisFaturasi.Caption = "Alış Faturası";
            this.barAlisFaturasi.Id = 0;
            this.barAlisFaturasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAlisFaturasi.ImageOptions.Image")));
            this.barAlisFaturasi.Name = "barAlisFaturasi";
            this.barAlisFaturasi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barPerakendeSatisFaturasi
            // 
            this.barPerakendeSatisFaturasi.Caption = "Perakende Satış Faturası";
            this.barPerakendeSatisFaturasi.Id = 1;
            this.barPerakendeSatisFaturasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSatisFaturasi.ImageOptions.Image")));
            this.barPerakendeSatisFaturasi.Name = "barPerakendeSatisFaturasi";
            this.barPerakendeSatisFaturasi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barAlisFaturasi,
            this.barPerakendeSatisFaturasi,
            this.barToptanSatisFaturası,
            this.barAlisIadeFaturasi,
            this.barSatisIadeFaturasi,
            this.barTahsilatFisi,
            this.barOdemeFisi,
            this.barCariDevirFisi,
            this.barSayimFazlasiFisi,
            this.barSayimEksigiFisi,
            this.barStokDevirFisi,
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barSubItem4});
            this.barManager1.MaxItemId = 15;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1365, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 743);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1365, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 743);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1365, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 743);
            // 
            // barToptanSatisFaturası
            // 
            this.barToptanSatisFaturası.Caption = "Toptan Satış Faturası";
            this.barToptanSatisFaturası.Id = 2;
            this.barToptanSatisFaturası.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barToptanSatisFaturası.ImageOptions.Image")));
            this.barToptanSatisFaturası.Name = "barToptanSatisFaturası";
            this.barToptanSatisFaturası.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barAlisIadeFaturasi
            // 
            this.barAlisIadeFaturasi.Caption = "Alış İade Faturası";
            this.barAlisIadeFaturasi.Id = 3;
            this.barAlisIadeFaturasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAlisIadeFaturasi.ImageOptions.Image")));
            this.barAlisIadeFaturasi.Name = "barAlisIadeFaturasi";
            this.barAlisIadeFaturasi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barSatisIadeFaturasi
            // 
            this.barSatisIadeFaturasi.Caption = "Satış İade Faturası";
            this.barSatisIadeFaturasi.Id = 4;
            this.barSatisIadeFaturasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSatisIadeFaturasi.ImageOptions.Image")));
            this.barSatisIadeFaturasi.Name = "barSatisIadeFaturasi";
            this.barSatisIadeFaturasi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barTahsilatFisi
            // 
            this.barTahsilatFisi.Caption = "Tahsilat Fişi";
            this.barTahsilatFisi.Id = 5;
            this.barTahsilatFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barTahsilatFisi.ImageOptions.Image")));
            this.barTahsilatFisi.Name = "barTahsilatFisi";
            // 
            // barOdemeFisi
            // 
            this.barOdemeFisi.Caption = "Ödeme Fişi ";
            this.barOdemeFisi.Id = 6;
            this.barOdemeFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barOdemeFisi.ImageOptions.Image")));
            this.barOdemeFisi.Name = "barOdemeFisi";
            // 
            // barCariDevirFisi
            // 
            this.barCariDevirFisi.Caption = "Cari Devir Fişi";
            this.barCariDevirFisi.Id = 7;
            this.barCariDevirFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barCariDevirFisi.ImageOptions.Image")));
            this.barCariDevirFisi.Name = "barCariDevirFisi";
            // 
            // barSayimFazlasiFisi
            // 
            this.barSayimFazlasiFisi.Caption = "Sayım Fazlası Fişi";
            this.barSayimFazlasiFisi.Id = 8;
            this.barSayimFazlasiFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSayimFazlasiFisi.ImageOptions.Image")));
            this.barSayimFazlasiFisi.Name = "barSayimFazlasiFisi";
            this.barSayimFazlasiFisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barSayimEksigiFisi
            // 
            this.barSayimEksigiFisi.Caption = "Sayım Eksiği Fişi";
            this.barSayimEksigiFisi.Id = 9;
            this.barSayimEksigiFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSayimEksigiFisi.ImageOptions.Image")));
            this.barSayimEksigiFisi.Name = "barSayimEksigiFisi";
            this.barSayimEksigiFisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barStokDevirFisi
            // 
            this.barStokDevirFisi.Caption = "Stok Devir Fişi";
            this.barStokDevirFisi.Id = 10;
            this.barStokDevirFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barStokDevirFisi.ImageOptions.Image")));
            this.barStokDevirFisi.Name = "barStokDevirFisi";
            this.barStokDevirFisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_Click);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Faturalar";
            this.barSubItem1.Id = 11;
            this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barAlisFaturasi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barPerakendeSatisFaturasi, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barToptanSatisFaturası)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "İade Faturaları";
            this.barSubItem2.Id = 12;
            this.barSubItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem2.ImageOptions.Image")));
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSatisIadeFaturasi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barAlisIadeFaturasi, true)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Kasa Fişleri";
            this.barSubItem3.Id = 13;
            this.barSubItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem3.ImageOptions.Image")));
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barTahsilatFisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barOdemeFisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCariDevirFisi, true)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "Stok Fişleri";
            this.barSubItem4.Id = 14;
            this.barSubItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem4.ImageOptions.Image")));
            this.barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSayimEksigiFisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSayimFazlasiFisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStokDevirFisi, true)});
            this.barSubItem4.Name = "barSubItem4";
            // 
            // FrmFis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 743);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmFis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiş Ve Faturalar";
            this.Load += new System.EventHandler(this.FrmFis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContFis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.SimpleButton btnFormKapat;
        private System.Windows.Forms.ImageList ımageMenu;
        private DevExpress.XtraEditors.SimpleButton btnFiltreKapat;
        private DevExpress.XtraEditors.SimpleButton btnFiltrele;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraGrid.GridControl gridContFis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridFis;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colFisTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBelgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colPlasiyerKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPlasiyerAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colOdenen;
        private DevExpress.XtraGrid.Columns.GridColumn colKalanTutar;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barAlisFaturasi;
        private DevExpress.XtraBars.BarButtonItem barPerakendeSatisFaturasi;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barToptanSatisFaturası;
        private DevExpress.XtraBars.BarButtonItem barAlisIadeFaturasi;
        private DevExpress.XtraBars.BarButtonItem barSatisIadeFaturasi;
        private DevExpress.XtraBars.BarButtonItem barTahsilatFisi;
        private DevExpress.XtraBars.BarButtonItem barOdemeFisi;
        private DevExpress.XtraBars.BarButtonItem barCariDevirFisi;
        private DevExpress.XtraBars.BarButtonItem barSayimFazlasiFisi;
        private DevExpress.XtraBars.BarButtonItem barSayimEksigiFisi;
        private DevExpress.XtraBars.BarButtonItem barStokDevirFisi;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
    }
}