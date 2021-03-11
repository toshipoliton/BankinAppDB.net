namespace BankinAppDB.net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenderPlusName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Genders", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Genders", "Name");
        }
    }
}
