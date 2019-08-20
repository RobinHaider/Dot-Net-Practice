using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace UniversityWebApp
{
    public partial class UpdateStudentUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string connectionString = "Server=ROBINHAIDER; Database=UniversityDB; Integrated Security=True";

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string regNo = registationNoTextBox.Text;

            Student student = GetStudent(regNo);

            if(student == null)
            {
                messageLabel.Text = "Student not found";
            }
            else
            {
                messageLabel.Text = "Student found";
                nameTextBox.Text = student.Name;
                contactTextBox.Text = student.Contact;
                emailTextBox.Text = student.Email;
                departmentTextBox.Text = student.Department;
            }
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {

        }

        private Student GetStudent(string regNo)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Students WHERE RegistationNo='"+ regNo +"'";

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
    }
}