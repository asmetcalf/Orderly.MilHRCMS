﻿using Orderly.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Models
{
    public class RecordDetail
    {
        //Summary:
        //This item collects all properties related to personnel records.
        //It draws from the following classes: Personnel, Housing, Contact, and UnitInfo
        //A RecordDetail is used to display all data associated with a human being
        //from within a single View.

        //PERSONNEL
        public int PersonnelId { get; set; }
        public Grade Rank { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        public BioSex Sex { get; set; }
        public string SSN { get; set; }
        [Display(Name = "DoD ID")]
        public string DOD { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTimeOffset DOB { get; set; }
        public int Age
        {
            get
            {
                var age = DateTime.Today.Year - DOB.Year;
                if (DOB.Date > DateTime.Today.AddYears(-age)) age--;
                return age;
            }
        }
        [Display(Name = "Marital Status")]
        public MaritalStatus MaritalStatus { get; set; }
        [Display(Name = "Created by")]
        public string PersonnelCreatedByUserName { get; set; }
        public Guid PersonnelCreatedBy { get; set; }
        [Display(Name = "Last modified by")]
        public string PersonnelModifiedByUserName { get; set; }
        public Guid PersonnelModifiedLast { get; set; }
        [Display(Name = "Created on")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTimeOffset PersonnelCreatedUtc { get; set; }
        [Display(Name = "Modified on")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTimeOffset? PersonnelModifiedUtc { get; set; }

        //CONTACT
        public int ContactId { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Personal Email")]
        public string PersonalEmail { get; set; }
        [Display(Name = ".mil Email")]
        public string MilEmail { get; set; }
        [Display(Name = "Drivers License?")]
        public bool HasDriversLicense { get; set; }
        [Display(Name = "Vehicle Make")]
        public string VehicleMake { get; set; }
        [Display(Name = "Vehicle Model")]
        public string VehicleModel { get; set; }
        [Display(Name = "Vehicle Color")]
        public string VehicleColor { get; set; }
        [Display(Name = "Vehicle Plate")]
        public string VehiclePlate { get; set; }
        [Display(Name = "Vehicle Year")]
        public int VehicleYear { get; set; }
        [Display(Name = "Last Vehicle Inspection")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTimeOffset? VehicleInspected { get; set; }
        [Display(Name = "Created by")]
        public string ContactCreatedByUserName { get; set; }
        public Guid ContactCreatedBy { get; set; }
        [Display(Name = "Last modified by")]
        public string ContactModifiedByUserName { get; set; }
        public Guid ContactModifiedLast { get; set; }
        [Display(Name = "Created on")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTimeOffset ContactCreatedUtc { get; set; }
        [Display(Name = "Modified on")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTimeOffset? ContactModifiedUtc { get; set; }

        //HOUSING
        public int HousingId { get; set; }
        [Display(Name = "Street Address")]
        public string Address { get; set; }
        [Display(Name = "Room #")]
        public string Room { get; set; }
        [Display(Name = "Created by")]
        public string HousingCreatedByUserName { get; set; }
        public Guid HousingCreatedBy { get; set; }
        [Display(Name = "Last modified by")]
        public string HousingModifiedByUserName { get; set; }
        public Guid HousingModifiedLast { get; set; }
        [Display(Name = "Created on")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTimeOffset HousingCreatedUtc { get; set; }
        [Display(Name = "Modified on")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTimeOffset? HousingModifiedUtc { get; set; }

        //UNITINFO
        public int UnitInfoId { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public int SquadId { get; set; }
        public virtual Squad Squad { get; set; }
        public int PlatoonId { get; set; }
        public virtual Platoon Platoon { get; set; }
        public string Role { get; set; }
        [Display(Name = "Arrival Date")]
        public DateTimeOffset Arrived { get; set; }
        [Display(Name = "Loss Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTimeOffset? LossDate { get; set; }
        [Display(Name = "Duty Status")]
        public string DutyStatus { get; set; }
        [Display(Name = "Created by")]
        public string UnitInfoCreatedByUserName { get; set; }
        public Guid UnitInfoCreatedBy { get; set; }
        [Display(Name = "Last modified by")]
        public string UnitInfoModifiedByUserName { get; set; }
        public Guid UnitInfoModifiedLast { get; set; }
        [Display(Name = "Created on")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTimeOffset UnitInfoCreatedUtc { get; set; }
        [Display(Name = "Modified on")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTimeOffset? UnitInfoModifiedUtc { get; set; }
    }
}
