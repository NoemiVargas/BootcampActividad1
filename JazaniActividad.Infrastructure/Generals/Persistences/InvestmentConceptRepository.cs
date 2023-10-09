using JazaniActividad.Domain.Generals.Models;
using JazaniActividad.Domain.Generals.Repositories;
using JazaniActividad.Infrastructure.Cores.Contexts;
using JazaniActividad.Infrastructure.Cores.Persistences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Infrastructure.Generals.Persistences
{
    public class InvestmentConceptRepository : CrudRepository<InvestmentConcept, int>, IInvesmentConceptRepository
    {
        public InvestmentConceptRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
