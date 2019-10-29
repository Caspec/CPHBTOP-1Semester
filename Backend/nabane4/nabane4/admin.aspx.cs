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
        ArrayList arrAdmin = new ArrayList();
        ArrayList arrTrain = new ArrayList();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["myAdmin"] == null || Session["myDriver"] == null)
            {
                ListBox_showAdmin.Items.Add("Empty");
                ListBox_showTrain.Items.Add("Empty");
            }
            else
            {
                arrAdmin = (ArrayList)Session["myAdmin"];
                arrTrain = (ArrayList)Session["myDriver"];
                ListBox_showAdmin.Items.Clear();
                ListBox_showTrain.Items.Clear();
                for (int i = 0; i < arrAdmin.Count; i++)
                {
                    ListBox_showAdmin.Items.Add(arrAdmin[i].ToString());
                }
                for (int i = 0; i < arrTrain.Count; i++)
                {
                    ListBox_showTrain.Items.Add(arrTrain[i].ToString());
                }
            }
        }

        protected void Button_showAdmin_Click(object sender, EventArgs e)
        {
            arrAdmin = (ArrayList)Session["myAdmin"];
            ListBox_showAdmin.Items.Clear();

            if (arrAdmin == null)
            {
                ListBox_showAdmin.Items.Add("Empty");
                ListBox_showTrain.Items.Add("Empty");
            }
            else
            {
                    for (int i = 0; i < arrAdmin.Count; i++)
                    {
                        ListBox_showAdmin.Items.Add(arrAdmin[i].ToString());
                    }
            }
        }

        protected void Button_showTrain_Click(object sender, EventArgs e)
        {
            arrTrain = (ArrayList)Session["myDriver"];
            ListBox_showTrain.Items.Clear();

            if (arrTrain == null)
            {
                ListBox_showAdmin.Items.Add("Empty");
                ListBox_showTrain.Items.Add("Empty");
            }
            else
            {
                for (int i = 0; i < arrTrain.Count; i++)
                {
                    ListBox_showTrain.Items.Add(arrTrain[i].ToString());
                }
            }
        }
    }
}