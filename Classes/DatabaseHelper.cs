using System;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SinemaBiletOtomasyonu.classes
{
    internal class DatabaseHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["CinemaDB"].ConnectionString;

        // Execute SELECT queries and return DataTable
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database query error: " + ex.Message);
            }

            return dt;
        }

        // Execute INSERT, UPDATE, DELETE and return affected rows
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        conn.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database execution error: " + ex.Message);
            }

            return rowsAffected;
        }

        // Execute and return single value (COUNT, SUM, etc.)
        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object result = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        conn.Open();
                        result = cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database scalar error: " + ex.Message);
            }

            return result;
        }

        // Test connection
        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message, "Connection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);    
                return false;
            }
        }
    }
}
