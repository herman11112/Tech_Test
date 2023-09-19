using System.Xml.Linq;

namespace TechTest.Models
{
    public class Veggies : Food
    {
       // public string name;
        public Veggies() { /*name = string.Empty;*/ }
        public override List<string> getName()
        {
            List<string> VeggiesList = new List<string>();
            string ln;
            using (StreamReader file = new StreamReader("Veggies.txt"))
            {
                while ((ln = file.ReadLine()) != null)
                {
                    VeggiesList.Add(ln);

                }
                file.Close();
                return VeggiesList;
            }

        }
    }
}
