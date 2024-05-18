using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olpak.adonet
{
	public class Employee
	{
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }


		public override string ToString()
		{
			return $"{EmployeeId,-5}{FirstName,-10}{LastName,-10}";
		}
	}
}
