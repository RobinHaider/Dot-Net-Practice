using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using UniversityWebApp.BLL;
using UniversityWebApp.Model;

namespace UniversityWebApp.UI
{
    public partial class UpdateStudentUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        StudentManager manager = new StudentManager();
        
        protected void searchButton_Click(object sender, EventArgs e)
        {
            string regNo = registationNoTextBox.Text;

            Student student = manager.GetStudent(regNo);

            if(student == null)
            {
                messageLabel.Text = "Student not found";
                nameTextBox.Text = String.Empty;
                contactTextBox.Text = String.Empty;;
                emailTextBox.Text = String.Empty;
                departmentTextBox.Text = String.Empty;
            }
            else
            {
                messageLabel.Text = "Student found";
                idHiddenField.Value = student.Id.ToString();
                nameTextBox.Text = student.Name;
                contactTextBox.Text = student.Contact;
                emailTextBox.Text = student.Email;
                departmentTextBox.Text = student.Department;
            }
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            Student astudent = new Student();

            astudent.Id = Convert.ToInt32(idHiddenField.Value);
            astudent.RegistaionNo = registationNoTextBox.Text.ToString();
            astudent.Name = nameTextBox.Text.ToString();
            astudent.Contact = contactTextBox.Text.ToString();
            astudent.Email = emailTextBox.Text.ToString();
            astudent.Department = departmentTextBox.Text.ToString();

           

            string updateMessage = manager.Update(astudent);
            messageLabel.Text = updateMessage;
        }

        
    }
}