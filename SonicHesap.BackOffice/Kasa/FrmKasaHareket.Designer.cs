namespace SonicHesap.BackOffice.Kasa
{
    partial class FrmKasaHareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasaHareket));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridContKasaHareket = new DevExpress.XtraGrid.GridControl();
            this.kasaHareketBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridContOdemeTuruToplam = new DevExpress.XtraGrid.GridControl();
            this.gridOdemeTuruToplam = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOdemeTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridContGenelToplam = new DevExpress.XtraGrid.GridControl();
            this.gridGenelToplam = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContKasaHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaHareketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).BeginInit();
            this.splitContainerControl2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).BeginInit();
            this.splitContainerControl2.Panel2.SuspendLayout();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContOdemeTuruToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeTuruToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContGenelToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGenelToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
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
            this.splitContainerControl1.Panel1.Controls.Add(this.gridContKasaHareket);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1327, 605);
            this.splitContainerControl1.SplitterPosition = 352;
            this.splitContainerControl1.TabIndex = 9;
            // 
            // gridContKasaHareket
            // 
            this.gridContKasaHareket.DataSource = this.kasaHareketBindingSource;
            this.gridContKasaHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContKasaHareket.Location = new System.Drawing.Point(0, 0);
            this.gridContKasaHareket.MainView = this.gridKasaHareket;
            this.gridContKasaHareket.Name = "gridContKasaHareket";
            this.gridContKasaHareket.Size = new System.Drawing.Size(1327, 352);
            this.gridContKasaHareket.TabIndex = 1;
            this.gridContKasaHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKasaHareket});
            // 
            // kasaHareketBindingSource
            // 
            this.kasaHareketBindingSource.DataSource = typeof(SonicHesap.Entities.Tables.KasaHareket);
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
            this.colKasaKodu.Width = 108;
            // 
            // colKasaAdi
            // 
            this.colKasaAdi.FieldName = "KasaAdi";
            this.colKasaAdi.MinWidth = 25;
            this.colKasaAdi.Name = "colKasaAdi";
            this.colKasaAdi.OptionsColumn.AllowEdit = false;
            this.colKasaAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colKasaAdi.Width = 108;
            // 
            // colOdemeTuruKodu
            // 
            this.colOdemeTuruKodu.FieldName = "OdemeTuruKodu";
            this.colOdemeTuruKodu.MinWidth = 25;
            this.colOdemeTuruKodu.Name = "colOdemeTuruKodu";
            this.colOdemeTuruKodu.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruKodu.OptionsColumn.ShowInCustomizationForm = false;
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
            this.colOdemeTuruAdi.VisibleIndex = 2;
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
            this.colCariKodu.VisibleIndex = 3;
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
            this.colCariAdi.VisibleIndex = 4;
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
            this.colTarih.VisibleIndex = 5;
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
            this.colSaat.Visible = true;
            this.colSaat.VisibleIndex = 6;
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
            this.colTutar.VisibleIndex = 8;
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
            this.colAciklama.VisibleIndex = 7;
            this.colAciklama.Width = 331;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            // 
            // splitContainerControl2.Panel1
            // 
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // splitContainerControl2.Panel2
            // 
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1327, 241);
            this.splitContainerControl2.SplitterPosition = 792;
            this.splitContainerControl2.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridContOdemeTuruToplam);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(792, 241);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Ödeme Türlerine Göre Toplamlar";
            // 
            // gridContOdemeTuruToplam
            // 
            this.gridContOdemeTuruToplam.DataSource = this.kasaHareketBindingSource;
            this.gridContOdemeTuruToplam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContOdemeTuruToplam.Location = new System.Drawing.Point(2, 28);
            this.gridContOdemeTuruToplam.MainView = this.gridOdemeTuruToplam;
            this.gridContOdemeTuruToplam.Name = "gridContOdemeTuruToplam";
            this.gridContOdemeTuruToplam.Size = new System.Drawing.Size(788, 211);
            this.gridContOdemeTuruToplam.TabIndex = 4;
            this.gridContOdemeTuruToplam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridOdemeTuruToplam});
            // 
            // gridOdemeTuruToplam
            // 
            this.gridOdemeTuruToplam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOdemeTuru,
            this.colKasaGiris,
            this.colKasaCikis,
            this.colBakiye});
            this.gridOdemeTuruToplam.GridControl = this.gridContOdemeTuruToplam;
            this.gridOdemeTuruToplam.Name = "gridOdemeTuruToplam";
            this.gridOdemeTuruToplam.OptionsView.ShowGroupPanel = false;
            // 
            // colOdemeTuru
            // 
            this.colOdemeTuru.Caption = "Ödeme Türü";
            this.colOdemeTuru.FieldName = "OdemeTuruAdi";
            this.colOdemeTuru.MinWidth = 25;
            this.colOdemeTuru.Name = "colOdemeTuru";
            this.colOdemeTuru.OptionsColumn.AllowEdit = false;
            this.colOdemeTuru.Visible = true;
            this.colOdemeTuru.VisibleIndex = 0;
            this.colOdemeTuru.Width = 349;
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
            this.colKasaGiris.Visible = true;
            this.colKasaGiris.VisibleIndex = 1;
            this.colKasaGiris.Width = 110;
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
            this.colKasaCikis.Visible = true;
            this.colKasaCikis.VisibleIndex = 2;
            this.colKasaCikis.Width = 168;
            // 
            // colBakiye
            // 
            this.colBakiye.Caption = "Bakiye";
            this.colBakiye.DisplayFormat.FormatString = "C2";
            this.colBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBakiye.FieldName = "Bakiye";
            this.colBakiye.MinWidth = 25;
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.Visible = true;
            this.colBakiye.VisibleIndex = 3;
            this.colBakiye.Width = 94;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridContGenelToplam);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(523, 241);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Genel Toplamlar";
            // 
            // gridContGenelToplam
            // 
            this.gridContGenelToplam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContGenelToplam.Location = new System.Drawing.Point(2, 28);
            this.gridContGenelToplam.MainView = this.gridGenelToplam;
            this.gridContGenelToplam.Name = "gridContGenelToplam";
            this.gridContGenelToplam.Size = new System.Drawing.Size(519, 211);
            this.gridContGenelToplam.TabIndex = 3;
            this.gridContGenelToplam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridGenelToplam});
            // 
            // gridGenelToplam
            // 
            this.gridGenelToplam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridGenelToplam.GridControl = this.gridContGenelToplam;
            this.gridGenelToplam.Name = "gridGenelToplam";
            this.gridGenelToplam.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Bilgi";
            this.gridColumn1.FieldName = "Bilgi";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 349;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Kayıt Sayısı";
            this.gridColumn2.FieldName = "KayitSayisi";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 110;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Toplam Tutar";
            this.gridColumn3.DisplayFormat.FormatString = "C2";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "Tutar";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 168;
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.btnGuncelle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 671);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1327, 83);
            this.grpMenu.TabIndex = 8;
            this.grpMenu.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Appearance.Options.UseFont = true;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(1231, 28);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(94, 53);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "refresh.png");
            this.ımageList1.Images.SetKeyName(2, "view.png");
            // 
            // btnAra
            // 
            this.btnAra.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Appearance.Options.UseFont = true;
            this.btnAra.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAra.ImageOptions.ImageIndex = 2;
            this.btnAra.ImageOptions.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(113, 28);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(111, 53);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
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
            this.lblBaslik.Size = new System.Drawing.Size(1327, 66);
            this.lblBaslik.TabIndex = 7;
            this.lblBaslik.Text = "Kasa Hareketleri";
            // 
            // FrmKasaHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 754);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmKasaHareket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Hareketleri";
            this.Load += new System.EventHandler(this.FrmKasaHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContKasaHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaHareketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).EndInit();
            this.splitContainerControl2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).EndInit();
            this.splitContainerControl2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContOdemeTuruToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeTuruToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContGenelToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGenelToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridContKasaHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKasaHareket;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private System.Windows.Forms.BindingSource kasaHareketBindingSource;
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
        private DevExpress.XtraGrid.GridControl gridContGenelToplam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridGenelToplam;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.GridControl gridContOdemeTuruToplam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridOdemeTuruToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaGiris;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colBakiye;
    }
}