using System;
using System.Diagnostics.CodeAnalysis;

namespace WideWorldImporters.Catalog.Domain.Common
{
    [ExcludeFromCodeCoverage]
    /// <summary>
    /// Common class used to audit entities
    /// </summary>
    public class Auditable
    {
        /// <summary>
        /// The User ID that modified the entity last time
        /// </summary>
        public long EditedBy { get; set; }
        /// <summary>
        /// Date and time when was edited
        /// </summary>
        public DateTime Edited { get; set; }
    }
}
