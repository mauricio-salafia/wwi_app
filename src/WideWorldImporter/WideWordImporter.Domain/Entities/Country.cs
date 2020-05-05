using WideWordImporter.Domain.Common;

namespace WideWordImporter.Domain.Entities
{
    public class Country : AuditableEntity
    {
        public long CountryID { get; set; }
        public string CountryName { get; set; }
        public string FormalName { get; set; }
        public string Continent { get; set; }
        public string Region { get; set; }
        public string SubRegion { get; set; }

    }
}
