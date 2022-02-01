
namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class CreateGenresTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Genre",
                    c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            AddForeignKey("dbo.Movies", "GenreId", "dbo.Genre", "Id", cascadeDelete: true);

            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");

            Sql("DROP TABLE Genres");
        }

        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropTable("dbo.Genres");
        }
    }
}
