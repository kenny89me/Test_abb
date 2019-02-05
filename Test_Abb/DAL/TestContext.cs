using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test_Abb.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Test_Abb.DAL
{
    public class TestContext : DbContext
    {
        public TestContext() : base("TestContext")
        {
        }

        public DbSet<ElectricMotor> ElectricMotors { get; set; }
        public DbSet<CombustionMotor> CombustionMotors { get; set; }
        public DbSet<HydraulicMotor> HydraulicMotors { get; set; }

        public DbSet<ElectricMeasure> ElectricMeasures { get; set; }
        public DbSet<CombustionMeasure> CombustionMeasures { get; set; }
        public DbSet<HydraulicMeasure> HydraulicMeasures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}