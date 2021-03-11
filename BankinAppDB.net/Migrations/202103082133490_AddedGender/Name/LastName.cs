namespace BankinAppDB.net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGenderNameLastName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Genders", "Name", c => c.String());
            AddColumn("dbo.Genders", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Genders", "LastName");
            DropColumn("dbo.Genders", "Name");
        }
    }
}
