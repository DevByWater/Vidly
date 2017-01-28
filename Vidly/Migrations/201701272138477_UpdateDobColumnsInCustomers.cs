namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDobColumnsInCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET DoB='01/01/1950' WHERE Name='John Williams'");
        }
        
        public override void Down()
        {
        }
    }
}
