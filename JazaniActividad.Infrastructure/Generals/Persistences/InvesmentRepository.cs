using JazaniActividad.Infrastructure.Cores.Contexts;
using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;
using Microsoft.EntityFrameworkCore;
using JazaniActividad.Infrastructure.Cores.Persistences;
using JazaniActividad.Core.Paginations;
using JazaniActividad.Domain.Cores.Paginations;
using JazaniActividad.Infrastructure.Cores.Paginations;

namespace JazaniActividad.Infrastructure.Generals.Persistences
{
    public class InvesmentRepository : CrudRepository<Invesment, int>, IInvesmentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IPaginator<Invesment> _paginator;
        public InvesmentRepository(ApplicationDbContext dbContext, IPaginator<Invesment> paginator) : base(dbContext)
        {
            _dbContext = dbContext;
            _paginator = paginator;
        }

        public async Task<ResponsePagination<Invesment>> PaginatedSearch(RequestPagination<Invesment> request)
        {
            var filter = request.Filter;

            var query = _dbContext.Set<Invesment>().AsQueryable();

            if (filter is not null)
            {
                query = query
                    .Where(x =>
                    (filter.MiningConcessionId == 0 || x.MiningConcessionId == filter.MiningConcessionId)
                    && (filter.CurrencyTypeId == 0 || x.CurrencyTypeId == filter.CurrencyTypeId)
                    && (x.State == filter.State)
                );
            }


            query = query.OrderByDescending(x => x.Id);


            return await _paginator.Paginate(query, request);
        }
    }
}
