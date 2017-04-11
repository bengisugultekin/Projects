namespace IMDB.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        DirectorID = c.Int(nullable: false, identity: true),
                        DirectorName = c.String(),
                    })
                .PrimaryKey(t => t.DirectorID);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                    })
                .PrimaryKey(t => t.GenreID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieID = c.Int(nullable: false, identity: true),
                        MovieName = c.String(),
                        Description = c.String(),
                        ReleaseDate = c.Int(nullable: false),
                        Score = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ScoreCounter = c.Int(nullable: false),
                        totalScore = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GenreID = c.Int(nullable: false),
                        DirectorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MovieID)
                .ForeignKey("dbo.Directors", t => t.DirectorID, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.GenreID, cascadeDelete: true)
                .Index(t => t.GenreID)
                .Index(t => t.DirectorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreID", "dbo.Genres");
            DropForeignKey("dbo.Movies", "DirectorID", "dbo.Directors");
            DropIndex("dbo.Movies", new[] { "DirectorID" });
            DropIndex("dbo.Movies", new[] { "GenreID" });
            DropTable("dbo.Movies");
            DropTable("dbo.Genres");
            DropTable("dbo.Directors");
        }
    }
}
