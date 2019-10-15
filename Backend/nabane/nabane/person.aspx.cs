using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nabane
{
    public partial class person : System.Web.UI.Page
    {
        ArrayList arr = new ArrayList();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["myPerson"] == null)
            {
                ListBox_showPerson.Items.Add("Empty");
            }
            else
            {
                arr = (ArrayList)Session["myPerson"];
                ListBox_showPerson.Items.Clear();
                for (int i = 0; i < arr.Count; i++)
                {
                    ListBox_showPerson.Items.Add(arr[i].ToString());
                }
            }
        }

        protected void Button_createPerson_Click(object sender, EventArgs e)
        {
            if(TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_age.Text == "" || TextBox_email.Text == "")
            {
                Label_createError.Text = "Complete the typing!!";
            }
            else
            {
                Label_createError.Text = "";
                int id = Convert.ToInt32(TextBox_id.Text);
                string name = TextBox_name.Text;
                int age = Convert.ToInt32(TextBox_age.Text);
                string email = TextBox_email.Text;
                bool admin = Convert.ToBoolean(DropDownList_admin.SelectedValue);
                bool train = Convert.ToBoolean(DropDownList_train.SelectedValue);
                Person person = new Person(id, name, age, email, admin, train);
                arr.Add(person);
                Session["myPerson"] = arr;
            }
           
        }

        protected void Button_showPerson_Click(object sender, EventArgs e)
        {
            ListBox_showPerson.Items.Clear();
            arr = (ArrayList)Session["myPerson"];

            if (arr == null)
            {
                ListBox_showPerson.Items.Add("Empty");
            }
            else
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    ListBox_showPerson.Items.Add(arr[i].ToString());
                }
            }

           
        }
    }
}