using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba_2_MVC.Models
{
    public class Perros
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Edad { get; set; }

        public string TipoRazaID { get; set; }

        public virtual Razas Razas { get; set; }
    }
}