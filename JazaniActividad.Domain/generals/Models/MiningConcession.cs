﻿

namespace JazaniActividad.Domain.Generals.Models
{
    public class MiningConcession
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime  RegistrationDate { get; set; }
        public bool? State { get; set; }
        public string Code { get; set; }
        public string? Observation { get; set; }
        public int MineralTypeId { get; set; }
        public int OriginId { get; set; }
        public int TypeId { get; set; }
        public int SituationId { get; set; }
        public int MiningUnitId { get; set; }
        public int ConditionId { get; set; }
        public int StateManagementId { get; set; }

        public ICollection<Invesment> Invesments { get; set; }
    }
}
