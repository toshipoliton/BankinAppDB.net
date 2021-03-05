namespace BankinAppDB.net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
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

            CreateTable(
                "dbo.Person",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 350),
                    LastName = c.String(),
                    Age = c.Int(nullable: false),
                    Role = c.String(),
                    DateOfBirth = c.DateTime(nullable: false),
                    Salary = c.Int(nullable: false),
                    HomeAddress_id = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Addresses", t => t.HomeAddress_id)
                .Index(t => t.HomeAddress_id);

            CreateTable(
                "dbo.CheckingsAccount",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        AccountId = c.Guid(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 19, scale: 4),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Person", t => t.PersonId)
                .Index(t => t.PersonId);
            
            
            
            CreateTable(
                "dbo.SavingsAccount",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        AccountId = c.Guid(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 19, scale: 4),
                        Interest = c.Decimal(nullable: false, precision: 19, scale: 4),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Person", t => t.PersonId)
                .Index(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SavingsAccount", "PersonId", "dbo.Person");
            DropForeignKey("dbo.Person", "HomeAddress_id", "dbo.Addresses");
            DropForeignKey("dbo.CheckingsAccount", "PersonId", "dbo.Person");
            DropIndex("dbo.SavingsAccount", new[] { "PersonId" });
            DropIndex("dbo.Person", new[] { "HomeAddress_id" });
            DropIndex("dbo.CheckingsAccount", new[] { "PersonId" });
            DropTable("dbo.SavingsAccount");
            DropTable("dbo.Person");
            DropTable("dbo.CheckingsAccount");
            DropTable("dbo.Addresses");
        }
    }
}
