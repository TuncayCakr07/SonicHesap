namespace SonicHesap.BackOffice
{
    partial class FrmAnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaMenu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCari = new DevExpress.XtraBars.BarButtonItem();
            this.btnKasa = new DevExpress.XtraBars.BarButtonItem();
            this.btnDepo = new DevExpress.XtraBars.BarButtonItem();
            this.btnOdemeTuru = new DevExpress.XtraBars.BarButtonItem();
            this.btnTanim = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.btnFis = new DevExpress.XtraBars.BarButtonItem();
            this.btnFisIslem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.btnCari,
            this.btnKasa,
            this.btnDepo,
            this.btnOdemeTuru,
            this.btnTanim,
            this.btnFis,
            this.btnFisIslem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1189, 193);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Stok";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnCari
            // 
            this.btnCari.Caption = "Cari";
            this.btnCari.Id = 2;
            this.btnCari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCari.ImageOptions.LargeImage")));
            this.btnCari.Name = "btnCari";
            this.btnCari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCari_ItemClick);
            // 
            // btnKasa
            // 
            this.btnKasa.Caption = "Kasa";
            this.btnKasa.Id = 3;
            this.btnKasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKasa.ImageOptions.Image")));
            this.btnKasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKasa.ImageOptions.LargeImage")));
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKasa_ItemClick);
            // 
            // btnDepo
            // 
            this.btnDepo.Caption = "Depo";
            this.btnDepo.Id = 4;
            this.btnDepo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDepo.ImageOptions.LargeImage")));
            this.btnDepo.Name = "btnDepo";
            this.btnDepo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDepo_ItemClick);
            // 
            // btnOdemeTuru
            // 
            this.btnOdemeTuru.Caption = "Ödeme Türleri";
            this.btnOdemeTuru.Id = 5;
            this.btnOdemeTuru.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOdemeTuru.ImageOptions.LargeImage")));
            this.btnOdemeTuru.Name = "btnOdemeTuru";
            this.btnOdemeTuru.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOdemeTuru_ItemClick);
            // 
            // btnTanim
            // 
            this.btnTanim.Caption = "Tanımlar";
            this.btnTanim.Id = 6;
            this.btnTanim.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTanim.ImageOptions.LargeImage")));
            this.btnTanim.Name = "btnTanim";
            this.btnTanim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTanim_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCari);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKasa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDepo);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnOdemeTuru);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFis);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFisIslem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // btnFis
            // 
            this.btnFis.Caption = "Fişler";
            this.btnFis.Id = 7;
            this.btnFis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.btnFis.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.btnFis.Name = "btnFis";
            this.btnFis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFis_ItemClick);
            // 
            // btnFisIslem
            // 
            this.btnFisIslem.Caption = "Fiş İşlemleri";
            this.btnFisIslem.Id = 8;
            this.btnFisIslem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFisIslem.ImageOptions.LargeImage")));
            this.btnFisIslem.Name = "btnFisIslem";
            this.btnFisIslem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFisIslem_ItemClick);
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 684);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAnaMenu";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnCari;
        private DevExpress.XtraBars.BarButtonItem btnKasa;
        private DevExpress.XtraBars.BarButtonItem btnDepo;
        private DevExpress.XtraBars.BarButtonItem btnOdemeTuru;
        private DevExpress.XtraBars.BarButtonItem btnTanim;
        private DevExpress.XtraBars.BarButtonItem btnFis;
        private DevExpress.XtraBars.BarButtonItem btnFisIslem;
    }
}

