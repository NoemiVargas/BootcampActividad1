

namespace JazaniActividad.Application.Generals.Dtos.Invesments
{
    public class InvesmentDto
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public int MiningConcessionId { get; set; }
        public int Invesmenttypeid { get; set; }
        public int CurrencyTypeId { get; set; }
        public int PeriodTypeid { get; set; }
        public int MeasureUnitId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool State { get; set; }
        public string MonthName { get; set; }
        public int MonthId { get; set; }
        public string AccreditationCode { get; set; }
        public string AccountantCode { get; set; }
        public int HolderId { get; set; }
        public int DeclaredTypeId { get; set; }
        public int DocumentId { get; set; }
        public int InvesmentConceptId { get; set; }
        public bool Module { get; set; }
        public int Frecuency { get; set; }
        public int Isdac { get; set; }
        public string Metrictons { get; set; }
        public DateTime DeclarationDate { get; set; }
    }
}
