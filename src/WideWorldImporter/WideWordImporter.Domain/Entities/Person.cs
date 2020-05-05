using WideWordImporter.Domain.Common;

namespace WideWordImporter.Domain.Entities
{
    /// <summary>
    /// Person entity
    /// </summary>
    public class Person : AuditableEntity
    {
        /// <summary>
        /// Person ID property
        /// </summary>
        public long PersonID { get; set; }
        /// <summary>
        /// First Name property
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Middle Name property
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// Last Name property
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SearchName { get; set; }
    }
}
