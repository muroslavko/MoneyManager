namespace MoneyManager.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTransactionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        Comment = c.String(),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .Index(t => t.Person_Id);
            
            AddColumn("dbo.People", "Balance", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "Person_Id", "dbo.People");
            DropIndex("dbo.Transactions", new[] { "Person_Id" });
            DropColumn("dbo.People", "Balance");
            DropTable("dbo.Transactions");
        }
    }
}
