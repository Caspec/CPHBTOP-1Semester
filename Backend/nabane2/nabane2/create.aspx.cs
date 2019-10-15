using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nabane2
{
    public partial class create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_create_Click(object sender, EventArgs e)
        {
            int stationID = Convert.ToInt32(DropDownList_station.SelectedValue);
            int directionID = Convert.ToInt32(DropDownList_direction.SelectedValue);
            string time = TextBox_time.Text;
            int delayed = Convert.ToInt32(TextBox_delayed.Text);
            bool cancelled = Convert.ToBoolean(DropDownList_cancelled.SelectedValue);

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PigConnectionString"].ConnectionString);
            connection.Open();

            SqlCommand com = new SqlCommand("INSERT INTO Depart (stationID, directionID, time, delayed, cancelled) VALUES (@stationID, @directionID, @time, @delayed, @cancelled)", connection);
            com.Parameters.Add(new SqlParameter("@stationID", stationID));
            com.Parameters.Add(new SqlParameter("@directionID", directionID));
            com.Parameters.Add(new SqlParameter("@time", time));
            com.Parameters.Add(new SqlParameter("@delayed", delayed));
            com.Parameters.Add(new SqlParameter("@cancelled", cancelled));
            com.ExecuteNonQuery();
            connection.Close();
            Response.Redirect("index.aspx");
        }
    }
}