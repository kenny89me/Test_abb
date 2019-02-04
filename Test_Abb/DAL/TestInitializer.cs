using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Test_Abb.Models;

namespace Test_Abb.DAL
{
    public class TestInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TestContext>
    {
        protected override void Seed(TestContext context)
        {
            var Motors = new List<Motor>
            {
            new ElectricMotor{MotorName="Motor1", MaxPower = 2.0m, VoltageV = 230.1m, CurrentA = 8.7m },
            new CombustionMotor{MotorName="Motor2",MaxPower=50m, FuelConsumption = 4, MaxTorque = 3000m},
            new HydraulicMotor{MotorName="Motor3",MaxPower=1m, MaxPresure = 160m, Displacement = 16m}
            };

            Motors.ForEach(s => context.Motors.Add(s));
            context.SaveChanges();

            var Measure = new List<Measure>
            {
            new ElectricMeasure{MotorId = 1, Timestamp = new TimeSpan(10,00,00), ActualCurrentA = 7.0m , DifferenceA = null},
            new CombustionMeasure{MotorId = 2, Timestamp = new TimeSpan(10,00,00), ActualRevsRpm = 2890m, DifferenceRpm = null},
            new HydraulicMeasure{MotorId = 3, Timestamp = new TimeSpan(10,00,00), ActualPresureBar = 155m, DifferenceBar= null},
            new ElectricMeasure{MotorId = 1, Timestamp = new TimeSpan(10,10,00), ActualCurrentA = 7.9m , DifferenceA = null },
            new CombustionMeasure{MotorId = 2, Timestamp = new TimeSpan(10,10,00), ActualRevsRpm = 3100m, DifferenceRpm = null},
            new HydraulicMeasure{MotorId = 3, Timestamp = new TimeSpan(10,10,00), ActualPresureBar = 158m, DifferenceBar= null},
            new ElectricMeasure{MotorId = 1, Timestamp = new TimeSpan(10,20,00), ActualCurrentA = 6.5m , DifferenceA = null },
            new CombustionMeasure{MotorId = 2, Timestamp = new TimeSpan(10,20,00), ActualRevsRpm = 2800m, DifferenceRpm = null},
            new HydraulicMeasure{MotorId = 3, Timestamp = new TimeSpan(10,20,00), ActualPresureBar = 140, DifferenceBar= null},
            new ElectricMeasure{MotorId = 1, Timestamp = new TimeSpan(10,30,00), ActualCurrentA = 7.3m , DifferenceA = null },
            new CombustionMeasure{MotorId = 2, Timestamp = new TimeSpan(10,30,00), ActualRevsRpm = 2860m, DifferenceRpm = null},
            new HydraulicMeasure{MotorId = 3, Timestamp = new TimeSpan(10,30,00), ActualPresureBar = 145m, DifferenceBar= null},
            new ElectricMeasure{MotorId = 1, Timestamp = new TimeSpan(10,40,00), ActualCurrentA = 7.8m , DifferenceA = null },
            new CombustionMeasure{MotorId = 2, Timestamp = new TimeSpan(10,40,00), ActualRevsRpm = 2875m, DifferenceRpm = null},
            new HydraulicMeasure{MotorId = 3, Timestamp = new TimeSpan(10,40,00), ActualPresureBar = 159m, DifferenceBar= null},
            new ElectricMeasure{MotorId = 1, Timestamp = new TimeSpan(10,50,00), ActualCurrentA = 6.9m , DifferenceA = null },
            new CombustionMeasure{MotorId = 2, Timestamp = new TimeSpan(10,50,00), ActualRevsRpm = 2790m, DifferenceRpm = null},
            new HydraulicMeasure{MotorId = 3, Timestamp = new TimeSpan(10,50,00), ActualPresureBar = 160m, DifferenceBar= null},
            new ElectricMeasure{MotorId = 1, Timestamp = new TimeSpan(11,00,00), ActualCurrentA = 7.0m , DifferenceA = null },
            new CombustionMeasure{MotorId = 2, Timestamp = new TimeSpan(11,00,00), ActualRevsRpm = 2900m, DifferenceRpm = null},
            new HydraulicMeasure{MotorId = 3, Timestamp = new TimeSpan(11,00,00), ActualPresureBar = 139m, DifferenceBar= null}

            };
            Measure.ForEach(s => context.Measures.Add(s));
            context.SaveChanges();
        }



    }
}