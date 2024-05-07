using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "data source = SALEEJK ; database = model ; integrated security = SSPI ; TrustServerCertificate = true";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {

            SqlCommand command = new SqlCommand("select * from students", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string name = reader["name"].ToString();
                int age = Convert.ToInt32(reader["age"]);
                string address = reader["name"].ToString();
                Console.WriteLine($"id: {id},name: {name}");
            }
        }
    }




}

