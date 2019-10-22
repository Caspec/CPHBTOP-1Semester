using nabane.administrator;
using nabane.traindriver;
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
        ArrayList arrAdmin = new ArrayList();
        ArrayList arrTrain = new ArrayList();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["myAdmin"] == null || Session["myDriver"] == null)
            {
                ListBox_showAdmin.Items.Add("Empty");
                ListBox_showDriver.Items.Add("Empty");
            }
            else
            {
                arrAdmin = (ArrayList)Session["myAdmin"];
                arrTrain = (ArrayList)Session["myDriver"];
                ListBox_showAdmin.Items.Clear();
                ListBox_showDriver.Items.Clear();
                for (int i = 0; i < arrAdmin.Count; i++)
                {
                    ListBox_showAdmin.Items.Add(arrAdmin[i].ToString());
                }
                for (int i = 0; i < arrTrain.Count; i++)
                {
                    ListBox_showDriver.Items.Add(arrTrain[i].ToString());
                }
            }
        }

        protected void Button_createPerson_Click(object sender, EventArgs e)
        {

            if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_age.Text == "" || TextBox_email.Text == "")
            {
                Label_createError.Text = "Complete the typing!!";
            }

            else if (Convert.ToBoolean(DropDownList_title.SelectedValue) == true)
            {
                Label_createError.Text = "";
                int id = Convert.ToInt32(TextBox_id.Text);
                string name = TextBox_name.Text;
                int age = Convert.ToInt32(TextBox_age.Text);
                string email = TextBox_email.Text;
                bool title = Convert.ToBoolean(DropDownList_title.SelectedValue);
                Administrator admin = new Administrator(id, name, age, email, title);
                arrAdmin.Add(admin);
                Session["myAdmin"] = arrAdmin;
            }
            else if (Convert.ToBoolean(DropDownList_title.SelectedValue) == false)
            {
                Label_createError.Text = "";
                int id = Convert.ToInt32(TextBox_id.Text);
                string name = TextBox_name.Text;
                int age = Convert.ToInt32(TextBox_age.Text);
                string email = TextBox_email.Text;
                bool title = Convert.ToBoolean(DropDownList_title.SelectedValue);
                Traindriver driver = new Traindriver(id, name, age, email, title, 123);
                arrTrain.Add(driver);
                Session["myDriver"] = arrTrain;
            }
        }

        protected void Button_showAdmin_Click(object sender, EventArgs e)
        {
            ListBox_showAdmin.Items.Clear();
            arrAdmin = (ArrayList)Session["myAdmin"];

            if (arrAdmin == null)
            {
                ListBox_showAdmin.Items.Add("Empty");
            }
            else
            {
                for (int i = 0; i < arrAdmin.Count; i++)
                {
                    ListBox_showAdmin.Items.Add(arrAdmin[i].ToString());
                }
            }
        }

        protected void Button_showDriver_Click(object sender, EventArgs e)
        {
            ListBox_showDriver.Items.Clear();
            arrTrain = (ArrayList)Session["myDriver"];

            if (arrTrain == null)
            {
                ListBox_showDriver.Items.Add("Empty");
            }
            else
            {
                for (int i = 0; i < arrTrain.Count; i++)
                {
                    ListBox_showDriver.Items.Add(arrTrain[i].ToString());
                }
            }
        }
    }
}