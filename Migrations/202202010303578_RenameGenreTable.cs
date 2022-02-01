namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameGenreTable : DbMigration
    {
        public override void Up()
        {
            RenameTable("Genre", "Genres");
        }
        
        public override void Down()
        {
        }
    }
}
