using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Application.generals.Dtos.Invesments
{
    public class InvesmentFilterDto
    {
        public int MiningConcessionId { get; set; }
        public int CurrencyTypeId { get; set; }
        public bool State { get; set; }
    }
}
