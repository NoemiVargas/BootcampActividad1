﻿

namespace JazaniActividad.Domain.Generals.Models
{
    public class InvestmentConcept
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool State { get; set; }
    }
}
