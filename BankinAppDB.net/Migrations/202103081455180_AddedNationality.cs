namespace BankinAppDB.net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNationality : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Nationality", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "Nationality");
        }
    }
}
