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
    public partial class edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);

                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PigConnectionString"].ConnectionString);
                connection.Open();

                string SQL = string.Format("SELECT Depart.stationID AS stationID, Depart.directionID AS directionID, Depart.time AS time, Depart.delayed AS delayed, Depart.cancelled AS cancelled, Depart.id AS id, Station.station_id, Station.station_name AS station_name, Direction.direction_id, Direction.direction_name AS direction_name FROM Depart INNER JOIN Station ON Depart.stationID = Station.station_id INNER JOIN Direction ON Depart.directionID = Direction.direction_id WHERE id=" + id + ";");

                SqlCommand command = new SqlCommand(SQL, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListItem listItemStation = new ListItem();
                    listItemStation.Value = reader["stationID"].ToString();
                    listItemStation.Text = reader["station_name"].ToString();
                    DropDownList_station.Items.Add(listItemStation);

                    ListItem listItemDirection = new ListItem();
                    listItemDirection.Value = reader["directionID"].ToString();
                    listItemDirection.Text = reader["direction_name"].ToString();
                    DropDownList_direction.Items.Add(listItemDirection);

                    TextBox_id.Text = reader["id"].ToString();
                    TextBox_time.Text = reader["time"].ToString();
                    TextBox_delayed.Text = reader["delayed"].ToString();
                    TextBox_cancelled.Text = reader["cancelled"].ToString();
                }

                reader.Close();
                connection.Close();
            }
        }

        protected void Button_Edit_Click(object sender, EventArgs e)
        {
            int stationID = Convert.ToInt32(DropDownList_station_choose.SelectedValue);
            int directionID = Convert.ToInt32(DropDownList_direction_choose.SelectedValue);
            int id = Convert.ToInt32(TextBox_id.Text);
            string time = TextBox_time.Text;
            int delayed = Convert.ToInt32(TextBox_delayed.Text);
            bool cancelled = Convert.ToBoolean(DropDownList_cancelled.SelectedValue);

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PigConnectionString"].ConnectionString);
            connection.Open();
            SqlCommand com = new SqlCommand("UPDATE Depart SET stationID = @stationID, directionID = @directionID, time = @time, delayed = @delayed, cancelled = @cancelled " + "WHERE id = @id", connection);
            com.Parameters.Add(new SqlParameter("@id", id));
            com.Parameters.Add(new SqlParameter("@stationID", stationID));
            com.Parameters.Add(new SqlParameter("@directionID", directionID));
            com.Parameters.Add(new SqlParameter("@time", time));
            com.Parameters.Add(new SqlParameter("@delayed", delayed));
            com.Parameters.Add(new SqlParameter("@cancelled", cancelled));
            com.ExecuteNonQuery();
            connection.Close();
            Response.Redirect("index.aspx");
            
        }

        protected void Button_Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox_id.Text);
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PigConnectionString"].ConnectionString);
            connection.Open();
            SqlCommand com = new SqlCommand("DELETE FROM Depart " + "WHERE id = @id", connection);
            com.Parameters.Add(new SqlParameter("@id", id));
            com.ExecuteNonQuery();
            connection.Close();
            Response.Redirect("index.aspx");
        }
    }
}