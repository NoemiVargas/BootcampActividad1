﻿

namespace JazaniActividad.Domain.cores.Models
{
    public abstract class CoreModel<ID>
    {
        public ID Id { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool State { get; set; }
    }
}
