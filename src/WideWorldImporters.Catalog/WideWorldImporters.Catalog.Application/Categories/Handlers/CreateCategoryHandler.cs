using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WideWorldImporters.Catalog.Application.Categories.Commands;
using WideWorldImporters.Catalog.Application.Common.Interfaces;
using WideWorldImporters.Catalog.Domain.Entities;

namespace WideWorldImporters.Catalog.Application.Categories.Handlers
{
    /// <summary>
    /// Handle the creation of a new category
    /// </summary>
    public class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand, int>
    {
        private readonly ICatalogDbContext _dbContext;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dbContext">Database context</param>
        /// <param name="mapper">Automapper</param>
        public CreateCategoryHandler(ICatalogDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        /// <summary>
        /// Handle the creation of a new category
        /// </summary>
        /// <param name="request">Request command</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>A task that contains the new category ID</returns>
        public Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Category>(request);
            _dbContext.Categories.Add(category);
            var result = _dbContext.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
