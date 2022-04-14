using System;
using System.Data.SqlClient;

namespace OOP.ADONET
{
    public static class RDMS
    {
        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static int SqlNonQuery(SqlCommand cmd)
        {
           
            try
            {
                using (var conn= new SqlConnection(connectionString))
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
    }
}
