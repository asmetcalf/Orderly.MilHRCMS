﻿using Orderly.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Models
{
    public class UnitInfoDetail
    {
        public int Id { get; set; }
        public int PersonnelId { get; set; }
        public virtual Personnel Personnel { get; set; }
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
        public DateTimeOffset? LossDate { get; set; }
        [Display(Name = "Duty Status")]
        public string DutyStatus { get; set; }
        [Display(Name = "Created by")]
        public string CreatedByUserName { get; set; }
        public Guid CreatedBy { get; set; }
        [Display(Name = "Last modified by")]
        public string ModifiedByUserName { get; set; }
        public Guid ModifiedLast { get; set; }
        [Display(Name = "Created on")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name = "Modified on")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
