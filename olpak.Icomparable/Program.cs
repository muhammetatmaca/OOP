namespace olpak.Icomparable
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees= new List<Employee>() 
            {
                new Employee()
                {
                    Id = 1,
                    FullName="muhammet",
                    Salary=1222
                },

                 new Employee()
                {
                    Id = 2,
                    FullName="yununs",
                    Salary=65756
                },
                  new Employee()
                {
                    Id = 3,
                    FullName="kunus",
                    Salary=345
                },
                   new Employee()
                {
                    Id = 4,
                    FullName="cunus",
                    Salary=234
                },
            };

            employees.Sort();

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

        }
    }

}