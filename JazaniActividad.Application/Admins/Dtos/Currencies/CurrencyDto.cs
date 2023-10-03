namespace JazaniActividad.Application.Admins.Dtos.Currencies
{
    public class CurrencyDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public string Symbol { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
    
        public bool State {  get; set; }
    }
}
