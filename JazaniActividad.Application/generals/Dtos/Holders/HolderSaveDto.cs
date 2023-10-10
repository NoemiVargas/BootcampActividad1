﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazaniActividad.Application.Generals.Dtos.Holders
{
    public class HolderSaveDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Maindenname { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentNumber2 { get; set; }
        public string landline { get; set; }
        public string mobile { get; set; }
        public string address { get; set; }
        public string CorporateEmail { get; set; }
        public string PersonalMail { get; set; }
        public string PublicRecord { get; set; }
        public string DistricId { get; set; }

        public int HolderRegimeId { get; set; }
        public int HolderGroupId { get; set; }

        public int RegistryOfficeId { get; set; }
        public int IdentificationDocumentId { get; set; }
        public int? NationalityId { get; set; }
        public int? CivilStatusId { get; set; }

        public int HolderTypeId { get; set; }

        public int? RegismeDateStart { get; set; }
        public int? RegismeDateEnd { get; set; }
        public DateTimeOffset? RegimeNumberConstancy { get; set; }
        public int RegistrationDate { get; set; }
        public bool State { get; set; }
        public int? HolderCategoryId { get; set; }
        public bool? Isexternal { get; set; }
        public string? IngemmetName { get; set; }
    }
}
