using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace UniversityWebApp.Gateway
{
    public class StudentGateway
    {
        
        string connectionString = "Server=ROBINHAIDER; Database=UniversityDB; Integrated Security=True";

        public int Save(Student student){
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Students VALUES('" + student.RegistaionNo + "','" + student.Name + "','" + student.Contact + "','" + student.Email + "','" + student.Department + "')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public int Update(Student astudent)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "UPDATE Students SET Name='" + astudent.Name + "', ContactNo='" + astudent.Contact + "', Email='" + astudent.Email + "', Department='" + astudent.Department + "' WHERE Id=" + astudent.Id;

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();

            connection.Close();
            return rowAffected;
        }

        public Student GetStudent(string regNo)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Students WHERE RegistationNo='" + regNo + "'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            Student astudent = null;

            if (reader.HasRows)
            {
                reader.Read();
                astudent = new Student();

                astudent.Id = Convert.ToInt32(reader["Id"]);
                astudent.RegistaionNo = reader["RegistationNo"].ToString();
                astudent.Name = reader["Name"].ToString();
                astudent.Contact = reader["ContactNo"].ToString();
                astudent.Email = reader["Email"].ToString();
                astudent.Department = reader["Department"].ToString();
            }

            reader.Close();
            connection.Close();

            return astudent;
        }

        public List<Student> PopulateStudentList(){

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Students";

            SqlCommand command = new SqlCommand(query,connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Student> students = new List<Student>();

            while (reader.Read())
            {
                Student student = new Student();

                student.Id = Convert.ToInt32(reader["Id"]);
                student.RegistaionNo = reader["RegistationNo"].ToString();
                student.Name = reader["Name"].ToString();
                student.Contact = reader["ContactNo"].ToString();
                student.Email = reader["Email"].ToString();
                student.Department = reader["Department"].ToString();

                students.Add(student);
            }

            reader.Close();
            connection.Close();

            return students;
        }

        public bool DoesRegNoExist(string regNo)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Students WHERE RegistationNo='"+ regNo +"'";

            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            bool hasRows = reader.HasRows;

            reader.Close();
            connection.Close();

            return hasRows;
        }
    }
}