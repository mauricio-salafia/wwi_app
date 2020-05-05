using System.Diagnostics.CodeAnalysis;
using WideWorldImporters.Catalog.Domain.Common;

namespace WideWorldImporters.Catalog.Domain.Entities
{
    /// <summary>
    /// Category model
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Category : Auditable
    {
        /// <summary>
        /// Entity ID
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// Flag used for soft delete
        /// </summary>
        public bool Enable { get; set; }
    }
}
