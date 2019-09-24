namespace Sapatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correcao_classe_sapato_201909232013 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sapatoes", "Modelo_ID_Nodelo", c => c.Int(nullable: false));
            CreateIndex("dbo.Sapatoes", "Modelo_ID_Nodelo");
            AddForeignKey("dbo.Sapatoes", "Modelo_ID_Nodelo", "dbo.Modeloes", "ID_Nodelo", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sapatoes", "Modelo_ID_Nodelo", "dbo.Modeloes");
            DropIndex("dbo.Sapatoes", new[] { "Modelo_ID_Nodelo" });
            DropColumn("dbo.Sapatoes", "Modelo_ID_Nodelo");
        }
    }
}
