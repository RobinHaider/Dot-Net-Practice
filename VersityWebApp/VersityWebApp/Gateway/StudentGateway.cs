using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using VersityWebApp.Model;
using System.Web.Configuration;

namespace VersityWebApp.Gateway
{
    public class StudentGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString;

        public int Save(Student student)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Students VALUES('" + student.RegistaionNo + "','" + student.Name + "','" + student.Contact + "','" + student.Email + "','" + student.DepartmentId + "')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public int Update(Student astudent)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "UPDATE Students SET Name='" + astudent.Name + "', ContactNo='" + astudent.Contact + "', Email='" + astudent.Email + "', DepartmentId='" + astudent.DepartmentId + "' WHERE Id=" + astudent.Id;

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();

            connection.Close();
            return rowAffected;
        }

        internal StudentWithDepartmentVM GetStudentById(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM StudentWithDepartment WHERE StudentId=" + id;
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            StudentWithDepartmentVM student = null;

            if (reader.HasRows)
            {
                reader.Read();
                student = new StudentWithDepartmentVM();

                student.StudentId = Convert.ToInt32(reader["StudentId"]);
                student.RegNo = reader["RegNo"].ToString();
                student.StudentName = reader["StudentName"].ToString();
                student.ContactNo = reader["ContactNo"].ToString();
                student.Email = reader["Email"].ToString();
                student.DeptId = Convert.ToInt32(reader["DeptId"]);
                student.DeptCode = reader["DeptCode"].ToString();
                student.DeptName = reader["DeptName"].ToString();
            }

            reader.Close();
            connection.Close();

            return student;
        }

        internal void DeleteStudent(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "DELETE FROM Students WHERE Id=" + id;

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public StudentWithDepartmentVM GetStudent(string regNo)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM StudentWithDepartment WHERE RegNo='" + regNo + "'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            StudentWithDepartmentVM student = null;

            if (reader.HasRows)
            {
                reader.Read();
                student = new StudentWithDepartmentVM();

                student.StudentId = Convert.ToInt32(reader["StudentId"]);
                student.RegNo = reader["RegNo"].ToString();
                student.StudentName = reader["StudentName"].ToString();
                student.ContactNo = reader["ContactNo"].ToString();
                student.Email = reader["Email"].ToString();
                student.DeptId = Convert.ToInt32(reader["DeptId"]);
                student.DeptCode = reader["DeptCode"].ToString();
                student.DeptName = reader["DeptName"].ToString();
            }

            reader.Close();
            connection.Close();

            return student;
        }

        public List<StudentWithDepartmentVM> PopulateStudentList()
        {

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM StudentWithDepartment";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<StudentWithDepartmentVM> students = new List<StudentWithDepartmentVM>();

            while (reader.Read())
            {
                StudentWithDepartmentVM student = new StudentWithDepartmentVM();

                student.StudentId = Convert.ToInt32(reader["StudentId"]);
                student.RegNo = reader["RegNo"].ToString();
                student.StudentName = reader["StudentName"].ToString();
                student.ContactNo = reader["ContactNo"].ToString();
                student.Email = reader["Email"].ToString();
                student.DeptId = Convert.ToInt32(reader["DeptId"]);
                student.DeptCode = reader["DeptCode"].ToString();
                student.DeptName = reader["DeptName"].ToString();

                students.Add(student);
            }

            reader.Close();
            connection.Close();

            return students;
        }

        public bool DoesRegNoExist(string regNo)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Students WHERE RegistationNo='" + regNo + "'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            bool hasRows = reader.HasRows;

            reader.Close();
            connection.Close();

            return hasRows;
        }
    }
}