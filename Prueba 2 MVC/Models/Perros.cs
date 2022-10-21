using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prueba_2_MVC.Models
{
    public class Perros
    {
        public int Id { get; set; }
        [Display(Name = "Nombre del cachorro")]
        public string Name { get; set; }
        [Display(Name = "Edad del cachorro")]
        public int Edad { get; set; }
        [Display(Name="Tipo de Raza")]
        public string TipoRazaID { get; set; }

        public virtual Razas Razas { get; set; }
    }
}