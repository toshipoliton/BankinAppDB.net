namespace BankinAppDB.net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "LastName");
        }
    }
}
