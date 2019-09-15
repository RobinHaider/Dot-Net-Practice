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
    public partial class DeleteConfirmationUI : System.Web.UI.Page
    {
        StudentManager studentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);

            if (id == 0)
            {
                Response.Redirect("~/UI/IndexUI.aspx");
            }
            else
            {
                StudentWithDepartmentVM student = studentManager.GetStudentById(id);

                if (student == null)
                {
                    Response.Redirect("~/UI/IndexUI.aspx");
                }
                else
                {
                    nameLabel.Text = student.StudentName;
                    regNoLabel.Text = student.RegNo;
                    contactLabel.Text = student.ContactNo;
                    emailLabel.Text = student.Email;
                    departmentLabel.Text = student.DeptCode;
                    ViewState["Id"] = student.StudentId;
                }

            }
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/IndexUI.aspx");
        }

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ViewState["Id"]);

            studentManager.DeleteStudent(id);

            Response.Redirect("~/UI/IndexUI.aspx");
        }
    }
}