using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListBoxWebApp
{
    public partial class IndexUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            nameTextBox.Text = String.Empty;

            if(ViewState["Names"] == null)
            {
                List<string> nameList = new List<string>();
                nameList.Add(name);

                ViewState["Names"] = nameList;
            }
            else
            {
                List<string> nameList = (List<string>)ViewState["Names"];
                nameList.Add(name);

                ViewState["Names"] = nameList;
            }                 
        }

        protected void showAllButton_Click(object sender, EventArgs e)
        {
            List<string> nameList = (List<string>)ViewState["Names"];

            showAllNamesListBox.Items.Clear();

            foreach(var name in nameList)
            {
                showAllNamesListBox.Items.Add(name);
            }

            itemCountLabel.Text = nameList.Count.ToString();
        }
    }
}