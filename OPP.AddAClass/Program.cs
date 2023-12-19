using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP.AddAClass
{

    class Program
    {
        static void Main(string[] args)
        {
           /* var list=new List<Employee>();

            Employee employee = new Employee()
            {

                Firstname = "ahmet",
                LastName = "mila",
                Age = 0
            };


            Employee employee2 = new Employee("pilmik", "top", 21);

            Employee employee3 = new Employee("derek", "terl", 25);

            list.Add(employee);
            list.Add(employee2);
            list.Add(employee3);


            foreach (var item in list)
            {

                Console.WriteLine(item);
            }*/

            var employee=new Employee();

            employee.Add(new Employee("ahmet","mansun",12));
            employee.AddRange(
                new Employee("fansa","fanas",23),
                new Employee("yuma","eil",56));
            



            var list=employee.GetEmployees();
            foreach (var e in list)
            {
                Console.WriteLine(e);


            }


            Console.WriteLine(employee);


             
            Console.ReadKey();
        }
    }
}
