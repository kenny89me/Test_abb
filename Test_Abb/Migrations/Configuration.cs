

namespace Test_Abb.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using Test_Abb.Models;


    internal sealed class Configuration : DbMigrationsConfiguration<Test_Abb.DAL.TestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Test_Abb.DAL.TestContext context)
        {
  
            var electricMotors = new List<ElectricMotor>
            {
                new ElectricMotor{ MotorName = "Motor1", MotorType = MotorType.Electric, MaxPower = 2.0m, VoltageV = 230m, CurrentA = 8.7m, ElectricMeasures = new List<ElectricMeasure>() }

            };
            electricMotors.ForEach(s => context.ElectricMotors.Add(s));
            context.SaveChanges();

            var combustionMotors = new List<CombustionMotor>
            {
                new CombustionMotor { MotorName = "Motor2", MotorType = MotorType.Combustion, MaxPower = 50m, FuelConsumption = 4, MaxTorque = 3000m, CombustionMeasures = new List<CombustionMeasure>() }

            };
            combustionMotors.ForEach(s => context.CombustionMotors.Add(s));
            context.SaveChanges();

            var hydraulicMotors = new List<HydraulicMotor>
            {
                new HydraulicMotor{ MotorName = "Motor3", MotorType = MotorType.Hydraulic, MaxPower = 1m, MaxPresure = 160m, Displacement = 16m, HydraulicMeasures = new List<HydraulicMeasure>() }

            };
            hydraulicMotors.ForEach(s => context.HydraulicMotors.Add(s));
            context.SaveChanges();

            var electricMeasures = new List<ElectricMeasure>
            {
            new ElectricMeasure{ MotorId = 1, Timestamp = new TimeSpan(10,00,00), ActualCurrentA = 7.0m , DifferenceA = 0m },
            new ElectricMeasure{ MotorId = 1, Timestamp = new TimeSpan(10,10,00), ActualCurrentA = 7.9m , DifferenceA = 0m },
            new ElectricMeasure{ MotorId = 1, Timestamp = new TimeSpan(10,30,00), ActualCurrentA = 7.3m , DifferenceA = 0m},
            new ElectricMeasure{ MotorId = 1, Timestamp = new TimeSpan(10,20,00), ActualCurrentA = 6.5m , DifferenceA = 0m },
            new ElectricMeasure{ MotorId = 1, Timestamp = new TimeSpan(10,40,00), ActualCurrentA = 7.8m , DifferenceA = 0m },
            new ElectricMeasure{ MotorId = 1, Timestamp = new TimeSpan(10,50,00), ActualCurrentA = 6.9m , DifferenceA = 0m },
            new ElectricMeasure{ MotorId = 1, Timestamp = new TimeSpan(11,00,00), ActualCurrentA = 7.0m , DifferenceA = 0m }
            };
            electricMeasures.ForEach(s => context.ElectricMeasures.Add(s));
            context.SaveChanges();


            var combustionMeasures = new List<CombustionMeasure>
            {
            new CombustionMeasure{ MotorId = 2, Timestamp = new TimeSpan(10,00,00), ActualRevsRpm = 2890m, DifferenceRpm = 0m},
            new CombustionMeasure{ MotorId = 2, Timestamp = new TimeSpan(10,10,00), ActualRevsRpm = 3100m, DifferenceRpm = 0m},
            new CombustionMeasure{ MotorId = 2, Timestamp = new TimeSpan(10,20,00), ActualRevsRpm = 2800m, DifferenceRpm = 0m},
            new CombustionMeasure{ MotorId = 2, Timestamp = new TimeSpan(10,30,00), ActualRevsRpm = 2860m, DifferenceRpm = 0m},
            new CombustionMeasure{ MotorId = 2, Timestamp = new TimeSpan(10,40,00), ActualRevsRpm = 2875m, DifferenceRpm = 0m},
            new CombustionMeasure{ MotorId = 2, Timestamp = new TimeSpan(10,50,00), ActualRevsRpm = 2790m, DifferenceRpm = 0m},
            new CombustionMeasure{ MotorId = 2, Timestamp = new TimeSpan(11,00,00), ActualRevsRpm = 2900m, DifferenceRpm = 0m}
            };
            combustionMeasures.ForEach(s => context.CombustionMeasures.Add(s));
            context.SaveChanges();



            var hydraulicMeasures = new List<HydraulicMeasure>
            {
            new HydraulicMeasure { MotorId = hydraulicMotors.Single(h => h.MotorName == "Motor3").MotorId, Timestamp = new TimeSpan(10, 00, 00), ActualPresureBar = 155m, DifferenceBar = 0m  },
            new HydraulicMeasure { MotorId = hydraulicMotors.Single(h => h.MotorName == "Motor3").MotorId, Timestamp = new TimeSpan(10, 10, 00), ActualPresureBar = 158m, DifferenceBar = 0m},
            new HydraulicMeasure { MotorId = hydraulicMotors.Single(h => h.MotorName == "Motor3").MotorId, Timestamp = new TimeSpan(10, 20, 00), ActualPresureBar = 140, DifferenceBar = 0m},
            new HydraulicMeasure { MotorId = hydraulicMotors.Single(h => h.MotorName == "Motor3").MotorId, Timestamp = new TimeSpan(10, 30, 00), ActualPresureBar = 145m, DifferenceBar = 0m},
            new HydraulicMeasure { MotorId = hydraulicMotors.Single(h => h.MotorName == "Motor3").MotorId, Timestamp = new TimeSpan(10, 40, 00), ActualPresureBar = 159m, DifferenceBar = 0m},
            new HydraulicMeasure { MotorId = hydraulicMotors.Single(h => h.MotorName == "Motor3").MotorId, Timestamp = new TimeSpan(10, 50, 00), ActualPresureBar = 160m, DifferenceBar = 0m},
            new HydraulicMeasure { MotorId = hydraulicMotors.Single(h => h.MotorName == "Motor3").MotorId, Timestamp = new TimeSpan(11, 00, 00), ActualPresureBar = 139m, DifferenceBar = 0m}
            };
            //StudentID = students.Single(s => s.LastName == "Alonso").ID;


            hydraulicMeasures.ForEach(s => context.HydraulicMeasures.Add(s));
            context.SaveChanges();
        }


        //  This method will be called after migrating to the latest version.

        //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
        //  to avoid creating duplicate seed data.

    }
}
