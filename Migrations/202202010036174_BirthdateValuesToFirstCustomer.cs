namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BirthdateValuesToFirstCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '12/15/1991' WHERE Id=1");
        }
        
        public override void Down()
        {
        }
    }
}
