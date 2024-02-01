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
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.stokHareketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKdvTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDetayGor = new DevExpress.XtraEditors.SimpleButton();
            this.repoSeriNo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContStokHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokHareketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSeriNo)).BeginInit();
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
            this.filterControl1.SourceControl = this.gridContStokHareket;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridContStokHareket
            // 
            this.gridContStokHareket.DataSource = this.stokHareketBindingSource;
            this.gridContStokHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContStokHareket.Location = new System.Drawing.Point(0, 0);
            this.gridContStokHareket.MainView = this.gridStokHareket;
            this.gridContStokHareket.Name = "gridContStokHareket";
            this.gridContStokHareket.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoSeriNo});
            this.gridContStokHareket.Size = new System.Drawing.Size(1450, 349);
            this.gridContStokHareket.TabIndex = 0;
            this.gridContStokHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridStokHareket});
            // 
            // gridStokHareket
            // 
            this.gridStokHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colHareket,
            this.colStokKodu,
            this.colStokAdi,
            this.colBarkodTuru,
            this.colBarkod,
            this.colBirimi,
            this.colMiktar,
            this.colKdv,
            this.colKdvTutar,
            this.colBirimFiyati,
            this.colIndirimOrani,
            this.colIndirimTutar,
            this.colDepoKodu,
            this.colDepoAdi,
            this.colSeriNo,
            this.colTarih,
            this.colSaat,
            this.colAciklama,
            this.colToplamTutar});
            this.gridStokHareket.GridControl = this.gridContStokHareket;
            this.gridStokHareket.Name = "gridStokHareket";
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
            // stokHareketBindingSource
            // 
            this.stokHareketBindingSource.DataSource = typeof(SonicHesap.Entities.Tables.StokHareket);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Width = 94;
            // 
            // colFisKodu
            // 
            this.colFisKodu.Caption = "Fiş Kodu";
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.MinWidth = 25;
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 0;
            this.colFisKodu.Width = 76;
            // 
            // colHareket
            // 
            this.colHareket.Caption = "Hareket";
            this.colHareket.FieldName = "Hareket";
            this.colHareket.MinWidth = 25;
            this.colHareket.Name = "colHareket";
            this.colHareket.OptionsColumn.AllowEdit = false;
            this.colHareket.Visible = true;
            this.colHareket.VisibleIndex = 3;
            this.colHareket.Width = 136;
            // 
            // colStokKodu
            // 
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.MinWidth = 25;
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.Width = 94;
            // 
            // colStokAdi
            // 
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.MinWidth = 25;
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.Width = 94;
            // 
            // colBarkodTuru
            // 
            this.colBarkodTuru.FieldName = "BarkodTuru";
            this.colBarkodTuru.MinWidth = 25;
            this.colBarkodTuru.Name = "colBarkodTuru";
            this.colBarkodTuru.OptionsColumn.AllowEdit = false;
            this.colBarkodTuru.Width = 94;
            // 
            // colBarkod
            // 
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.MinWidth = 25;
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            this.colBarkod.Width = 94;
            // 
            // colBirimi
            // 
            this.colBirimi.Caption = "Birimi";
            this.colBirimi.FieldName = "Birimi";
            this.colBirimi.MinWidth = 25;
            this.colBirimi.Name = "colBirimi";
            this.colBirimi.OptionsColumn.AllowEdit = false;
            this.colBirimi.Visible = true;
            this.colBirimi.VisibleIndex = 4;
            this.colBirimi.Width = 76;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar";
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.MinWidth = 25;
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 9;
            this.colMiktar.Width = 60;
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
            this.colKdv.Visible = true;
            this.colKdv.VisibleIndex = 11;
            this.colKdv.Width = 58;
            // 
            // colBirimFiyati
            // 
            this.colBirimFiyati.Caption = "Birim Fiyatı";
            this.colBirimFiyati.DisplayFormat.FormatString = "C2";
            this.colBirimFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBirimFiyati.FieldName = "BirimFiyati";
            this.colBirimFiyati.MinWidth = 25;
            this.colBirimFiyati.Name = "colBirimFiyati";
            this.colBirimFiyati.OptionsColumn.AllowEdit = false;
            this.colBirimFiyati.Visible = true;
            this.colBirimFiyati.VisibleIndex = 10;
            this.colBirimFiyati.Width = 71;
            // 
            // colIndirimOrani
            // 
            this.colIndirimOrani.Caption = "İnd. Oranı(%)";
            this.colIndirimOrani.DisplayFormat.FormatString = "\'%\'0";
            this.colIndirimOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirimOrani.FieldName = "IndirimOrani";
            this.colIndirimOrani.MinWidth = 25;
            this.colIndirimOrani.Name = "colIndirimOrani";
            this.colIndirimOrani.OptionsColumn.AllowEdit = false;
            this.colIndirimOrani.Visible = true;
            this.colIndirimOrani.VisibleIndex = 12;
            this.colIndirimOrani.Width = 58;
            // 
            // colDepoKodu
            // 
            this.colDepoKodu.Caption = "Depo Kodu";
            this.colDepoKodu.FieldName = "DepoKodu";
            this.colDepoKodu.MinWidth = 25;
            this.colDepoKodu.Name = "colDepoKodu";
            this.colDepoKodu.OptionsColumn.AllowEdit = false;
            this.colDepoKodu.Visible = true;
            this.colDepoKodu.VisibleIndex = 1;
            this.colDepoKodu.Width = 53;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.Caption = "Depo Adı";
            this.colDepoAdi.FieldName = "DepoAdi";
            this.colDepoAdi.MinWidth = 25;
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.OptionsColumn.AllowEdit = false;
            this.colDepoAdi.Visible = true;
            this.colDepoAdi.VisibleIndex = 2;
            this.colDepoAdi.Width = 175;
            // 
            // colSeriNo
            // 
            this.colSeriNo.ColumnEdit = this.repoSeriNo;
            this.colSeriNo.FieldName = "SeriNo";
            this.colSeriNo.MinWidth = 25;
            this.colSeriNo.Name = "colSeriNo";
            this.colSeriNo.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colSeriNo.Visible = true;
            this.colSeriNo.VisibleIndex = 8;
            this.colSeriNo.Width = 83;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.MinWidth = 25;
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 5;
            this.colTarih.Width = 67;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 7;
            this.colAciklama.Width = 198;
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
            this.colSaat.Width = 48;
            // 
            // colIndirimTutar
            // 
            this.colIndirimTutar.Caption = "İnd.Tutar";
            this.colIndirimTutar.DisplayFormat.FormatString = "C2";
            this.colIndirimTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirimTutar.FieldName = "IndirimTutar";
            this.colIndirimTutar.MinWidth = 25;
            this.colIndirimTutar.Name = "colIndirimTutar";
            this.colIndirimTutar.OptionsColumn.AllowEdit = false;
            this.colIndirimTutar.Visible = true;
            this.colIndirimTutar.VisibleIndex = 13;
            this.colIndirimTutar.Width = 61;
            // 
            // colKdvTutar
            // 
            this.colKdvTutar.Caption = "KDV Tutar";
            this.colKdvTutar.DisplayFormat.FormatString = "C2";
            this.colKdvTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKdvTutar.FieldName = "KdvTutar";
            this.colKdvTutar.MinWidth = 25;
            this.colKdvTutar.Name = "colKdvTutar";
            this.colKdvTutar.OptionsColumn.AllowEdit = false;
            this.colKdvTutar.Visible = true;
            this.colKdvTutar.VisibleIndex = 14;
            this.colKdvTutar.Width = 67;
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
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 15;
            this.colToplamTutar.Width = 133;
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
            // 
            // repoSeriNo
            // 
            this.repoSeriNo.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repoSeriNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repoSeriNo.Name = "repoSeriNo";
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContStokHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stokHareketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSeriNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnFormKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnFiltreKapat;
        private DevExpress.XtraEditors.SimpleButton btnFiltrele;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraGrid.GridControl gridContStokHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridStokHareket;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private System.Windows.Forms.BindingSource stokHareketBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colKdvTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraEditors.SimpleButton btnDetayGor;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoSeriNo;
    }
}