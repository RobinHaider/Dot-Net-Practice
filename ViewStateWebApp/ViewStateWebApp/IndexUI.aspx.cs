using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateWebApp
{
    public partial class IndexUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            nameTextBox.Text = string.Empty;

            ViewState["name"] = name;
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            string name = ViewState["name"].ToString();
            displayNameLabel.Text = "Hello, " + name;
        }
    }
}