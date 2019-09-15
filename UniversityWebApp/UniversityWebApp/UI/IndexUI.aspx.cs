using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using UniversityWebApp.BLL;

namespace UniversityWebApp.UI
{
    public partial class IndexUI : System.Web.UI.Page
    {
        StudentManager manager = new StudentManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateStudentList();
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.RegistaionNo = registationNoTextBox.Text;
            student.Name = nameTextBox.Text;
            student.Contact = contactTextBox.Text;
            student.Email = emailTextBox.Text;
            student.Department = departmentTextBox.Text;

            messageLabel.Text =  manager.Save(student);


            PopulateStudentList();
        }

        

        private void PopulateStudentList()
        {
            List<Student> students = manager.PopulateStudentList();
            studentsGridView.DataSource = students;
            studentsGridView.DataBind();
        }
    }
}