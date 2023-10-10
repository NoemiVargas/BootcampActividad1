using JazaniActividad.Core.Paginations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Domain.Cores.Repositories
{
    public interface IPaginatedRepository<T>
    {
        Task<ResponsePagination<T>> PaginatedSearch(RequestPagination<T> request);
    }
}
