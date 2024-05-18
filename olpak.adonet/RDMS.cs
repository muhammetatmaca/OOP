using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml.Linq;

namespace olpak.adonet
{
	 
		public static class RDMS
		{
			private static string connetionstring = "Data Source=MUHAMMET\\MAMİSQL;Initial Catalog=adonetornek;Integrated Security=True;Connect Timeout=30;Encrypt=False";

			public static int SqlNonQuery(SqlCommand cmd)
			{

			try
			{
				using (var conn = new SqlConnection(connetionstring))
				{
					conn.Open();
					cmd.Connection = conn;
					return cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}

				

			

		}

			public static DataSet SqlReader(SqlCommand cmd)
		{
			try
			{
				using (var conn =new SqlConnection(connetionstring))
				{
					conn.Open();
					cmd.Connection = conn;
					var sda=new SqlDataAdapter(cmd);
					var ds = new DataSet();
					sda.Fill(ds);
					return ds;
					}

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
		

		
		}

		
}
