namespace BankinAppDB.net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Role : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Role", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "Role");
        }
    }
}
