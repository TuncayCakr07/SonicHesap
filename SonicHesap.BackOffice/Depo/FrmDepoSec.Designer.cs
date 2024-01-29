namespace SonicHesap.BackOffice.Depo
{
    partial class FrmDepoSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepoSec));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiliKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDepolar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridContDepolar = new DevExpress.XtraGrid.GridControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.colStokGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMevcutStok = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContDepolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
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
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "Depo Seçim Ekranı";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.png");
            this.ımageList1.Images.SetKeyName(1, "bilgi.png");
            this.ımageList1.Images.SetKeyName(2, "delete.png");
            this.ımageList1.Images.SetKeyName(3, "düzenle.png");
            this.ımageList1.Images.SetKeyName(4, "ekle.png");
            this.ımageList1.Images.SetKeyName(5, "factory.png");
            this.ımageList1.Images.SetKeyName(6, "folder_out.png");
            this.ımageList1.Images.SetKeyName(7, "funnel.png");
            this.ımageList1.Images.SetKeyName(8, "funnel_delete.png");
            this.ımageList1.Images.SetKeyName(9, "hareket.png");
            this.ımageList1.Images.SetKeyName(10, "information.png");
            this.ımageList1.Images.SetKeyName(11, "pencil.png");
            this.ımageList1.Images.SetKeyName(12, "refresh.png");
            this.ımageList1.Images.SetKeyName(13, "replace2.png");
            this.ımageList1.Images.SetKeyName(14, "sil.png");
            this.ımageList1.Images.SetKeyName(15, "view.png");
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
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnSec);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 660);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1365, 83);
            this.grpMenu.TabIndex = 7;
            this.grpMenu.Text = "Menü";
            // 
            // btnSec
            // 
            this.btnSec.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSec.Appearance.Options.UseFont = true;
            this.btnSec.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSec.ImageOptions.Image")));
            this.btnSec.ImageOptions.ImageIndex = 0;
            this.btnSec.ImageOptions.ImageList = this.ımageList1;
            this.btnSec.Location = new System.Drawing.Point(1175, 28);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(94, 53);
            this.btnSec.TabIndex = 2;
            this.btnSec.Text = "Seç";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 9;
            this.colAciklama.Width = 153;
            // 
            // colTelefon
            // 
            this.colTelefon.Caption = "Telefon";
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.MinWidth = 25;
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.OptionsColumn.AllowEdit = false;
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 4;
            this.colTelefon.Width = 130;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "Adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.MinWidth = 25;
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 8;
            this.colAdres.Width = 129;
            // 
            // colSemt
            // 
            this.colSemt.Caption = "Semt";
            this.colSemt.FieldName = "Semt";
            this.colSemt.MinWidth = 25;
            this.colSemt.Name = "colSemt";
            this.colSemt.OptionsColumn.AllowEdit = false;
            this.colSemt.Visible = true;
            this.colSemt.VisibleIndex = 7;
            this.colSemt.Width = 131;
            // 
            // colIlce
            // 
            this.colIlce.Caption = "İlçe";
            this.colIlce.FieldName = "Ilce";
            this.colIlce.MinWidth = 25;
            this.colIlce.Name = "colIlce";
            this.colIlce.OptionsColumn.AllowEdit = false;
            this.colIlce.Visible = true;
            this.colIlce.VisibleIndex = 6;
            this.colIlce.Width = 130;
            // 
            // colIl
            // 
            this.colIl.Caption = "İl";
            this.colIl.FieldName = "Il";
            this.colIl.MinWidth = 25;
            this.colIl.Name = "colIl";
            this.colIl.OptionsColumn.AllowEdit = false;
            this.colIl.Visible = true;
            this.colIl.VisibleIndex = 5;
            this.colIl.Width = 130;
            // 
            // colYetkiliAdi
            // 
            this.colYetkiliAdi.Caption = "Yetkili Adi";
            this.colYetkiliAdi.FieldName = "YetkiliAdi";
            this.colYetkiliAdi.MinWidth = 25;
            this.colYetkiliAdi.Name = "colYetkiliAdi";
            this.colYetkiliAdi.OptionsColumn.AllowEdit = false;
            this.colYetkiliAdi.Visible = true;
            this.colYetkiliAdi.VisibleIndex = 3;
            this.colYetkiliAdi.Width = 177;
            // 
            // colYetkiliKodu
            // 
            this.colYetkiliKodu.Caption = "Yetkili Kodu";
            this.colYetkiliKodu.FieldName = "YetkiliKodu";
            this.colYetkiliKodu.MinWidth = 25;
            this.colYetkiliKodu.Name = "colYetkiliKodu";
            this.colYetkiliKodu.OptionsColumn.AllowEdit = false;
            this.colYetkiliKodu.Visible = true;
            this.colYetkiliKodu.VisibleIndex = 2;
            this.colYetkiliKodu.Width = 73;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.Caption = "Depo Adı";
            this.colDepoAdi.FieldName = "DepoAdi";
            this.colDepoAdi.MinWidth = 25;
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.OptionsColumn.AllowEdit = false;
            this.colDepoAdi.Visible = true;
            this.colDepoAdi.VisibleIndex = 1;
            this.colDepoAdi.Width = 210;
            // 
            // colDepoKodu
            // 
            this.colDepoKodu.Caption = "Depo Kodu";
            this.colDepoKodu.FieldName = "DepoKodu";
            this.colDepoKodu.MinWidth = 25;
            this.colDepoKodu.Name = "colDepoKodu";
            this.colDepoKodu.OptionsColumn.AllowEdit = false;
            this.colDepoKodu.Visible = true;
            this.colDepoKodu.VisibleIndex = 0;
            this.colDepoKodu.Width = 72;
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
            // gridDepolar
            // 
            this.gridDepolar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDepoKodu,
            this.colDepoAdi,
            this.colYetkiliKodu,
            this.colYetkiliAdi,
            this.colIl,
            this.colIlce,
            this.colSemt,
            this.colAdres,
            this.colTelefon,
            this.colAciklama,
            this.colStokGiris,
            this.colStokCikis,
            this.colMevcutStok});
            this.gridDepolar.GridControl = this.gridContDepolar;
            this.gridDepolar.Name = "gridDepolar";
            // 
            // gridContDepolar
            // 
            this.gridContDepolar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContDepolar.Location = new System.Drawing.Point(0, 0);
            this.gridContDepolar.MainView = this.gridDepolar;
            this.gridContDepolar.Name = "gridContDepolar";
            this.gridContDepolar.Size = new System.Drawing.Size(1365, 684);
            this.gridContDepolar.TabIndex = 0;
            this.gridContDepolar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDepolar});
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
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContDepolar);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1365, 743);
            this.splitContainerControl1.SplitterPosition = 47;
            this.splitContainerControl1.TabIndex = 8;
            // 
            // colStokGiris
            // 
            this.colStokGiris.Caption = "Stok Giriş";
            this.colStokGiris.FieldName = "StokGiris";
            this.colStokGiris.MinWidth = 25;
            this.colStokGiris.Name = "colStokGiris";
            this.colStokGiris.Visible = true;
            this.colStokGiris.VisibleIndex = 10;
            this.colStokGiris.Width = 94;
            // 
            // colStokCikis
            // 
            this.colStokCikis.Caption = "Stok Çıkış";
            this.colStokCikis.FieldName = "StokCikis";
            this.colStokCikis.MinWidth = 25;
            this.colStokCikis.Name = "colStokCikis";
            this.colStokCikis.Visible = true;
            this.colStokCikis.VisibleIndex = 11;
            this.colStokCikis.Width = 94;
            // 
            // colMevcutStok
            // 
            this.colMevcutStok.Caption = "Mevcut Stok";
            this.colMevcutStok.FieldName = "MevcutStok";
            this.colMevcutStok.MinWidth = 25;
            this.colMevcutStok.Name = "colMevcutStok";
            this.colMevcutStok.Visible = true;
            this.colMevcutStok.VisibleIndex = 12;
            this.colMevcutStok.Width = 94;
            // 
            // FrmDepoSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 743);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmDepoSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depo Seçim Ekranı";
            this.Load += new System.EventHandler(this.FrmDepoSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDepolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContDepolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colSemt;
        private DevExpress.XtraGrid.Columns.GridColumn colIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colIl;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiliKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDepolar;
        private DevExpress.XtraGrid.GridControl gridContDepolar;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraGrid.Columns.GridColumn colStokGiris;
        private DevExpress.XtraGrid.Columns.GridColumn colStokCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colMevcutStok;
    }
}