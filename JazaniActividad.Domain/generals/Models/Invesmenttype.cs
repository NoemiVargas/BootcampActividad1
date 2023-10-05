using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Domain.Generals.Models
{
    public class Invesmenttype
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime Registrationdate { get; set; }
        public bool State { get; set; }

    }
}
