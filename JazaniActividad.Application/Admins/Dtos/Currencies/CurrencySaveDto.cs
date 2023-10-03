using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Application.Admins.Dtos.Currencies
{
    public class CurrencySaveDto
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string? Description { get; set; }
        public string Symbol { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool State {  get; set; }
    }
}
