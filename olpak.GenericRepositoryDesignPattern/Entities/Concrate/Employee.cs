using olpak.GenericRepositoryDesignPattern.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olpak.GenericRepositoryDesignPattern.Entities.Concrate
{
    public class Employee:IEntitycs
    {
        public Employee()
        {
            
        }
        public Employee(int employeeId, string name, int lastName)
        {
            EmployeeId = employeeId;
            Name = name;
            LastName = lastName;
        }

        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public int LastName { get; set; }
    }
}
