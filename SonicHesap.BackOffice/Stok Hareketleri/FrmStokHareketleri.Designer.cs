namespace SonicHesap.BackOffice.Stok_Hareketleri
{
    partial class FrmStokHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokHareketleri));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnFormKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnFiltreKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltrele = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridContStokHareket = new DevExpress.XtraGrid.GridControl();
            this.gridStokHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoBirimFiyat = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colIndirimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoDepoSecim = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colSeriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoSeriNo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimtutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKdvToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnDetayGor = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.fisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContStokHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDepoSecim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSeriNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fisBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContStokHareket);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1450, 594);
            this.splitContainerControl1.SplitterPosition = 233;
            this.splitContainerControl1.TabIndex = 5;
            // 
            // btnFormKapat
            // 
            this.btnFormKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormKapat.ImageOptions.ImageIndex = 0;
            this.btnFormKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnFormKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnFormKapat.Location = new System.Drawing.Point(1376, 180);
            this.btnFormKapat.Name = "btnFormKapat";
            this.btnFormKapat.Size = new System.Drawing.Size(69, 53);
            this.btnFormKapat.TabIndex = 1;
            this.btnFormKapat.Click += new System.EventHandler(this.btnFormKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "refresh.png");
            this.ımageList1.Images.SetKeyName(2, "Stok Düzenle.png");
            this.ımageList1.Images.SetKeyName(3, "Stok Ekle.png");
            this.ımageList1.Images.SetKeyName(4, "Stok Kopyala.png");
            this.ımageList1.Images.SetKeyName(5, "Stok Sil.png");
            this.ımageList1.Images.SetKeyName(6, "view.png");
            this.ımageList1.Images.SetKeyName(7, "folder_out.png");
            this.ımageList1.Images.SetKeyName(8, "funnel.png");
            this.ımageList1.Images.SetKeyName(9, "funnel_delete.png");
            this.ımageList1.Images.SetKeyName(10, "StokHareket.png");
            this.ımageList1.Images.SetKeyName(11, "information.png");
            // 
            // btnFiltreKapat
            // 
            this.btnFiltreKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltreKapat.ImageOptions.ImageIndex = 9;
            this.btnFiltreKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnFiltreKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnFiltreKapat.Location = new System.Drawing.Point(1305, 180);
            this.btnFiltreKapat.Name = "btnFiltreKapat";
            this.btnFiltreKapat.Size = new System.Drawing.Size(69, 53);
            this.btnFiltreKapat.TabIndex = 1;
            this.btnFiltreKapat.Click += new System.EventHandler(this.btnFiltreKapat_Click);
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrele.ImageOptions.ImageIndex = 8;
            this.btnFiltrele.ImageOptions.ImageList = this.ımageList1;
            this.btnFiltrele.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnFiltrele.Location = new System.Drawing.Point(1234, 180);
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
            this.filterControl1.Size = new System.Drawing.Size(1450, 233);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.SourceControl = this.gridContStokHareket;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridContStokHareket
            // 
            this.gridContStokHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContStokHareket.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gridContStokHareket.Location = new System.Drawing.Point(0, 0);
            this.gridContStokHareket.MainView = this.gridStokHareket;
            this.gridContStokHareket.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gridContStokHareket.Name = "gridContStokHareket";
            this.gridContStokHareket.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoBirimFiyat,
            this.repoDepoSecim,
            this.repoSeriNo});
            this.gridContStokHareket.Size = new System.Drawing.Size(1450, 349);
            this.gridContStokHareket.TabIndex = 2;
            this.gridContStokHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridStokHareket});
            // 
            // gridStokHareket
            // 
            this.gridStokHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.ColFisKodu,
            this.colStokKodu,
            this.colStokAdi,
            this.colBarkodTuru,
            this.colBarkod,
            this.colBirimi,
            this.colMiktar,
            this.colKdv,
            this.colBirimFiyati,
            this.colIndirimOrani,
            this.colDepoKodu,
            this.colDepoAdi,
            this.colSeriNo,
            this.colAciklama,
            this.colIndirimtutari,
            this.colToplamTutar,
            this.colKdvToplam});
            this.gridStokHareket.GridControl = this.gridContStokHareket;
            this.gridStokHareket.Name = "gridStokHareket";
            this.gridStokHareket.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridStokHareket.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.Width = 94;
            // 
            // ColFisKodu
            // 
            this.ColFisKodu.Caption = "Fiş Kodu";
            this.ColFisKodu.FieldName = "FisKodu";
            this.ColFisKodu.MinWidth = 25;
            this.ColFisKodu.Name = "ColFisKodu";
            this.ColFisKodu.OptionsColumn.AllowFocus = false;
            this.ColFisKodu.Visible = true;
            this.ColFisKodu.VisibleIndex = 0;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Stok.Stok Kodu";
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.MinWidth = 25;
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colStokKodu.Width = 94;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Ürün Adı";
            this.colStokAdi.FieldName = "Stok.StokAdi";
            this.colStokAdi.MinWidth = 25;
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 3;
            this.colStokAdi.Width = 222;
            // 
            // colBarkodTuru
            // 
            this.colBarkodTuru.Caption = "Barkod Türü";
            this.colBarkodTuru.FieldName = "Stok.BarkodTuru";
            this.colBarkodTuru.MinWidth = 25;
            this.colBarkodTuru.Name = "colBarkodTuru";
            this.colBarkodTuru.OptionsColumn.AllowEdit = false;
            this.colBarkodTuru.OptionsColumn.ShowInCustomizationForm = false;
            this.colBarkodTuru.Visible = true;
            this.colBarkodTuru.VisibleIndex = 1;
            this.colBarkodTuru.Width = 74;
            // 
            // colBarkod
            // 
            this.colBarkod.Caption = "Barkod";
            this.colBarkod.FieldName = "Stok.Barkod";
            this.colBarkod.MinWidth = 25;
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            this.colBarkod.OptionsColumn.ShowInCustomizationForm = false;
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 2;
            this.colBarkod.Width = 91;
            // 
            // colBirimi
            // 
            this.colBirimi.Caption = "Birimi";
            this.colBirimi.FieldName = "Stok.Birimi";
            this.colBirimi.MinWidth = 25;
            this.colBirimi.Name = "colBirimi";
            this.colBirimi.OptionsColumn.AllowEdit = false;
            this.colBirimi.OptionsColumn.ShowInCustomizationForm = false;
            this.colBirimi.Visible = true;
            this.colBirimi.VisibleIndex = 7;
            this.colBirimi.Width = 68;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar";
            this.colMiktar.DisplayFormat.FormatString = "N3";
            this.colMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.MinWidth = 25;
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.ShowInCustomizationForm = false;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 8;
            this.colMiktar.Width = 68;
            // 
            // colKdv
            // 
            this.colKdv.Caption = "KDV(%)";
            this.colKdv.DisplayFormat.FormatString = "\'%\'0";
            this.colKdv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKdv.FieldName = "Kdv";
            this.colKdv.MinWidth = 25;
            this.colKdv.Name = "colKdv";
            this.colKdv.OptionsColumn.AllowEdit = false;
            this.colKdv.OptionsColumn.ShowInCustomizationForm = false;
            this.colKdv.Visible = true;
            this.colKdv.VisibleIndex = 9;
            this.colKdv.Width = 68;
            // 
            // colBirimFiyati
            // 
            this.colBirimFiyati.Caption = "Birim Fiyatı";
            this.colBirimFiyati.ColumnEdit = this.repoBirimFiyat;
            this.colBirimFiyati.DisplayFormat.FormatString = "C2";
            this.colBirimFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBirimFiyati.FieldName = "BirimFiyati";
            this.colBirimFiyati.MinWidth = 25;
            this.colBirimFiyati.Name = "colBirimFiyati";
            this.colBirimFiyati.OptionsColumn.ShowInCustomizationForm = false;
            this.colBirimFiyati.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colBirimFiyati.Visible = true;
            this.colBirimFiyati.VisibleIndex = 10;
            this.colBirimFiyati.Width = 107;
            // 
            // repoBirimFiyat
            // 
            this.repoBirimFiyat.AutoHeight = false;
            this.repoBirimFiyat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.repoBirimFiyat.Name = "repoBirimFiyat";
            // 
            // colIndirimOrani
            // 
            this.colIndirimOrani.Caption = "İnd.Oranı(%)";
            this.colIndirimOrani.DisplayFormat.FormatString = "\'%\'0";
            this.colIndirimOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirimOrani.FieldName = "IndirimOrani";
            this.colIndirimOrani.MinWidth = 25;
            this.colIndirimOrani.Name = "colIndirimOrani";
            this.colIndirimOrani.OptionsColumn.ShowInCustomizationForm = false;
            this.colIndirimOrani.Visible = true;
            this.colIndirimOrani.VisibleIndex = 12;
            this.colIndirimOrani.Width = 57;
            // 
            // colDepoKodu
            // 
            this.colDepoKodu.Caption = "Depo Kodu";
            this.colDepoKodu.FieldName = "Depo.DepoKodu";
            this.colDepoKodu.MinWidth = 25;
            this.colDepoKodu.Name = "colDepoKodu";
            this.colDepoKodu.OptionsColumn.AllowEdit = false;
            this.colDepoKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colDepoKodu.Visible = true;
            this.colDepoKodu.VisibleIndex = 4;
            this.colDepoKodu.Width = 55;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.Caption = "Depo Adı";
            this.colDepoAdi.ColumnEdit = this.repoDepoSecim;
            this.colDepoAdi.FieldName = "Depo.DepoAdi";
            this.colDepoAdi.MinWidth = 25;
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colDepoAdi.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colDepoAdi.Visible = true;
            this.colDepoAdi.VisibleIndex = 5;
            this.colDepoAdi.Width = 148;
            // 
            // repoDepoSecim
            // 
            this.repoDepoSecim.AutoHeight = false;
            this.repoDepoSecim.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.repoDepoSecim.Name = "repoDepoSecim";
            // 
            // colSeriNo
            // 
            this.colSeriNo.Caption = "Seri No";
            this.colSeriNo.ColumnEdit = this.repoSeriNo;
            this.colSeriNo.FieldName = "SeriNo";
            this.colSeriNo.MinWidth = 25;
            this.colSeriNo.Name = "colSeriNo";
            this.colSeriNo.OptionsColumn.ShowInCustomizationForm = false;
            this.colSeriNo.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colSeriNo.Visible = true;
            this.colSeriNo.VisibleIndex = 6;
            this.colSeriNo.Width = 106;
            // 
            // repoSeriNo
            // 
            this.repoSeriNo.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            editorButtonImageOptions1.ImageIndex = 4;
            editorButtonImageOptions1.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.repoSeriNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Seri No", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repoSeriNo.Name = "repoSeriNo";
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.OptionsColumn.ShowInCustomizationForm = false;
            this.colAciklama.Width = 100;
            // 
            // colIndirimtutari
            // 
            this.colIndirimtutari.Caption = "İnd.Tutarı";
            this.colIndirimtutari.DisplayFormat.FormatString = "C2";
            this.colIndirimtutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirimtutari.FieldName = "colIndirimtutari";
            this.colIndirimtutari.MinWidth = 25;
            this.colIndirimtutari.Name = "colIndirimtutari";
            this.colIndirimtutari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colIndirimtutari", "SUM={0:C2}")});
            this.colIndirimtutari.UnboundDataType = typeof(decimal);
            this.colIndirimtutari.UnboundExpression = "[colToplamTutar] / 100 * [IndirimOrani]";
            this.colIndirimtutari.Visible = true;
            this.colIndirimtutari.VisibleIndex = 13;
            this.colIndirimtutari.Width = 69;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Caption = "Toplam Tutar";
            this.colToplamTutar.DisplayFormat.FormatString = "C2";
            this.colToplamTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplamTutar.FieldName = "colToplamTutar";
            this.colToplamTutar.MinWidth = 25;
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colToplamTutar", "SUM={0:C2}")});
            this.colToplamTutar.UnboundDataType = typeof(decimal);
            this.colToplamTutar.UnboundExpression = "[BirimFiyati] * [Miktar] - [BirimFiyati] * [Miktar] / 100 * [IndirimOrani]";
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 14;
            this.colToplamTutar.Width = 130;
            // 
            // colKdvToplam
            // 
            this.colKdvToplam.Caption = "KDV Toplamı";
            this.colKdvToplam.DisplayFormat.FormatString = "C2";
            this.colKdvToplam.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKdvToplam.FieldName = "colKdvToplam";
            this.colKdvToplam.MinWidth = 25;
            this.colKdvToplam.Name = "colKdvToplam";
            this.colKdvToplam.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colKdvToplam", "SUM={0:0.##}")});
            this.colKdvToplam.UnboundDataType = typeof(decimal);
            this.colKdvToplam.UnboundExpression = "[colToplamTutar] / 100 * [Kdv]";
            this.colKdvToplam.Visible = true;
            this.colKdvToplam.VisibleIndex = 11;
            this.colKdvToplam.Width = 82;
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnDetayGor);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.btnGuncelle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 660);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1450, 83);
            this.grpMenu.TabIndex = 4;
            this.grpMenu.Text = "Menü";
            // 
            // btnDetayGor
            // 
            this.btnDetayGor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDetayGor.ImageOptions.ImageIndex = 11;
            this.btnDetayGor.ImageOptions.ImageList = this.ımageList1;
            this.btnDetayGor.Location = new System.Drawing.Point(113, 28);
            this.btnDetayGor.Name = "btnDetayGor";
            this.btnDetayGor.Size = new System.Drawing.Size(120, 53);
            this.btnDetayGor.TabIndex = 2;
            this.btnDetayGor.Text = "Detay Gör";
            this.btnDetayGor.Click += new System.EventHandler(this.btnDetayGor_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(1354, 28);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(94, 53);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 6;
            this.btnAra.ImageOptions.ImageList = this.ımageList1;
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
            this.btnGuncelle.ImageOptions.ImageIndex = 1;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(2, 28);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(111, 53);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
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
            this.lblBaslik.Size = new System.Drawing.Size(1450, 66);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Stok Hareketleri";
            // 
            // fisBindingSource
            // 
            this.fisBindingSource.DataSource = typeof(SonicHesap.Entities.Tables.Fis);
            // 
            // FrmStokHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 743);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmStokHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Hareketleri";
            this.Load += new System.EventHandler(this.FrmStokHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContStokHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDepoSecim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSeriNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnFormKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnFiltreKapat;
        private DevExpress.XtraEditors.SimpleButton btnFiltrele;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.SimpleButton btnDetayGor;
        private System.Windows.Forms.BindingSource fisBindingSource;
        private DevExpress.XtraGrid.GridControl gridContStokHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridStokHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn ColFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBirimFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoDepoSecim;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoSeriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimtutari;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colKdvToplam;
    }
}