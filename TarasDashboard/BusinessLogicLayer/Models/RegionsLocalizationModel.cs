using System;

namespace BusinessLogicLayer.Models
{
    public class RegionsLocalizationModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }
        public string CreatedByUserId { get; set; }
        public string LastUpdateByUserId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int LanguageId { get; set; }
    }
}
