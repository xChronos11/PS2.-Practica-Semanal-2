using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PS2._Practica_Semanal_2.Models
{
    public class Products
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre de producto")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Precio")]
        public  string Precio { get; set; }

    }
}