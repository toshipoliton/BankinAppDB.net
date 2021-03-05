namespace BankinAppDB.net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateOfBirht : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BirthDates",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        DateOfBirth = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Person", "DateOfBirth_id", c => c.Int());
            CreateIndex("dbo.Person", "DateOfBirth_id");
            AddForeignKey("dbo.Person", "DateOfBirth_id", "dbo.BirthDates", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Person", "DateOfBirth_id", "dbo.BirthDates");
            DropIndex("dbo.Person", new[] { "DateOfBirth_id" });
            DropColumn("dbo.Person", "DateOfBirth_id");
            DropTable("dbo.BirthDates");
        }
    }
}
