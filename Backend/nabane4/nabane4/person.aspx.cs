﻿using nabane.administrator;
using nabane.traindriver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace nabane
{
    public partial class person : System.Web.UI.Page
    {
        ArrayList arrPerson = new ArrayList();
        ArrayList txt = new ArrayList();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["myPerson"] == null)
            {
                ListBox_show.Items.Add("Empty");
            }
            else
            {
                arrPerson = (ArrayList)Session["myPerson"];
                ListBox_show.Items.Clear();
                for (int i = 0; i < arrPerson.Count; i++)
                {
                    ListBox_show.Items.Add(arrPerson[i].ToString());
                }
            }
        }

        protected void Button_createPerson_Click(object sender, EventArgs e)
        {

            if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_age.Text == "" || TextBox_email.Text == "" || TextBox_keycard.Text == "")
            {
                Label_createError.Text = "Complete the typing!!";
            }
            else
            {
                ListBox_show.Items.Clear();
                Label_createError.Text = "";
                int id = Convert.ToInt32(TextBox_id.Text);
                string name = TextBox_name.Text;
                int age = Convert.ToInt32(TextBox_age.Text);
                string email = TextBox_email.Text;
                int mykey = Convert.ToInt32(TextBox_keycard.Text);
                Keycard.Keycard key = new Keycard.Keycard(mykey); 
                Person person = new Person(id, name, age, email, key);
                arrPerson.Add(person);
                Session["myPerson"] = arrPerson;
               

                for (int i = 0; i < arrPerson.Count; i++)
                {
                    ListBox_show.Items.Add(arrPerson[i].ToString());
                }
            }
        }

        protected void Button_createBinary_Click(object sender, EventArgs e)
        {
            txt = (ArrayList)Session["myPerson"];

            //FileStream filestream = new FileStream(Server.MapPath("~/persons.txt"), FileMode.OpenOrCreate, FileAccess.Write);
            //StreamWriter sw = new StreamWriter(filestream);
            //sw.Write("### persons start ###");
            //sw.Write("\n");
            //sw.Write("\n");
            //for (int i = 0; i < txt.Count; i++)
            //{
            //    sw.Write("person:");
            //    sw.Write("\n");
            //    sw.Write("id: " + ((Person)txt[i]).ID.ToString());
            //    sw.Write("\n");
            //    sw.Write("name: " + ((Person)txt[i]).Name.ToString());
            //    sw.Write("\n");
            //    sw.Write("age: " + ((Person)txt[i]).Age.ToString());
            //    sw.Write("\n");
            //    sw.Write("email: " + ((Person)txt[i]).Email.ToString());
            //    sw.Write("\n");
            //    sw.Write("keycard: " + ((Person)txt[i]).Mykey.ToString());
            //    sw.Write("\n");
            //    sw.Write("\n");
            //    sw.Flush();
            //}
            //sw.Write("### persons end ###");
            //sw.Close();

            // New Binary
            FileStream filestream = new FileStream(Server.MapPath("~/persons.ser"), FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryWriter bw = new BinaryWriter(filestream);
            for (int i = 0; i < txt.Count; i++)
            {
                bw.Write("id: " + ((Person)txt[i]).ID.ToString());
                bw.Write("name: " + ((Person)txt[i]).Name.ToString());
                bw.Write("age: " + ((Person)txt[i]).Age.ToString());
                bw.Write("email: " + ((Person)txt[i]).Email.ToString());
                bw.Write("keycard: " + ((Person)txt[i]).Mykey.ToString());
                bw.Write("\n");
                bw.Write("\n");
                bw.Flush();
            }
            bw.Close();
            filestream.Close();
        }

    }
}
