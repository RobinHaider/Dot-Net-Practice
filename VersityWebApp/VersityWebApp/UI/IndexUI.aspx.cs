using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VersityWebApp.BLL;
using VersityWebApp.Model;

namespace VersityWebApp.UI
{
    public partial class IndexUI : System.Web.UI.Page
    {
        StudentManager manager = new StudentManager();
        DepartmentManager departmentManager = new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateStudentList();
                LoadDepartments();
            }
            
        }

        private void LoadDepartments()
        {
            List<Department> departments = departmentManager.GetAllDepartments();

            departmentDropDownList.DataTextField = "Name";
            departmentDropDownList.DataValueField = "Id";
            departmentDropDownList.DataSource = departments;
            departmentDropDownList.DataBind();
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.RegistaionNo = registationNoTextBox.Text;
            student.Name = nameTextBox.Text;
            student.Contact = contactTextBox.Text;
            student.Email = emailTextBox.Text;
            student.DepartmentId = Convert.ToInt32(departmentDropDownList.SelectedValue);

            messageLabel.Text = manager.Save(student);


            PopulateStudentList();
            EmptyTextbox();
        }

        private void PopulateStudentList()
        {
            List<StudentWithDepartmentVM> students = manager.PopulateStudentList();
            studentsGridView.DataSource = students;
            studentsGridView.DataBind();
        }

        private void EmptyTextbox()
        {
            registationNoTextBox.Text = String.Empty;
            nameTextBox.Text = String.Empty;
            contactTextBox.Text = String.Empty; ;
            emailTextBox.Text = String.Empty;
            LoadDepartments();
        }
    }
}