namespace SonicHesap.Report.Fatura_Ve_Fiş
{
    partial class rptBilgiFisi
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.colStokAdi = new DevExpress.XtraReports.UI.XRTableCell();
            this.colMiktar = new DevExpress.XtraReports.UI.XRTableCell();
            this.colBirimFiyat = new DevExpress.XtraReports.UI.XRTableCell();
            this.colToplamTutar = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblfisKodu = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTarih = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAdres = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCariAdi = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.lblGenelToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.lblKdvToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAraToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.lblKullanici = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 48.68333F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 29.63333F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 80.43333F;
            this.Detail.HierarchyPrintOptions.Indent = 50.8F;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount;
            this.Detail.Name = "Detail";
            this.Detail.StylePriority.UseBorders = false;
            // 
            // xrTable1
            // 
            this.xrTable1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Dpi = 254F;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.58333F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(705F, 48.68333F);
            this.xrTable1.StylePriority.UseBorderDashStyle = false;
            this.xrTable1.StylePriority.UseBorders = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.colStokAdi,
            this.colMiktar,
            this.colBirimFiyat,
            this.colToplamTutar});
            this.xrTableRow1.Dpi = 254F;
            this.xrTableRow1.Font = new DevExpress.Drawing.DXFont("Century Gothic", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.StylePriority.UseBorders = false;
            this.xrTableRow1.StylePriority.UseFont = false;
            this.xrTableRow1.Weight = 1D;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Dpi = 254F;
            this.colStokAdi.Multiline = true;
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.Text = "colStokAdi";
            this.colStokAdi.Weight = 1.3691940072236783D;
            // 
            // colMiktar
            // 
            this.colMiktar.Dpi = 254F;
            this.colMiktar.Multiline = true;
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.Text = "colMiktar";
            this.colMiktar.Weight = 0.73476638429812513D;
            // 
            // colBirimFiyat
            // 
            this.colBirimFiyat.Dpi = 254F;
            this.colBirimFiyat.Multiline = true;
            this.colBirimFiyat.Name = "colBirimFiyat";
            this.colBirimFiyat.Text = "colBirimFiyat";
            this.colBirimFiyat.TextFormatString = "{0:C2}";
            this.colBirimFiyat.Weight = 0.89603960847819664D;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Dpi = 254F;
            this.colToplamTutar.Font = new DevExpress.Drawing.DXFont("Century Gothic", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.colToplamTutar.Multiline = true;
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.StylePriority.UseFont = false;
            this.colToplamTutar.Text = "colToplamTutar";
            this.colToplamTutar.TextFormatString = "{0:C2}";
            this.colToplamTutar.Weight = 1D;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblKullanici,
            this.lblfisKodu,
            this.lblTarih,
            this.lblAdres,
            this.lblCariAdi});
            this.ReportHeader.Dpi = 254F;
            this.ReportHeader.HeightF = 323.85F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.StylePriority.UseBorders = false;
            // 
            // lblfisKodu
            // 
            this.lblfisKodu.Dpi = 254F;
            this.lblfisKodu.Font = new DevExpress.Drawing.DXFont("Century Gothic", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblfisKodu.LocationFloat = new DevExpress.Utils.PointFloat(406.8003F, 116.84F);
            this.lblfisKodu.Multiline = true;
            this.lblfisKodu.Name = "lblfisKodu";
            this.lblfisKodu.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblfisKodu.SizeF = new System.Drawing.SizeF(298.1997F, 58.41998F);
            this.lblfisKodu.StylePriority.UseFont = false;
            this.lblfisKodu.StylePriority.UseTextAlignment = false;
            this.lblfisKodu.Text = "Fiş Kodu";
            this.lblfisKodu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lblTarih
            // 
            this.lblTarih.Dpi = 254F;
            this.lblTarih.Font = new DevExpress.Drawing.DXFont("Century Gothic", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblTarih.LocationFloat = new DevExpress.Utils.PointFloat(0F, 265.43F);
            this.lblTarih.Multiline = true;
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblTarih.SizeF = new System.Drawing.SizeF(705F, 58.42001F);
            this.lblTarih.StylePriority.UseFont = false;
            this.lblTarih.StylePriority.UseTextAlignment = false;
            this.lblTarih.Text = "Fatura Tarihi";
            this.lblTarih.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblAdres
            // 
            this.lblAdres.Dpi = 254F;
            this.lblAdres.Font = new DevExpress.Drawing.DXFont("Century Gothic", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblAdres.LocationFloat = new DevExpress.Utils.PointFloat(3.229777E-05F, 58.42001F);
            this.lblAdres.Multiline = true;
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblAdres.SizeF = new System.Drawing.SizeF(705F, 58.42F);
            this.lblAdres.StylePriority.UseFont = false;
            this.lblAdres.StylePriority.UseTextAlignment = false;
            this.lblAdres.Text = "Adres";
            this.lblAdres.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lblCariAdi
            // 
            this.lblCariAdi.Dpi = 254F;
            this.lblCariAdi.Font = new DevExpress.Drawing.DXFont("Century Gothic", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblCariAdi.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lblCariAdi.Multiline = true;
            this.lblCariAdi.Name = "lblCariAdi";
            this.lblCariAdi.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblCariAdi.SizeF = new System.Drawing.SizeF(705F, 58.42F);
            this.lblCariAdi.StylePriority.UseFont = false;
            this.lblCariAdi.StylePriority.UseTextAlignment = false;
            this.lblCariAdi.Text = "Cari Adı";
            this.lblCariAdi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblGenelToplam,
            this.lblKdvToplam,
            this.lblAraToplam,
            this.xrPageInfo1});
            this.ReportFooter.Dpi = 254F;
            this.ReportFooter.HeightF = 254F;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.StylePriority.UseBorders = false;
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.Dpi = 254F;
            this.lblGenelToplam.LocationFloat = new DevExpress.Utils.PointFloat(298.1997F, 124.8833F);
            this.lblGenelToplam.Multiline = true;
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblGenelToplam.SizeF = new System.Drawing.SizeF(406.8003F, 58.42001F);
            this.lblGenelToplam.StylePriority.UseTextAlignment = false;
            this.lblGenelToplam.Text = "Fatura Tarihi";
            this.lblGenelToplam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblKdvToplam
            // 
            this.lblKdvToplam.Dpi = 254F;
            this.lblKdvToplam.LocationFloat = new DevExpress.Utils.PointFloat(298.1997F, 63.5F);
            this.lblKdvToplam.Multiline = true;
            this.lblKdvToplam.Name = "lblKdvToplam";
            this.lblKdvToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblKdvToplam.SizeF = new System.Drawing.SizeF(406.8003F, 58.42001F);
            this.lblKdvToplam.StylePriority.UseTextAlignment = false;
            this.lblKdvToplam.Text = "Fatura Tarihi";
            this.lblKdvToplam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblAraToplam
            // 
            this.lblAraToplam.Dpi = 254F;
            this.lblAraToplam.LocationFloat = new DevExpress.Utils.PointFloat(298.1997F, 0F);
            this.lblAraToplam.Multiline = true;
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblAraToplam.SizeF = new System.Drawing.SizeF(406.8003F, 58.42001F);
            this.lblAraToplam.StylePriority.UseTextAlignment = false;
            this.lblAraToplam.Text = "Fatura Tarihi";
            this.lblAraToplam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Dpi = 254F;
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(451F, 195.58F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            // 
            // lblKullanici
            // 
            this.lblKullanici.Dpi = 254F;
            this.lblKullanici.Font = new DevExpress.Drawing.DXFont("Century Gothic", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblKullanici.LocationFloat = new DevExpress.Utils.PointFloat(0F, 207.01F);
            this.lblKullanici.Multiline = true;
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblKullanici.SizeF = new System.Drawing.SizeF(370.823F, 58.42001F);
            this.lblKullanici.StylePriority.UseFont = false;
            this.lblKullanici.StylePriority.UseTextAlignment = false;
            this.lblKullanici.Text = "Kullanıcı bilgi";
            this.lblKullanici.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // rptBilgiFisi
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.ReportFooter});
            this.Dpi = 254F;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(61F, 34F, 48.68333F, 29.63333F);
            this.PageHeight = 2794;
            this.PageWidth = 800;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.RollPaper = true;
            this.SnapGridSize = 25F;
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lblCariAdi;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel lblAdres;
        private DevExpress.XtraReports.UI.XRLabel lblTarih;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell colStokAdi;
        private DevExpress.XtraReports.UI.XRTableCell colMiktar;
        private DevExpress.XtraReports.UI.XRTableCell colBirimFiyat;
        private DevExpress.XtraReports.UI.XRTableCell colToplamTutar;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRLabel lblGenelToplam;
        private DevExpress.XtraReports.UI.XRLabel lblKdvToplam;
        private DevExpress.XtraReports.UI.XRLabel lblAraToplam;
        private DevExpress.XtraReports.UI.XRLabel lblfisKodu;
        private DevExpress.XtraReports.UI.XRLabel lblKullanici;
    }
}
