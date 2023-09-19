
namespace TechTest.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.Data;

    public class ApplicationDbContext : DbContext
    {

        public DbSet<Profiles> profiles { get; set; }
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Employee.db");
        }

        
        public List<Profiles> ExecuteQuery()
        {
            var query = "SELECT Profiles.ID,Profiles.Age,Profiles.Name,Departments.Designation FROM Profiles \r\nINNER JOIN  Departments ON Profiles.ID= Departments.empId ORDER BY Profiles.Age DESC LIMIT 1;";
       
            return profiles.FromSqlRaw(query).ToList();
        }
        public List<Profiles> ExecuteQueryMin()
        {
            var query = "SELECT Profiles.ID,Profiles.Age,Profiles.Name,Departments.Designation FROM Profiles \r\nINNER JOIN  Departments ON Profiles.ID= Departments.empId ORDER BY Profiles.Age asc LIMIT 1;";
            return profiles.FromSqlRaw(query).ToList();
        }
    }
}
