namespace DatabaseActivities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShippingContainer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShippingContainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        weight = c.Int(nullable: false),
                        destination = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ShippingContainers");
        }
    }
}
