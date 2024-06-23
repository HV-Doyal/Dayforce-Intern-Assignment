using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseEnrolmentSystem.Data_Access_Layer
{
    internal class DatabaseDal
    {
        private static readonly string _connectionString = @"data source=DayforcefMibEuW;initial catalog=master;trusted_connection=true";
        public static List<string> GetCourse(int points)
        {
            List<string> courseAvailable = new List<string>();
            string query = $"Select * From Course Where (NumberOfSeats > 0) AND (MinNumberOfPoints <= {points})";
            try
            {
                // Creating Connection  
                SqlConnection con = new SqlConnection(_connectionString);
                SqlCommand cm = new SqlCommand(query, con);  
                con.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                
                while (sdr.Read())
                {
                    courseAvailable.Add((string)sdr["Course"]);
                }
                con.Close();
                return courseAvailable;

            }
            catch (Exception e)
            {
                MessageBox.Show("Could not get courses from database" + e.Message);
                return courseAvailable;
            }
        }
    }
}
