namespace SonicHesap.BackOffice.Cari
{
    partial class FrmCari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCari));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliKisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaUnvani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCepTelefonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariGrubu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAltGrubu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzelKod4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiDairesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoOranı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRiskLimiti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisOzelFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisOzelFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlacak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBorc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKopyala = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnFormKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltreKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltrele = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1365, 451);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDurumu,
            this.colCariTuru,
            this.colCariKodu,
            this.colCariAdi,
            this.colYetkiliKisi,
            this.colFaturaUnvani,
            this.colCepTelefonu,
            this.colTelefon,
            this.colFax,
            this.colEMail,
            this.colWeb,
            this.colIl,
            this.colIlce,
            this.colSemt,
            this.colAdres,
            this.colCariGrubu,
            this.colCariAltGrubu,
            this.colOzelKod1,
            this.colOzelKod2,
            this.colOzelKod3,
            this.colOzelKod4,
            this.colVergiDairesi,
            this.colVergiNo,
            this.colIskontoOranı,
            this.colRiskLimiti,
            this.colAlisOzelFiyati,
            this.colSatisOzelFiyati,
            this.colAciklama,
            this.colAlacak,
            this.colBorc,
            this.colBakiye});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.Width = 94;
            // 
            // colDurumu
            // 
            this.colDurumu.Caption = "Durumu";
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.MinWidth = 25;
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 0;
            this.colDurumu.Width = 68;
            // 
            // colCariTuru
            // 
            this.colCariTuru.Caption = "Cari Türü";
            this.colCariTuru.FieldName = "CariTuru";
            this.colCariTuru.MinWidth = 25;
            this.colCariTuru.Name = "colCariTuru";
            this.colCariTuru.Visible = true;
            this.colCariTuru.VisibleIndex = 1;
            this.colCariTuru.Width = 85;
            // 
            // colCariKodu
            // 
            this.colCariKodu.Caption = "Cari Kodu";
            this.colCariKodu.FieldName = "CariKodu";
            this.colCariKodu.MinWidth = 25;
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 2;
            this.colCariKodu.Width = 69;
            // 
            // colCariAdi
            // 
            this.colCariAdi.Caption = "Cari Adı";
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.MinWidth = 25;
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 3;
            this.colCariAdi.Width = 137;
            // 
            // colYetkiliKisi
            // 
            this.colYetkiliKisi.Caption = "Yetkili Kişi";
            this.colYetkiliKisi.FieldName = "YetkiliKisi";
            this.colYetkiliKisi.MinWidth = 25;
            this.colYetkiliKisi.Name = "colYetkiliKisi";
            this.colYetkiliKisi.Visible = true;
            this.colYetkiliKisi.VisibleIndex = 4;
            this.colYetkiliKisi.Width = 137;
            // 
            // colFaturaUnvani
            // 
            this.colFaturaUnvani.Caption = "Fatura Ünvanı";
            this.colFaturaUnvani.FieldName = "FaturaUnvani";
            this.colFaturaUnvani.MinWidth = 25;
            this.colFaturaUnvani.Name = "colFaturaUnvani";
            this.colFaturaUnvani.Visible = true;
            this.colFaturaUnvani.VisibleIndex = 5;
            this.colFaturaUnvani.Width = 137;
            // 
            // colCepTelefonu
            // 
            this.colCepTelefonu.Caption = "Cep Telefonu";
            this.colCepTelefonu.FieldName = "CepTelefonu";
            this.colCepTelefonu.MinWidth = 25;
            this.colCepTelefonu.Name = "colCepTelefonu";
            this.colCepTelefonu.Visible = true;
            this.colCepTelefonu.VisibleIndex = 6;
            this.colCepTelefonu.Width = 137;
            // 
            // colTelefon
            // 
            this.colTelefon.Caption = "Telefon";
            this.colTelefon.FieldName = "Sabit Telefon";
            this.colTelefon.MinWidth = 25;
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.Width = 94;
            // 
            // colFax
            // 
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.MinWidth = 25;
            this.colFax.Name = "colFax";
            this.colFax.Width = 94;
            // 
            // colEMail
            // 
            this.colEMail.Caption = "E-Mail";
            this.colEMail.FieldName = "EMail";
            this.colEMail.MinWidth = 25;
            this.colEMail.Name = "colEMail";
            this.colEMail.Visible = true;
            this.colEMail.VisibleIndex = 7;
            this.colEMail.Width = 157;
            // 
            // colWeb
            // 
            this.colWeb.Caption = "Web";
            this.colWeb.FieldName = "Web";
            this.colWeb.MinWidth = 25;
            this.colWeb.Name = "colWeb";
            this.colWeb.Width = 94;
            // 
            // colIl
            // 
            this.colIl.Caption = "İl";
            this.colIl.FieldName = "Il";
            this.colIl.MinWidth = 25;
            this.colIl.Name = "colIl";
            this.colIl.Width = 94;
            // 
            // colIlce
            // 
            this.colIlce.Caption = "İlçe";
            this.colIlce.FieldName = "Ilce";
            this.colIlce.MinWidth = 25;
            this.colIlce.Name = "colIlce";
            this.colIlce.Width = 94;
            // 
            // colSemt
            // 
            this.colSemt.Caption = "Semt";
            this.colSemt.FieldName = "Semt";
            this.colSemt.MinWidth = 25;
            this.colSemt.Name = "colSemt";
            this.colSemt.Width = 94;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "Adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.MinWidth = 25;
            this.colAdres.Name = "colAdres";
            this.colAdres.Width = 94;
            // 
            // colCariGrubu
            // 
            this.colCariGrubu.Caption = "Cari Grubu";
            this.colCariGrubu.FieldName = "CariGrubu";
            this.colCariGrubu.MinWidth = 25;
            this.colCariGrubu.Name = "colCariGrubu";
            this.colCariGrubu.Width = 94;
            // 
            // colCariAltGrubu
            // 
            this.colCariAltGrubu.Caption = "Cari Alt Grubu";
            this.colCariAltGrubu.FieldName = "CariAltGrubu";
            this.colCariAltGrubu.MinWidth = 25;
            this.colCariAltGrubu.Name = "colCariAltGrubu";
            this.colCariAltGrubu.Width = 94;
            // 
            // colOzelKod1
            // 
            this.colOzelKod1.Caption = "Özel Kod-1";
            this.colOzelKod1.FieldName = "OzelKod1";
            this.colOzelKod1.MinWidth = 25;
            this.colOzelKod1.Name = "colOzelKod1";
            this.colOzelKod1.Width = 94;
            // 
            // colOzelKod2
            // 
            this.colOzelKod2.Caption = "Özel Kod-2";
            this.colOzelKod2.FieldName = "OzelKod2";
            this.colOzelKod2.MinWidth = 25;
            this.colOzelKod2.Name = "colOzelKod2";
            this.colOzelKod2.Width = 94;
            // 
            // colOzelKod3
            // 
            this.colOzelKod3.Caption = "Özel Kod-3";
            this.colOzelKod3.FieldName = "OzelKod3";
            this.colOzelKod3.MinWidth = 25;
            this.colOzelKod3.Name = "colOzelKod3";
            this.colOzelKod3.Width = 94;
            // 
            // colOzelKod4
            // 
            this.colOzelKod4.Caption = "Özel Kod-4";
            this.colOzelKod4.FieldName = "OzelKod4";
            this.colOzelKod4.MinWidth = 25;
            this.colOzelKod4.Name = "colOzelKod4";
            this.colOzelKod4.Width = 94;
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.Caption = "Vergi Dairesi";
            this.colVergiDairesi.FieldName = "VergiDairesi";
            this.colVergiDairesi.MinWidth = 25;
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.Width = 94;
            // 
            // colVergiNo
            // 
            this.colVergiNo.Caption = "Vergi No";
            this.colVergiNo.FieldName = "VergiNo";
            this.colVergiNo.MinWidth = 25;
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.Width = 94;
            // 
            // colIskontoOranı
            // 
            this.colIskontoOranı.Caption = "İskonto Oranı";
            this.colIskontoOranı.DisplayFormat.FormatString = "\'%0\'";
            this.colIskontoOranı.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIskontoOranı.FieldName = "IskontoOranı";
            this.colIskontoOranı.MinWidth = 25;
            this.colIskontoOranı.Name = "colIskontoOranı";
            this.colIskontoOranı.Visible = true;
            this.colIskontoOranı.VisibleIndex = 8;
            this.colIskontoOranı.Width = 67;
            // 
            // colRiskLimiti
            // 
            this.colRiskLimiti.Caption = "Risk Limiti";
            this.colRiskLimiti.DisplayFormat.FormatString = "C2";
            this.colRiskLimiti.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRiskLimiti.FieldName = "RiskLimiti";
            this.colRiskLimiti.MinWidth = 25;
            this.colRiskLimiti.Name = "colRiskLimiti";
            this.colRiskLimiti.Visible = true;
            this.colRiskLimiti.VisibleIndex = 9;
            this.colRiskLimiti.Width = 76;
            // 
            // colAlisOzelFiyati
            // 
            this.colAlisOzelFiyati.Caption = "Alış Özel Fiyatı";
            this.colAlisOzelFiyati.DisplayFormat.FormatString = "C2";
            this.colAlisOzelFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlisOzelFiyati.FieldName = "AlisOzelFiyati";
            this.colAlisOzelFiyati.MinWidth = 25;
            this.colAlisOzelFiyati.Name = "colAlisOzelFiyati";
            this.colAlisOzelFiyati.Width = 94;
            // 
            // colSatisOzelFiyati
            // 
            this.colSatisOzelFiyati.Caption = "Satış Özel Fiyatı";
            this.colSatisOzelFiyati.DisplayFormat.FormatString = "C2";
            this.colSatisOzelFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSatisOzelFiyati.FieldName = "SatisOzelFiyati";
            this.colSatisOzelFiyati.MinWidth = 25;
            this.colSatisOzelFiyati.Name = "colSatisOzelFiyati";
            this.colSatisOzelFiyati.Width = 94;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Width = 265;
            // 
            // colAlacak
            // 
            this.colAlacak.Caption = "Alacak";
            this.colAlacak.DisplayFormat.FormatString = "C2";
            this.colAlacak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlacak.FieldName = "Alacak";
            this.colAlacak.MinWidth = 25;
            this.colAlacak.Name = "colAlacak";
            this.colAlacak.OptionsColumn.AllowEdit = false;
            this.colAlacak.Visible = true;
            this.colAlacak.VisibleIndex = 10;
            this.colAlacak.Width = 94;
            // 
            // colBorc
            // 
            this.colBorc.Caption = "Borç";
            this.colBorc.DisplayFormat.FormatString = "C2";
            this.colBorc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBorc.FieldName = "Borc";
            this.colBorc.MinWidth = 25;
            this.colBorc.Name = "colBorc";
            this.colBorc.OptionsColumn.AllowEdit = false;
            this.colBorc.Visible = true;
            this.colBorc.VisibleIndex = 11;
            this.colBorc.Width = 94;
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
            this.colBakiye.Visible = true;
            this.colBakiye.VisibleIndex = 12;
            this.colBakiye.Width = 94;
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.simpleButton1);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnGuncelle);
            this.grpMenu.Controls.Add(this.btnKopyala);
            this.grpMenu.Controls.Add(this.btnSil);
            this.grpMenu.Controls.Add(this.btnDuzenle);
            this.grpMenu.Controls.Add(this.btnEkle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 660);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1365, 83);
            this.grpMenu.TabIndex = 4;
            this.grpMenu.Text = "Menü";
            // 
            // btnAra
            // 
            this.btnAra.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAra.ImageOptions.ImageIndex = 14;
            this.btnAra.ImageOptions.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(677, 28);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(111, 53);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Cari Bilgi.png");
            this.ımageList1.Images.SetKeyName(1, "Cari Düzenle.png");
            this.ımageList1.Images.SetKeyName(2, "Cari Ekle.png");
            this.ımageList1.Images.SetKeyName(3, "Cari Hareket.png");
            this.ımageList1.Images.SetKeyName(4, "cari kpyala.png");
            this.ımageList1.Images.SetKeyName(5, "Cari Sil.png");
            this.ımageList1.Images.SetKeyName(6, "folder_out.png");
            this.ımageList1.Images.SetKeyName(7, "funnel.png");
            this.ımageList1.Images.SetKeyName(8, "funnel_delete.png");
            this.ımageList1.Images.SetKeyName(9, "information.png");
            this.ımageList1.Images.SetKeyName(10, "redo.png");
            this.ımageList1.Images.SetKeyName(11, "refresh.png");
            this.ımageList1.Images.SetKeyName(12, "replace2.png");
            this.ımageList1.Images.SetKeyName(13, "user.png");
            this.ımageList1.Images.SetKeyName(14, "view.png");
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton1.ImageOptions.ImageIndex = 3;
            this.simpleButton1.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton1.Location = new System.Drawing.Point(557, 28);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(120, 53);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Cari Hareket";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.ImageOptions.ImageIndex = 6;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
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
            this.btnGuncelle.ImageOptions.ImageIndex = 1;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(446, 28);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(111, 53);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKopyala.ImageOptions.ImageIndex = 4;
            this.btnKopyala.ImageOptions.ImageList = this.ımageList1;
            this.btnKopyala.Location = new System.Drawing.Point(335, 28);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(111, 53);
            this.btnKopyala.TabIndex = 0;
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSil.ImageOptions.ImageIndex = 5;
            this.btnSil.ImageOptions.ImageList = this.ımageList1;
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
            this.btnDuzenle.ImageOptions.ImageIndex = 2;
            this.btnDuzenle.ImageOptions.ImageList = this.ımageList1;
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
            this.btnEkle.ImageOptions.ImageIndex = 3;
            this.btnEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(2, 28);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 53);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
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
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Cari Kartları";
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
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1365, 677);
            this.splitContainerControl1.SplitterPosition = 214;
            this.splitContainerControl1.TabIndex = 5;
            // 
            // btnFormKapat
            // 
            this.btnFormKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormKapat.ImageOptions.ImageIndex = 6;
            this.btnFormKapat.ImageOptions.ImageList = this.ımageList1;
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
            this.btnFiltreKapat.ImageOptions.ImageIndex = 8;
            this.btnFiltreKapat.ImageOptions.ImageList = this.ımageList1;
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
            this.btnFiltrele.ImageOptions.ImageIndex = 7;
            this.btnFiltrele.ImageOptions.ImageList = this.ımageList1;
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
            this.filterControl1.SourceControl = this.gridControl1;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // FrmCari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 743);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmCari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Kartları";
            this.Load += new System.EventHandler(this.FrmCari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnKopyala;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraEditors.SimpleButton btnFormKapat;
        private DevExpress.XtraEditors.SimpleButton btnFiltreKapat;
        private DevExpress.XtraEditors.SimpleButton btnFiltrele;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliKisi;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaUnvani;
        private DevExpress.XtraGrid.Columns.GridColumn colCepTelefonu;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEMail;
        private DevExpress.XtraGrid.Columns.GridColumn colWeb;
        private DevExpress.XtraGrid.Columns.GridColumn colIl;
        private DevExpress.XtraGrid.Columns.GridColumn colIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colSemt;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colCariGrubu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAltGrubu;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod1;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod2;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod3;
        private DevExpress.XtraGrid.Columns.GridColumn colOzelKod4;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiDairesi;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoOranı;
        private DevExpress.XtraGrid.Columns.GridColumn colRiskLimiti;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisOzelFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisOzelFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colAlacak;
        private DevExpress.XtraGrid.Columns.GridColumn colBorc;
        private DevExpress.XtraGrid.Columns.GridColumn colBakiye;
    }
}