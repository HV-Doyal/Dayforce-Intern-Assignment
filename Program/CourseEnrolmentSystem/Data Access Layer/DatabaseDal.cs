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
        //private static readonly string _connectionString = @"data source=DayforcefMibEuW;initial catalog=master;trusted_connection=true";
        private static readonly string _connectionString = @"data source=HVD-PC;initial catalog=master;trusted_connection=true";

        public static List<string> GetCourse(int points)
        {
            List<string> courseAvailable = new List<string>();
            string query = $"Select Course From Course Where (NumberOfSeats > 0) AND (MinNumberOfPoints <= {points})";
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

        public static void InsertStudent(string firstName, string lastName, string email, string contactNumber, string address, string course, double fees)
        {
            string query = $"Insert Into Student (FirstName, LastName, Email, Address, ContactNumber, Course, CalculatedFees)" +
                $"Values ('{firstName}', '{lastName}', '{email}', '{address}', {int.Parse(contactNumber)}, '{course}', {fees})";
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                SqlCommand cm = new SqlCommand(query, con);
                con.Open();
                cm.ExecuteNonQuery();
                MessageBox.Show("Student added to database");
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not insert student in database" + e.Message);
            }
        }

        public static int GetFulltimeCost(string course)
        {
            int fulltimeCost = 0;
            string query = $"Select FulltimeCost From Course Where (Course = '{course}')";
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
                    fulltimeCost = (int)sdr["FulltimeCost"];
                }
                con.Close();
                return fulltimeCost;

            }
            catch (Exception e)
            {
                MessageBox.Show("Could not get cost from database" + e.Message);
                return 0;
            }
        }
        public static int GetParttimeCost(string course)
        {
            int parttimeCost = 0;
            string query = $"Select ParttimeCost From Course Where (Course = '{course}')";
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
                    parttimeCost = (int)sdr["ParttimeCost"];
                }
                con.Close();
                return parttimeCost;

            }
            catch (Exception e)
            {
                MessageBox.Show("Could not get cost from database" + e.Message);
                return 0;
            }
        }
    }
}
