namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class DBase : DbContext
    {
        // Your context has been configured to use a 'DBase' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DAL.DBase' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DBase' 
        // connection string in the application configuration file.
        public DBase()
            : base("name=DBase")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Emp> Emps { get; set; }
        public virtual DbSet<Deportament> Deportaments  { get; set; }
    }
    public class DBaseInit : DropCreateDatabaseIfModelChanges<DBase>
    {
        protected override void Seed(DBase context)
        {
            IList<Emp> emps = new List<Emp>();
            var dep = new Deportament { Description = "Test", Name = "Test" };
            emps.Add(new Emp
            {
                Age = 55,
                deportament = dep,
                login = "Login",
                password = "password",
                Name = "Vasyan",
                SurName = "Vasuanovich",
                Salary = 10000
            });
            context.Emps.AddRange(emps);
            context.SaveChanges();
        }
    }
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}