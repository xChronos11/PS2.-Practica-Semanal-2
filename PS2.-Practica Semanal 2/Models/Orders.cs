using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PS2._Practica_Semanal_2.Models
{
    public class Orders
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre")]

        public string Name { get; set; }


        [Required]
        [Display(Name ="Cantidad")]
        public int Qty { get; set; }
       
        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Products Products { get; set; }

        public int? StatusId { get; set; }
        [ForeignKey("StatusId")]
        public Status Status { get; set; }
    }
}