namespace TechTest.Models
{
    public class Profiles
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
    }
}
