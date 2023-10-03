using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Domain.Admins.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int CreatorEmployeeId { get; set; }
        public int OwnerEmployeeId { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
        public bool State { get; set; }

    }
}
