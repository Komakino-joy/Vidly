namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTheDailyMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name='Pay as you go' WHERE Id=1");
        }
        
        public override void Down()
        {
        }
    }
}
