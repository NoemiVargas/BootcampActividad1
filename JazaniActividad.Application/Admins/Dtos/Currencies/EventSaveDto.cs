namespace JazaniActividad.Application.Admins.Dtos.Currencies
{
    public class EventSaveDto
    {
        public string Name { get; set; } 
        public string? Description { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int CreatorEmployeeId { get; set; }
        public int OwnerEmployeeId { get; set; }
    }
}
