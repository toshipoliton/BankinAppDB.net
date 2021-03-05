namespace BankinAppDB.net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Salary : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Salary", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "Salary");
        }
    }
}
