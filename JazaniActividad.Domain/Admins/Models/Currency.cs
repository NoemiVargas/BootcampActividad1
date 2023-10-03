namespace JazaniActividad.Domain.Admins.Models
{
    public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Symbol {  get; set; }
        public DateTimeOffset Registration {  get; set; }
        public bool State { get; set; }

    }
}
