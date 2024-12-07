using System;
using System.Data.SqlClient;
using System.Configuration;

public class DatabaseHelper
{
    // Get connection string from App.config
    private static string connectionString = ConfigurationManager.ConnectionStrings["RestaurantBillingDB"].ConnectionString;

    // Method to get SQL connection
    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

    // Method to execute SQL queries (INSERT, UPDATE, DELETE)
    public static void ExecuteQuery(string query)
    {
        using (SqlConnection conn = GetConnection())
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
    }

    // Method to execute SELECT queries and return data
    public static SqlDataReader ExecuteReader(string query)
    {
        SqlConnection conn = GetConnection();
        conn.Open();
        SqlCommand cmd = new SqlCommand(query, conn);
        return cmd.ExecuteReader();
    }
}
