namespace Prueba_2_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracion1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Perros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Edad = c.Int(nullable: false),
                        TipoRazaID = c.String(),
                        Razas_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Razas", t => t.Razas_Id)
                .Index(t => t.Razas_Id);
            
            CreateTable(
                "dbo.Razas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoRazas = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Perros", "Razas_Id", "dbo.Razas");
            DropIndex("dbo.Perros", new[] { "Razas_Id" });
            DropTable("dbo.Razas");
            DropTable("dbo.Perros");
        }
    }
}
