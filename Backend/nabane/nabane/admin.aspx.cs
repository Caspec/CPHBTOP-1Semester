using nabane.administrator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nabane
{
    public partial class admin : System.Web.UI.Page
    {
        ArrayList arr = new ArrayList();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["myPerson"] == null)
            {
                ListBox_showAdmin.Items.Add("Empty");
                ListBox_showTrain.Items.Add("Empty");
            }
            else
            {
                arr = (ArrayList)Session["myPerson"];
                ListBox_showAdmin.Items.Clear();
                ListBox_showTrain.Items.Clear();
                

                for (int i = 0; i < arr.Count; i++)
                {
                    if (((Person)arr[i]).Admin)
                    {
                        ListBox_showAdmin.Items.Add(arr[i].ToString());
                    }
                    else if(((Person)arr[i]).Train)
                    {
                        ListBox_showTrain.Items.Add(arr[i].ToString());
                    }  
                }
            }
        }

        protected void Button_showAdmin_Click(object sender, EventArgs e)
        {
            arr = (ArrayList)Session["myPerson"];
            ListBox_showAdmin.Items.Clear();
            Person p = new Person();

            if (arr == null)
            {
                ListBox_showAdmin.Items.Add("Empty");
                ListBox_showTrain.Items.Add("Empty");
            }
            else
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if(((Person)arr[i]).Admin)
                    {
                        ListBox_showAdmin.Items.Add(arr[i].ToString());
                    }
                }
            }
        }

        protected void Button_showTrain_Click(object sender, EventArgs e)
        {
            arr = (ArrayList)Session["myPerson"];
            ListBox_showAdmin.Items.Clear();

            if (arr == null)
            {
                ListBox_showAdmin.Items.Add("Empty");
                ListBox_showTrain.Items.Add("Empty");
            }
            else
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if(((Person)arr[i]).Train)
                    {
                        ListBox_showTrain.Items.Add(arr[i].ToString());
                    }

                }
            }
        }
    }
}