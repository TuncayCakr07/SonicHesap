namespace SonicHesap.BackOffice.HizliSatis
{
    partial class FrmHizliSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHizliSatis));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridContGrupEkle = new DevExpress.XtraGrid.GridControl();
            this.gridGrupEkle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpGrupMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.grpBilgi = new DevExpress.XtraEditors.GroupControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txtGrupAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.gridContUrunEkle = new DevExpress.XtraGrid.GridControl();
            this.gridUrunEkle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpUrunMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnUrunSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnUrunEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnFormKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContGrupEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGrupEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrupMenu)).BeginInit();
            this.grpGrupMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpBilgi)).BeginInit();
            this.grpBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContUrunEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUrunMenu)).BeginInit();
            this.grpUrunMenu.SuspendLayout();
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
            this.lblBaslik.Size = new System.Drawing.Size(1240, 66);
            this.lblBaslik.TabIndex = 8;
            this.lblBaslik.Text = "Hızlı Satış İşlemleri";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 66);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.gridContGrupEkle);
            this.splitContainerControl1.Panel1.Controls.Add(this.grpGrupMenu);
            this.splitContainerControl1.Panel1.Controls.Add(this.grpBilgi);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gridContUrunEkle);
            this.splitContainerControl1.Panel2.Controls.Add(this.grpUrunMenu);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1240, 632);
            this.splitContainerControl1.SplitterPosition = 636;
            this.splitContainerControl1.TabIndex = 9;
            // 
            // gridContGrupEkle
            // 
            this.gridContGrupEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContGrupEkle.Location = new System.Drawing.Point(0, 135);
            this.gridContGrupEkle.MainView = this.gridGrupEkle;
            this.gridContGrupEkle.Name = "gridContGrupEkle";
            this.gridContGrupEkle.Size = new System.Drawing.Size(636, 408);
            this.gridContGrupEkle.TabIndex = 10;
            this.gridContGrupEkle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridGrupEkle});
            // 
            // gridGrupEkle
            // 
            this.gridGrupEkle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colGrupAdi,
            this.colAciklama});
            this.gridGrupEkle.GridControl = this.gridContGrupEkle;
            this.gridGrupEkle.Name = "gridGrupEkle";
            this.gridGrupEkle.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridGrupEkle_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 2;
            this.colId.Width = 94;
            // 
            // colGrupAdi
            // 
            this.colGrupAdi.FieldName = "GrupAdi";
            this.colGrupAdi.MinWidth = 25;
            this.colGrupAdi.Name = "colGrupAdi";
            this.colGrupAdi.Visible = true;
            this.colGrupAdi.VisibleIndex = 0;
            this.colGrupAdi.Width = 94;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 1;
            this.colAciklama.Width = 94;
            // 
            // grpGrupMenu
            // 
            this.grpGrupMenu.Controls.Add(this.btnSil);
            this.grpGrupMenu.Controls.Add(this.btnYeni);
            this.grpGrupMenu.Controls.Add(this.btnKaydet);
            this.grpGrupMenu.Controls.Add(this.btnVazgec);
            this.grpGrupMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpGrupMenu.Location = new System.Drawing.Point(0, 543);
            this.grpGrupMenu.Name = "grpGrupMenu";
            this.grpGrupMenu.Size = new System.Drawing.Size(636, 89);
            this.grpGrupMenu.TabIndex = 9;
            this.grpGrupMenu.Text = "Menü";
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSil.ImageOptions.ImageIndex = 3;
            this.btnSil.ImageOptions.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(106, 28);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(104, 59);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            this.ımageList1.Images.SetKeyName(2, "add.png");
            this.ımageList1.Images.SetKeyName(3, "delete.png");
            this.ımageList1.Images.SetKeyName(4, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(5, "floppy_disk_delete.png");
            // 
            // btnYeni
            // 
            this.btnYeni.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Appearance.Options.UseFont = true;
            this.btnYeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnYeni.ImageOptions.ImageIndex = 2;
            this.btnYeni.ImageOptions.ImageList = this.ımageList1;
            this.btnYeni.Location = new System.Drawing.Point(2, 28);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(104, 59);
            this.btnYeni.TabIndex = 2;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.ImageOptions.ImageIndex = 0;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(424, 28);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(104, 59);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgec.Appearance.Options.UseFont = true;
            this.btnVazgec.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVazgec.Enabled = false;
            this.btnVazgec.ImageOptions.ImageIndex = 5;
            this.btnVazgec.ImageOptions.ImageList = this.ımageList1;
            this.btnVazgec.Location = new System.Drawing.Point(528, 28);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(106, 59);
            this.btnVazgec.TabIndex = 0;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // grpBilgi
            // 
            this.grpBilgi.Controls.Add(this.txtAciklama);
            this.grpBilgi.Controls.Add(this.txtGrupAdi);
            this.grpBilgi.Controls.Add(this.labelControl8);
            this.grpBilgi.Controls.Add(this.labelControl11);
            this.grpBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBilgi.Location = new System.Drawing.Point(0, 0);
            this.grpBilgi.Name = "grpBilgi";
            this.grpBilgi.Size = new System.Drawing.Size(636, 135);
            this.grpBilgi.TabIndex = 0;
            this.grpBilgi.Text = "Grup Bilgileri";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Enabled = false;
            this.txtAciklama.Location = new System.Drawing.Point(117, 64);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(519, 60);
            this.txtAciklama.TabIndex = 9;
            // 
            // txtGrupAdi
            // 
            this.txtGrupAdi.Enabled = false;
            this.txtGrupAdi.Location = new System.Drawing.Point(117, 34);
            this.txtGrupAdi.Name = "txtGrupAdi";
            this.txtGrupAdi.Size = new System.Drawing.Size(519, 22);
            this.txtGrupAdi.TabIndex = 8;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl8.Location = new System.Drawing.Point(6, 31);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(105, 24);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Grup Adı :";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Options.UseTextOptions = true;
            this.labelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl11.Location = new System.Drawing.Point(6, 64);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(105, 57);
            this.labelControl11.TabIndex = 7;
            this.labelControl11.Text = "Açıklama :";
            // 
            // gridContUrunEkle
            // 
            this.gridContUrunEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContUrunEkle.Location = new System.Drawing.Point(0, 0);
            this.gridContUrunEkle.MainView = this.gridUrunEkle;
            this.gridContUrunEkle.Name = "gridContUrunEkle";
            this.gridContUrunEkle.Size = new System.Drawing.Size(592, 543);
            this.gridContUrunEkle.TabIndex = 11;
            this.gridContUrunEkle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUrunEkle});
            // 
            // gridUrunEkle
            // 
            this.gridUrunEkle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridUrunEkle.GridControl = this.gridContUrunEkle;
            this.gridUrunEkle.Name = "gridUrunEkle";
            this.gridUrunEkle.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "UrunAdi";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "Aciklama";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 94;
            // 
            // grpUrunMenu
            // 
            this.grpUrunMenu.Controls.Add(this.btnUrunSil);
            this.grpUrunMenu.Controls.Add(this.btnUrunEkle);
            this.grpUrunMenu.Controls.Add(this.btnFormKapat);
            this.grpUrunMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpUrunMenu.Location = new System.Drawing.Point(0, 543);
            this.grpUrunMenu.Name = "grpUrunMenu";
            this.grpUrunMenu.Size = new System.Drawing.Size(592, 89);
            this.grpUrunMenu.TabIndex = 10;
            this.grpUrunMenu.Text = "Menü";
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSil.Appearance.Options.UseFont = true;
            this.btnUrunSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUrunSil.ImageOptions.ImageIndex = 3;
            this.btnUrunSil.ImageOptions.ImageList = this.ımageList1;
            this.btnUrunSil.Location = new System.Drawing.Point(106, 28);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(104, 59);
            this.btnUrunSil.TabIndex = 3;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.Appearance.Options.UseFont = true;
            this.btnUrunEkle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUrunEkle.ImageOptions.ImageIndex = 2;
            this.btnUrunEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnUrunEkle.Location = new System.Drawing.Point(2, 28);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(104, 59);
            this.btnUrunEkle.TabIndex = 2;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnFormKapat
            // 
            this.btnFormKapat.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFormKapat.Appearance.Options.UseFont = true;
            this.btnFormKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFormKapat.ImageOptions.ImageIndex = 1;
            this.btnFormKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnFormKapat.Location = new System.Drawing.Point(484, 28);
            this.btnFormKapat.Name = "btnFormKapat";
            this.btnFormKapat.Size = new System.Drawing.Size(106, 59);
            this.btnFormKapat.TabIndex = 0;
            this.btnFormKapat.Text = "Kapat";
            this.btnFormKapat.Click += new System.EventHandler(this.btnFormKapat_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "add.png");
            this.ımageList2.Images.SetKeyName(1, "delete.png");
            // 
            // FrmHizliSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 698);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmHizliSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hızlı Satış İşlemleri Menüsü";
            this.Load += new System.EventHandler(this.FrmHizliSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContGrupEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGrupEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrupMenu)).EndInit();
            this.grpGrupMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpBilgi)).EndInit();
            this.grpBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContUrunEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUrunMenu)).EndInit();
            this.grpUrunMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl grpBilgi;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.TextEdit txtGrupAdi;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.GroupControl grpGrupMenu;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private DevExpress.XtraGrid.GridControl gridContGrupEkle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridGrupEkle;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.GridControl gridContUrunEkle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUrunEkle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.GroupControl grpUrunMenu;
        private DevExpress.XtraEditors.SimpleButton btnUrunSil;
        private DevExpress.XtraEditors.SimpleButton btnUrunEkle;
        private DevExpress.XtraEditors.SimpleButton btnFormKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
    }
}