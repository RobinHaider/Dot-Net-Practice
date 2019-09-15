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
    public partial class UpdateStudentUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDepartments();
            }

            int id = Convert.ToInt32(Request.QueryString["id"]);

            if (id > 0)
            {
                StudentWithDepartmentVM student = manager.GetStudentById(id);

                if (student == null)
                {
                    Response.Redirect("~/UI/UpdateStudentUI.aspx");
                }
                else
                {
                    messageLabel.Text = "";
                    idHiddenField.Value = student.StudentId.ToString();
                    registationNoTextBox.Text = student.RegNo;
                    nameTextBox.Text = student.StudentName;
                    contactTextBox.Text = student.ContactNo;
                    emailTextBox.Text = student.Email;
                    departmentDropDownList.SelectedValue = student.DeptId.ToString();
                }

            }
        }

        StudentManager manager = new StudentManager();
        DepartmentManager departmentManager = new DepartmentManager();

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string regNo = registationNoTextBox.Text;

            StudentWithDepartmentVM student = manager.GetStudent(regNo);

            if (student == null)
            {
                messageLabel.Text = "Student not found";
                nameTextBox.Text = String.Empty;
                contactTextBox.Text = String.Empty; ;
                emailTextBox.Text = String.Empty;
                LoadDepartments();
            }
            else
            {
                messageLabel.Text = "Student found";
                idHiddenField.Value = student.StudentId.ToString();
                nameTextBox.Text = student.StudentName;
                contactTextBox.Text = student.ContactNo;
                emailTextBox.Text = student.Email;
                departmentDropDownList.SelectedValue = student.DeptId.ToString();
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
            astudent.DepartmentId = Convert.ToInt32(departmentDropDownList.SelectedValue);



            string updateMessage = manager.Update(astudent);
            messageLabel.Text = updateMessage;

        }

        private void LoadDepartments()
        {
            List<Department> departments = departmentManager.GetAllDepartments();

            departmentDropDownList.DataTextField = "Name";
            departmentDropDownList.DataValueField = "Id";
            departmentDropDownList.DataSource = departments;
            departmentDropDownList.DataBind();
        }


    }
}