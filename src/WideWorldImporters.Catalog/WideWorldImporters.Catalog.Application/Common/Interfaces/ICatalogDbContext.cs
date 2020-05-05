using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using WideWorldImporters.Catalog.Domain.Entities;

namespace WideWorldImporters.Catalog.Application.Common.Interfaces
{
    /// <summary>
    /// Interface for CatalogDbContext
    /// </summary>
    public interface ICatalogDbContext
    {
        /// <summary>
        /// DbSet Category
        /// </summary>
        DbSet<Category> Categories { get; set; }
        /// <summary>
        /// DbSet Product
        /// </summary>
        DbSet<Product> Products { get; set; }

        /// <summary>
        /// Save context changes asynchronously
        /// </summary>
        /// <param name="token">Cancellation Token</param>
        /// <returns>Returns the number of records affected</returns>
        Task<int> SaveChangesAsync(CancellationToken token);
    }
}
