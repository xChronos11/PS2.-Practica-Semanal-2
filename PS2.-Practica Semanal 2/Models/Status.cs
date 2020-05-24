using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PS2._Practica_Semanal_2.Models
{
    public class Status
    {
        public int id { get; set; }
        [Display(Name ="Status")]
        public string NameStatus { get; set; }
    }
}