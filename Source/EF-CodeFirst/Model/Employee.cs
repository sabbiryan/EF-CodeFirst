﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee: Entity
    {
        [Required]
        public string CompanyId { get; set; }        

        [Required]
        public string Name { get; set; }

        public string Designation { get; set; }

        [Required]
        public DateTime JoiningDate { get; set; }


        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }
    }
}
