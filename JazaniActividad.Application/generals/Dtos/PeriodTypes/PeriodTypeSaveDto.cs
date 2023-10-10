

namespace JazaniActividad.Application.Generals.Dtos.PeriodTypes
{
    public class PeriodTypeSaveDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Time { get; set; }
        public int RegistrationDate { get; set; }
        public bool State { get; set; }
    }
}
