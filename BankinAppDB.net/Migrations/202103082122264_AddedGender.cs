namespace BankinAppDB.net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGender : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        GenderSexe = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Person", "GenderSexe_id", c => c.Int());
            CreateIndex("dbo.Person", "GenderSexe_id");
            AddForeignKey("dbo.Person", "GenderSexe_id", "dbo.Genders", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Person", "GenderSexe_id", "dbo.Genders");
            DropIndex("dbo.Person", new[] { "GenderSexe_id" });
            DropColumn("dbo.Person", "GenderSexe_id");
            DropTable("dbo.Genders");
        }
    }
}
