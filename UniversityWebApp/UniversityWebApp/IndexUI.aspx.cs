using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace UniversityWebApp
{
    public partial class IndexUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateStudentList();
        }

        string connectionString = "Server=ROBINHAIDER; Database=UniversityDB; Integrated Security=True";

        protected void registerButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.RegistaionNo = registationNoTextBox.Text;
            student.Name = nameTextBox.Text;
            student.Contact = contactTextBox.Text;
            student.Email = emailTextBox.Text;
            student.Department = departmentTextBox.Text;

            if (DoesRegNoExist(student.RegistaionNo))
            {
                messageLabel.Text = "RegNo already exist";
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionString);

                string query = "INSERT INTO Students VALUES('" + student.RegistaionNo + "','" + student.Name + "','" + student.Contact + "','" + student.Email + "','" + student.Department + "')";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                int rowAffected = command.ExecuteNonQuery();

                if (rowAffected > 0)
                {
                    messageLabel.Text = "Saved Successfully";
                }
                else
                {
                    messageLabel.Text = "Saving Failed";
                }
            }

            PopulateStudentList();
        }

        private bool DoesRegNoExist(string regNo)
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

        private void PopulateStudentList()
        {
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

            studentsGridView.DataSource = students;
            studentsGridView.DataBind();
        }
    }
}