namespace Locadora.Filmes.Dados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicaoFilmeOk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Filme",
                c => new
                    {
                        IdFilme = c.Long(nullable: false, identity: true),
                        NomeFime = c.String(nullable: false, maxLength: 100),
                        IdAlbun = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdFilme)
                .ForeignKey("dbo.Album", t => t.IdAlbun, cascadeDelete: true)
                .Index(t => t.IdAlbun);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Filme", "IdAlbun", "dbo.Album");
            DropIndex("dbo.Filme", new[] { "IdAlbun" });
            DropTable("dbo.Filme");
        }
    }
}
