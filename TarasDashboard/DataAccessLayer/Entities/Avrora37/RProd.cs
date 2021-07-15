using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProd
    {
        public RProd()
        {
            TOrderMonitorsTemps = new HashSet<TOrderMonitorsTemp>();
        }

        public long ChId { get; set; }
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public string Um { get; set; }
        public string Country { get; set; }
        public string Notes { get; set; }
        public int PcatId { get; set; }
        public int PgrId { get; set; }
        public string Article1 { get; set; }
        public string Article2 { get; set; }
        public string Article3 { get; set; }
        public decimal? Weight { get; set; }
        public bool PriceWithTax { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }
        public decimal MinPriceMc { get; set; }
        public decimal MaxPriceMc { get; set; }
        public decimal MinRem { get; set; }
        public decimal CstDty { get; set; }
        public decimal CstPrc { get; set; }
        public decimal CstExc { get; set; }
        public string StdExtraR { get; set; }
        public string StdExtraE { get; set; }
        public decimal MaxExtra { get; set; }
        public bool UseAlts { get; set; }
        public bool UseCrts { get; set; }
        public int PgrId1 { get; set; }
        public int PgrId2 { get; set; }
        public int PgrId3 { get; set; }
        public short PgrAid { get; set; }
        public short PbgrId { get; set; }
        public string LexpSet { get; set; }
        public string EexpSet { get; set; }
        public bool InRems { get; set; }
        public bool IsDecQty { get; set; }
        public string File1 { get; set; }
        public string File2 { get; set; }
        public string File3 { get; set; }
        public bool AutoSet { get; set; }
        public decimal Extra1 { get; set; }
        public decimal Extra2 { get; set; }
        public decimal Extra3 { get; set; }
        public decimal Extra4 { get; set; }
        public decimal Extra5 { get; set; }
        public decimal Norma1 { get; set; }
        public decimal Norma2 { get; set; }
        public decimal Norma3 { get; set; }
        public decimal Norma4 { get; set; }
        public decimal Norma5 { get; set; }
        public decimal MinExtra { get; set; }
        public decimal RecMinPriceCc { get; set; }
        public decimal RecMaxPriceCc { get; set; }
        public decimal RecStdPriceCc { get; set; }
        public decimal RecRemQty { get; set; }
        public bool InStopList { get; set; }
        public decimal? Age { get; set; }
        public int? PrepareTime { get; set; }
        public int PgrId6 { get; set; }
        public int ExciseGrId { get; set; }
        public int ScaleGrId { get; set; }
        public string ScaleStandard { get; set; }
        public string ScaleConditions { get; set; }
        public string ScaleComponents { get; set; }
        public string TaxFreeReason { get; set; }
        public string CstProdCode { get; set; }
        public int CompId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Materials { get; set; }
        public string Warnings { get; set; }
        public string Regulations { get; set; }
        public string Producer { get; set; }
        public string ProdAddress { get; set; }
        public string Importer { get; set; }
        public string ImpAddress { get; set; }
        public DateTime? ProdPpdate { get; set; }
        public int Status { get; set; }
        public int TaxTypeId { get; set; }
        public decimal CstDty2 { get; set; }
        public decimal? Capacity { get; set; }
        public string Article4 { get; set; }
        public string Notemenager { get; set; }
        public int RecCatId { get; set; }
        public int? ColCatId { get; set; }
        public bool? Otm { get; set; }
        public bool AmPos { get; set; }
        public short CounId { get; set; }
        public bool? PrintSticker { get; set; }
        public short? TypeTreatment { get; set; }
        public short? Mplicity { get; set; }
        public bool? SoftMultiplicity { get; set; }
        public int? Pcatsubgroupid { get; set; }
        public int? PcatKmid { get; set; }
        public string ProviderProdName { get; set; }
        public int? MainProdId { get; set; }
        public bool? Ismarriage { get; set; }
        public short? ProdGenderId { get; set; }
        public string ProdId1c { get; set; }
        public short GuaranteeMonth { get; set; }
        public bool ProviderReturn { get; set; }
        public short? DocTypeCode { get; set; }
        public short? DocInfoCode { get; set; }
        public DateTime? DocValidPeriod { get; set; }
        public byte? ProdIdroleId { get; set; }
        public string CellNumber { get; set; }
        public bool? FirstPriceProduct { get; set; }
        public int? BrendId { get; set; }
        public bool? TrackWms { get; set; }

        public virtual ICollection<TOrderMonitorsTemp> TOrderMonitorsTemps { get; set; }
    }
}
