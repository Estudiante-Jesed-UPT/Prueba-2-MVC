using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using Prueba_2_MVC.Models;


namespace Prueba_2_MVC
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Prueba MVC")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder) 
        { 
        }
            public virtual DbSet<Perros> Perros { get; set; }
            public virtual DbSet<Razas> Razas { get; set; }
    }
    
}
