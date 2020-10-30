namespace ThucHanh.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using ThucHanh.Models;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("Employee")
        {
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

       
    }
}
