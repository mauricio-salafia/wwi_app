using System;

namespace WideWordImporter.Domain.Common
{
    /// <summary>
    /// Base class entity used for audit
    /// </summary>
    public class AuditableEntity
    {
        /// <summary>
        /// UserId that edited this entity last time
        /// </summary>
        public long LastEditedBy { get; set; }
        /// <summary>
        /// From when this entity is valid
        /// </summary>
        public DateTime ValidFrom { get; set; }
        /// <summary>
        /// Last date and time that this entity is valid
        /// </summary>
        public DateTime ValidTo { get; set; }
    }
}
