using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Application.Generals.Dtos.Invesments
{
    public class InvesmentSaveDto
    {
        public string Amount { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public int Miningconcessionid { get; set; }
        public int Invesmenttypeid { get; set; }
        public int Periodtypeid { get; set; }
        public int Measureunitid { get; set; }
        public string Monthhname { get; set; }
        public int Monthhid { get; set; }
        public string Accreditationcode { get; set; }
        public string Accountantcode { get; set; }
        public int Holderid { get; set; }
        public int Declaredtypeid { get; set; }
        public int Documentid { get; set; }
        public int Invesmentconceptid { get; set; }
        public int Module { get; set; }
        public int Frecuency { get; set; }
        public int Isdac { get; set; }
        public string Metrictons { get; set; }
        public DateTime Declarationdate { get; set; }
    }
}
