namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieTableData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, InStock, GenreId) VALUES('Hangover', '6/2/2009', '1/31/2022', 10, 2)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, InStock, GenreId) VALUES('Die Hard', '7/22/1988', '1/31/2022', 5, 1)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, InStock, GenreId) VALUES('Terminator', '10/26/1984', '1/31/2022', 8, 1)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, InStock, GenreId) VALUES('Toy Story', '11/22/1995', '1/31/2022', 3, 3)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, InStock, GenreId) VALUES('Titanic', '12/19/1997', '1/31/2022', 15, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
