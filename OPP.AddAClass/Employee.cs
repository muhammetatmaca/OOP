using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace OPP.AddAClass
{
    class Employee

    {
        private string _firstName;
		private string _lastName;
        private List<Employee> _list;

      //  public List<Employee>  Employees=>_list;



		public string Firstname
		{
			get { return _firstName; }
            set { _firstName = value; }
		}

        public string LastName { get => _lastName; set => _lastName = value; }

        public int Age { get; set; }

        public Employee()
        {
            Console.WriteLine("yapilandirici metod desemm");
            _list = new List<Employee>();
        }

        public Employee(string firstname, string lastName, int age)
        {
            Firstname = firstname;
            LastName = lastName;
            Age = age;
            _list=new List<Employee>();
        }

        public override string ToString()
        {
            return $"{Firstname} {LastName} ({Age})";
        }

        public void Add(Employee employee)
        {

            _list.Add(employee);

        }

        public void AddRange(params Employee[] employees)
        {
           _list.AddRange(employees);
        }

        public List<Employee> GetEmployees() => _list;
        
    }
}
