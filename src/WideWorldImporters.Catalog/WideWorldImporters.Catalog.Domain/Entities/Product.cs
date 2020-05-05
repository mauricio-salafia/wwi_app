using System.Diagnostics.CodeAnalysis;
using WideWorldImporters.Catalog.Domain.Common;
using WideWorldImporters.Catalog.Domain.Enumerations;

namespace WideWorldImporters.Catalog.Domain.Entities
{
    /// <summary>
    /// Product entity class
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Product : Auditable
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }
        public byte[] Photo { get; set; }
        public PackageType Package { get; set; }
        public Category Category { get; set; }
        public bool Enable { get; set; }
    }
}
