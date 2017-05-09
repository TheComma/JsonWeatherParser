namespace OruPrognozuotojas.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Weathers",
                c => new
                    {
                        WeatherId = c.Int(nullable: false, identity: true),
                        AverageTemperature = c.Single(nullable: false),
                        MinimumTemperature = c.Single(nullable: false),
                        MaximumTemperature = c.Single(nullable: false),
                        Pressure = c.Int(nullable: false),
                        Humidity = c.Int(nullable: false),
                        WindSpeed = c.Int(nullable: false),
                        WindDegree = c.Int(nullable: false),
                        CloudCoverege = c.Int(nullable: false),
                        Sky = c.String(),
                        SkyDescription = c.String(),
                        RecordDate = c.DateTime(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.WeatherId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Weathers");
        }
    }
}
