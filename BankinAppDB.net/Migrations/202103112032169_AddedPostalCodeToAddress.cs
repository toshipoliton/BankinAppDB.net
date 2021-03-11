namespace BankinAppDB.net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPostalCodeToAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "Postalcode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Addresses", "Postalcode");
        }
    }
}
