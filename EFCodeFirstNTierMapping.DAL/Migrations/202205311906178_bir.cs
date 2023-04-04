namespace EFCodeFirstNTierMapping.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bir : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FilmDetay",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FilmDetayi = c.String(),
                        FilmID = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        AddedTime = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Filmler",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        FilmAdi = c.String(nullable: false),
                        VizyonTarihi = c.DateTime(nullable: false),
                        KategoriID = c.Int(nullable: false),
                        FilmDetayID = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        AddedTime = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FilmKategori", t => t.KategoriID, cascadeDelete: true)
                .ForeignKey("dbo.FilmDetay", t => t.ID)
                .Index(t => t.ID)
                .Index(t => t.KategoriID);
            
            CreateTable(
                "dbo.FilmKategori",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        AddedTime = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OyuncuFilm",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CalismaGunu = c.Int(nullable: false),
                        OyuncuID = c.Int(nullable: false),
                        FilmID = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        AddedTime = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Oyuncu", t => t.FilmID, cascadeDelete: true)
                .ForeignKey("dbo.Filmler", t => t.OyuncuID, cascadeDelete: true)
                .Index(t => t.OyuncuID)
                .Index(t => t.FilmID);
            
            CreateTable(
                "dbo.Oyuncu",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OyuncuAdi = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                        Hayati = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        AddedTime = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Filmler", "ID", "dbo.FilmDetay");
            DropForeignKey("dbo.OyuncuFilm", "OyuncuID", "dbo.Filmler");
            DropForeignKey("dbo.OyuncuFilm", "FilmID", "dbo.Oyuncu");
            DropForeignKey("dbo.Filmler", "KategoriID", "dbo.FilmKategori");
            DropIndex("dbo.OyuncuFilm", new[] { "FilmID" });
            DropIndex("dbo.OyuncuFilm", new[] { "OyuncuID" });
            DropIndex("dbo.Filmler", new[] { "KategoriID" });
            DropIndex("dbo.Filmler", new[] { "ID" });
            DropTable("dbo.Oyuncu");
            DropTable("dbo.OyuncuFilm");
            DropTable("dbo.FilmKategori");
            DropTable("dbo.Filmler");
            DropTable("dbo.FilmDetay");
        }
    }
}
