using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CourseEnrolmentSystem.Data_Access_Layer
{
    internal class DatabaseDal
    {
        private static readonly string _connectionString = @"data source=HVD-PC;initial catalog=master;trusted_connection=true";

        public static List<string> GetCourse(List<Subject> subjects, int points)
        {
            List<string> courseAvailable = new List<string>();
            string query = $"SELECT Course, Prerequisites FROM Course WHERE NumberOfSeats > 0 AND MinNumberOfPoints <= @points";

            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                using (SqlCommand cm = new SqlCommand(query, con))
                {
                    cm.Parameters.AddWithValue("@points", points);
                    con.Open();

                    using (SqlDataReader sdr = cm.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            string course = (string)sdr["Course"];
                            string prerequisites = sdr["Prerequisites"] as string;

                            // Check prerequisites against provided subjects and grades
                            if (CheckPrerequisites(subjects, prerequisites, con))
                            {
                                courseAvailable.Add(course);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not get courses from database: " + e.Message);
            }

            return courseAvailable;
        }

        private static bool CheckPrerequisites(List<Subject> subjects, string prerequisites, SqlConnection con)
        {
            if (string.IsNullOrEmpty(prerequisites))
            {
                return true; // No prerequisites specified
            }

            // Split prerequisites by comma, remove whitespace
            string[] requiredSubjects = prerequisites.Split(',')
                                                   .Select(p => p.Trim())
                                                   .ToArray();

            // Check if all required subjects are in the provided subjects list with at least grade 'D'
            foreach (string subjectName in requiredSubjects)
            {
                var matchingSubject = subjects.FirstOrDefault(s => s.Name == subjectName);
                if (matchingSubject == null || matchingSubject.Grade > 'D')
                {
                    return false; // Missing required subject or does not meet grade requirement
                }
            }

            return true; // All prerequisites are satisfied
        }

        public static void InsertStudent(string firstName, string lastName, string email, string contactNumber, string address, string course, double fees)
        {
            string query = "INSERT INTO Student (FirstName, LastName, Email, Address, ContactNumber, Course, CalculatedFees) " +
                           "VALUES (@firstName, @lastName, @Email, @Address, @ContactNumber, @Course, @CalculatedFees)";

            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                using (SqlCommand cm = new SqlCommand(query, con))
                {
                    cm.Parameters.AddWithValue("@firstName", firstName);
                    cm.Parameters.AddWithValue("@lastName", lastName);
                    cm.Parameters.AddWithValue("@Email", email);
                    cm.Parameters.AddWithValue("@Address", address);
                    cm.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    cm.Parameters.AddWithValue("@Course", course);
                    cm.Parameters.AddWithValue("@CalculatedFees", fees);

                    con.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Student added to database");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not insert student in database: " + e.Message);
            }
        }

        public static int GetFulltimeCost(string course)
        {
            return GetCourseCost(course, "FulltimeCost");
        }

        public static int GetParttimeCost(string course)
        {
            return GetCourseCost(course, "ParttimeCost");
        }

        private static int GetCourseCost(string course, string costType)
        {
            int cost = 0;
            string query = $"SELECT {costType} FROM Course WHERE Course = @course";

            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                using (SqlCommand cm = new SqlCommand(query, con))
                {
                    cm.Parameters.AddWithValue("@course", course);
                    con.Open();

                    using (SqlDataReader sdr = cm.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            cost = (int)sdr[costType];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not get cost from database: " + e.Message);
            }

            return cost;
        }
    }
}