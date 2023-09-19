using System.Diagnostics.Metrics;

namespace TechTest.Models
{

    public class Fruit : Food
    {
        public string name;

        public Fruit() { 
        
            //name = string.Empty;
        }
        public override List<string> getName() {


            List<string> fruitList = new List<string>();
            string ln;
            using (StreamReader file = new StreamReader("Fruit.txt"))
            {
                while ((ln = file.ReadLine()) != null)
                {
                    fruitList.Add(ln);
                  
                }
                file.Close();
                return fruitList;
            }

        }

      
        
    }
}
