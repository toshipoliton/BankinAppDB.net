namespace BankinAppDB.net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPostalCodeToAddressAndPerson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Postalcode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "Postalcode");
        }
    }
}
