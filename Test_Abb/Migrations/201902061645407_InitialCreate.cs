namespace Test_Abb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Measure",
                c => new
                    {
                        MeasureId = c.Int(nullable: false, identity: true),
                        MotorId = c.Int(nullable: false),
                        Timestamp = c.Time(nullable: false, precision: 7),
                        ActualRevsRpm = c.Decimal(precision: 18, scale: 2),
                        DifferenceRpm = c.Decimal(precision: 18, scale: 2),
                        ActualCurrentA = c.Decimal(precision: 18, scale: 2),
                        DifferenceA = c.Decimal(precision: 18, scale: 2),
                        ActualPresureBar = c.Decimal(precision: 18, scale: 2),
                        DifferenceBar = c.Decimal(precision: 18, scale: 2),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        CombustionMotor_MotorId = c.Int(),
                        ElectricMotor_MotorId = c.Int(),
                        HydraulicMotor_MotorId = c.Int(),
                    })
                .PrimaryKey(t => t.MeasureId)
                .ForeignKey("dbo.Motor", t => t.CombustionMotor_MotorId)
                .ForeignKey("dbo.Motor", t => t.MotorId, cascadeDelete: true)
                .ForeignKey("dbo.Motor", t => t.ElectricMotor_MotorId)
                .ForeignKey("dbo.Motor", t => t.HydraulicMotor_MotorId)
                .Index(t => t.MotorId)
                .Index(t => t.CombustionMotor_MotorId)
                .Index(t => t.ElectricMotor_MotorId)
                .Index(t => t.HydraulicMotor_MotorId);
            
            CreateTable(
                "dbo.Motor",
                c => new
                    {
                        MotorId = c.Int(nullable: false, identity: true),
                        MotorName = c.String(nullable: false, maxLength: 60),
                        MotorType = c.Int(),
                        MaxPower = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FuelConsumption = c.Decimal(precision: 18, scale: 2),
                        MaxTorque = c.Decimal(precision: 18, scale: 2),
                        VoltageV = c.Decimal(precision: 18, scale: 2),
                        CurrentA = c.Decimal(precision: 18, scale: 2),
                        MaxPresure = c.Decimal(precision: 18, scale: 2),
                        Displacement = c.Decimal(precision: 18, scale: 2),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.MotorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Measure", "HydraulicMotor_MotorId", "dbo.Motor");
            DropForeignKey("dbo.Measure", "ElectricMotor_MotorId", "dbo.Motor");
            DropForeignKey("dbo.Measure", "MotorId", "dbo.Motor");
            DropForeignKey("dbo.Measure", "CombustionMotor_MotorId", "dbo.Motor");
            DropIndex("dbo.Measure", new[] { "HydraulicMotor_MotorId" });
            DropIndex("dbo.Measure", new[] { "ElectricMotor_MotorId" });
            DropIndex("dbo.Measure", new[] { "CombustionMotor_MotorId" });
            DropIndex("dbo.Measure", new[] { "MotorId" });
            DropTable("dbo.Motor");
            DropTable("dbo.Measure");
        }
    }
}
