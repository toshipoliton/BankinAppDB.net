namespace BankinAppDB.net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAddressAndAge : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.Person", "HomeAddress_Street", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "HomeAddress_Street");
            DropColumn("dbo.Person", "Age");
        }
    }
}
