namespace BankinAppDB.net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateOfBirth : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Person", "DateOfBirth_id", "dbo.BirthDates");
            DropIndex("dbo.Person", new[] { "DateOfBirth_id" });
            AddColumn("dbo.Person", "DateOfBirth", c => c.DateTime(nullable: false));
            DropColumn("dbo.Person", "DateOfBirth_id");
            DropTable("dbo.BirthDates");
        }
        
        public override void Down()
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
            DropColumn("dbo.Person", "DateOfBirth");
            CreateIndex("dbo.Person", "DateOfBirth_id");
            AddForeignKey("dbo.Person", "DateOfBirth_id", "dbo.BirthDates", "id");
        }
    }
}
