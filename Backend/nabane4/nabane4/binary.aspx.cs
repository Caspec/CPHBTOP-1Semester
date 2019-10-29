using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nabane
{
    public partial class binary : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            FileStream filestream = new FileStream(Server.MapPath("~/persons.txt"), FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(filestream))
            {
                while (!reader.EndOfStream)
                {
                    Literal_binary.Text += reader.ReadLine() + "<br>";
                }
            }
            filestream.Close();
        }
    }
}