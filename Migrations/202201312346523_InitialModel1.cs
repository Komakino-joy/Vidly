namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {

        public override void Up()
        {
            Sql("ALTER TABLE MembershipTypes DROP COLUMN Name");
            AddColumn("dbo.MembershipTypes", "Name", c => c.Short(nullable: false));
        }

        public override void Down()
        {
        }


    }
}
