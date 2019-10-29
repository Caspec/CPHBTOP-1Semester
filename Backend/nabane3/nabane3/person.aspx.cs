using nabane.administrator;
using nabane.traindriver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace nabane
{
    public partial class person : System.Web.UI.Page
    {
        ArrayList arrPerson = new ArrayList();
        ArrayList xml = new ArrayList();

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

        protected void Button_createXML_Click(object sender, EventArgs e)
        {
            xml = (ArrayList)Session["myPerson"];

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";

            using (XmlWriter writer = XmlWriter.Create(Server.MapPath("~/persons.xml"), settings))
            {
                writer.WriteStartElement("persons");

                for (int i = 0; i < xml.Count; i++)
                {
                    writer.WriteStartElement("person");
                    writer.WriteElementString("id", ((Person)xml[i]).ID.ToString());
                    writer.WriteElementString("name", ((Person)xml[i]).Name.ToString());
                    writer.WriteElementString("age", ((Person)xml[i]).Age.ToString());
                    writer.WriteElementString("email", ((Person)xml[i]).Email.ToString());
                    writer.WriteElementString("keycard", ((Person)xml[i]).Mykey.ToString());
                    writer.WriteEndElement();
                    writer.Flush();
                }
            }
        }
    }
}