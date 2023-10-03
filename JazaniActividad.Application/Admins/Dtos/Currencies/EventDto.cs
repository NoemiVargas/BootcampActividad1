namespace JazaniActividad.Application.Admins.Dtos.Currencies
{
    public class EventDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int CreatorEmployeeId { get; set; }
        public int OwnerEmployeeId { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
        public bool State { get; set; }
    }
}
