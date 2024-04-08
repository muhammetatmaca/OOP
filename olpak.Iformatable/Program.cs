using System.Xml.Schema;

namespace olpak.Iformatable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString("D"));
            var list = new List<Employee>()
            {
                new Employee()
            {
                Id = 1,
                FirstName = "muhammet",
                LastName = "atmcaca",
                Tittle = "neymiş"
            },
                new Employee()
            {
                Id = 23,
                FirstName = "hakan",
                LastName = "Test",
                Tittle = "pirof"
            },
                new Employee()
            {
                Id = 34,
                FirstName = "holo",
                LastName = "kolo",
                Tittle = "doçent"
            },
                new Employee()
            {
                Id = 45,
                FirstName = "zolo",
                LastName = "moloo",
                Tittle = "yazarmıyım"
            }

        };

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString("FL"));
            }
            
            
            Console.ReadKey();
        }
    }



}