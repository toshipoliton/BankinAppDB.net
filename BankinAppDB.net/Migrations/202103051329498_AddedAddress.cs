namespace BankinAppDB.net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Person", "HomeAddress_id", c => c.Int());
            CreateIndex("dbo.Person", "HomeAddress_id");
            AddForeignKey("dbo.Person", "HomeAddress_id", "dbo.Addresses", "id");
            DropColumn("dbo.Person", "HomeAddress_Street");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Person", "HomeAddress_Street", c => c.String());
            DropForeignKey("dbo.Person", "HomeAddress_id", "dbo.Addresses");
            DropIndex("dbo.Person", new[] { "HomeAddress_id" });
            DropColumn("dbo.Person", "HomeAddress_id");
            DropTable("dbo.Addresses");
        }
    }
}
