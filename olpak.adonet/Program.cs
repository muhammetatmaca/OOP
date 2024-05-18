using System.Data;
using System.Data.SqlClient;
using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;

namespace olpak.adonet
{
	class Program
	{
		static void Main(string[] args)
		{
			var cmd = new SqlCommand("SELECT * FROM Table_1");
			var ds=RDMS.SqlReader(cmd);
            Console.WriteLine(ds);
            Console.ReadKey();
		}



		private static void update()
		{
			var employee = new Employee()
			{
				FirstName = "can",
				LastName = "ban",
				EmployeeId = 12
			};

			
					
					var cmd = new SqlCommand("UPDATE Table_1 SET adi=@FirstName, soyadi=@LastName WHERE numarasi=@EmployeeId");
					cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
					cmd.Parameters.AddWithValue("@LastName", employee.LastName);
					cmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);

					var s=RDMS.SqlNonQuery(cmd);
					Console.WriteLine($"Etkilenen satır sayısı: {s}");
				
				
			
		}
		private static void reader()
		{
			List<Employee> _list = new List<Employee>();

			
			
			var cmd = new SqlCommand("SELECT numarasi,adi,soyadi FROM Table_1 ");
			var ds=RDMS.SqlReader(cmd);

			foreach (DataRow İtem in ds.Tables[0].Rows)
			{
				_list.Add(new Employee()
				{
					EmployeeId = int.Parse(İtem[0].ToString()),
					FirstName = İtem[1].ToString(),
					LastName = İtem[2].ToString()

				});
			}

			_list.ForEach(e => Console.WriteLine(e);
		}
		private static void create()
		{
			var employee = new Employee()
			{
				FirstName = "can",
				LastName = "Mahmutov",
				EmployeeId = 23
			};

			

			
					var cmd = new SqlCommand("INSERT INTO Table_1(adi,soyadi,numarasi) VALUES(@adi,@soyadi,@numarasi)");
					cmd.Parameters.AddWithValue("adi", employee.FirstName);
					cmd.Parameters.AddWithValue("soyadi", employee.LastName);
					cmd.Parameters.AddWithValue("numarasi", employee.EmployeeId);
					var s =RDMS.SqlNonQuery(cmd);
					Console.WriteLine($"Etkilenen satır sayısı: {s}");





		}
		private static void DELETE()
		{
			var employee = new Employee()
			{
				EmployeeId = 23
			};
				
				var cmd = new SqlCommand("DELETE FROM Table_1 WHERE numarasi=@EmployeeId");
				cmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);

				var s = RDMS.SqlNonQuery(cmd);
				Console.WriteLine($"Etkilenen satır sayısı: {s}");
				

		}
	}
}