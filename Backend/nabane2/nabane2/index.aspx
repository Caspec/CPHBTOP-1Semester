<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="nabane2.index" %>

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
							<h2>Nærum banen - Backend Handin 3</h2>
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
						
					</section>

				            <h2 style="padding-left: 5px;">Show all timetables</h2>
                            <asp:Repeater ID="Repeater_show" runat="server" DataSourceID="SqlDataSource_show">
                                <ItemTemplate>
                                <div class="displaywares">
                                    <div>
                                        <p class="headline">Tid: <%#Eval ("time") %></p>
                                    </div>
                                    <div>
                                        <p>Station: <span class="bold"><%#Eval ("station_name") %></span></p>
                                    </div>
                                    <div>
                                       <p>Forsinket: <%#Eval("delayed").ToString().Length > 0 ? Eval("delayed") : "0" %> min</p>
                                    </div>
                                    <div>
                                       <p>Aflyst: <%#Eval ("cancelled") %></p>
                                    </div>
                                    <div>
                                        <a style="font-weight: 600;" href="edit.aspx?id=<%# Eval("id") %>">Edit timetable</a>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                        <asp:SqlDataSource ID="SqlDataSource_show" runat="server" ConnectionString="<%$ ConnectionStrings:PigConnectionString %>" SelectCommand="SELECT Depart.stationID, Depart.directionID, Depart.time, Depart.delayed, Depart.cancelled, Station.station_id, Station.station_name, Depart.id FROM Depart INNER JOIN Station ON Depart.stationID = Station.station_id ORDER BY Depart.time"></asp:SqlDataSource>
				</div>
			</section>

		

		<!-- Scripts -->
			<script src="assets/js/jquery.min.js"></script>
			<script src="assets/js/jquery.poptrox.min.js"></script>
			<script src="assets/js/skel.min.js"></script>
			<script src="assets/js/util.js"></script>
			<script src="assets/js/main.js"></script>
    </form>
</body>
</html>
