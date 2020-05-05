using MediatR;
using System.Diagnostics.CodeAnalysis;

namespace WideWorldImporters.Catalog.Application.Categories.Commands
{
    [ExcludeFromCodeCoverage]
    public class UpdateCategoryCommand : IRequest
    {
        /// <summary>
        /// Category Id
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// Category name
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// Enable or disable
        /// </summary>
        public bool Enable { get; set; }
    }
}
