<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="create.aspx.cs" Inherits="nabane2.create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    	<title>Nærum banen</title>
		<meta charset="utf-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1" />
		<link rel="stylesheet" href="assets/css/main.css" />
</head>
<body>
    <form id="form1" runat="server">
        <!-- Main -->
			<section id="main">
				<div class="inner">

				<!-- One -->
					<section id="one" class="wrapper style1">

						<div class="image fit flush">
							<img src="images/narum.png" alt="narum banen" />
						</div>
						<header class="special">
							<h2>Nærum banen - Backend Handin 2</h2>
							<h2>Nærumbanen – eller Jægersborg-Nærum Jernbane</h2>
							<p>er en lokalbane, oprindeligt mellem Lyngby og Vedbæk, nu mellem Jægersborg og Nærum.</p>
							<nav class="space">
                            <ul class="my-row">
                                <li><a href="index.aspx">Index</a></li>
                                <li><a href="create.aspx">Create</a></li>
                                <li><a href="about.aspx">About</a></li>
                            </ul>
                        </nav>
						</header>
						<div class="content">
							<h2>Create a new timetable</h2>
                            <table>
                                <tr>
                                    <td>Station </td><td><asp:DropDownList ID="DropDownList_station" runat="server" DataSourceID="SqlDataSource_station" DataTextField="station_name" DataValueField="station_id"></asp:DropDownList></td><td></td>
                                </tr>
                                <tr>
                                    <td>Direction </td><td><asp:DropDownList ID="DropDownList_direction" runat="server" DataSourceID="SqlDataSource_direction" DataTextField="direction_name" DataValueField="direction_id"></asp:DropDownList></td><td></td>
                                </tr>
                                <tr>
                                    <td>Tid </td><td><asp:TextBox ID="TextBox_time" runat="server"></asp:TextBox> example: 00:00:00</td><td></td>
                                </tr>
                                <tr>
                                    <td>Forsinket </td><td><asp:TextBox ID="TextBox_delayed" runat="server"></asp:TextBox> example: 0 (0 minutes) </td><td></td>
                                </tr>
                                <tr>
                                    <td>Aflyst </td><td><asp:DropDownList ID="DropDownList_cancelled" runat="server"><asp:ListItem Selected="True" Value="false">No</asp:ListItem>
    <asp:ListItem Value="true">Yes</asp:ListItem></asp:DropDownList></td><td></td>
                                </tr>
                                <tr>
                                    <td><asp:Button ID="Button_create" runat="server" Text="Create" OnClick="Button_create_Click" /></td><td></td><td></td>
                                </tr>
                            </table>
						</div>
					</section>
				</div>
			</section>

        <asp:SqlDataSource ID="SqlDataSource_station" runat="server" ConnectionString="<%$ ConnectionStrings:PigConnectionString %>" SelectCommand="SELECT * FROM [Station]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource_direction" runat="server" ConnectionString="<%$ ConnectionStrings:PigConnectionString %>" SelectCommand="SELECT * FROM [Direction]"></asp:SqlDataSource>

		<!-- Scripts -->
			<script src="assets/js/jquery.min.js"></script>
			<script src="assets/js/jquery.poptrox.min.js"></script>
			<script src="assets/js/skel.min.js"></script>
			<script src="assets/js/util.js"></script>
			<script src="assets/js/main.js"></script>
    </form>
</body>
</html>
