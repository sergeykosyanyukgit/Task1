using System;
using Task1.Interfaces;
using System.Data.SqlClient;
using System.Data;

namespace Task1.Controllers
{
    public class DBController: IDBController
    {
        private SqlConnection Connection { get; set; }
        public DBController()
        {
            var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sergey\source\repos\Task1\Database1.mdf;Integrated Security=True");
            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    Connection = connection;
                }
            }

        }
        public void FixAllDateTimes(string ID_Point, string ID_Type)
        {
            try
            {
                var command = new SqlCommand("FixAllDateTimes", Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID_Point", int.Parse(ID_Point));
                command.Parameters.AddWithValue("@ID_Type", int.Parse(ID_Type));
                var reader = command.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
