<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="nabane.admin" %>

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
                                <li><a href="person.aspx">Persons</a></li>
                                <li><a href="admin.aspx">Drivers and Admin workers</a></li>
                            </ul>
                        </nav>
						</header>
						<div class="content">
							<h2>Admin list</h2>
                            <table>
                                <tr>
                                    <td><asp:Button ID="Button_showAdmin" runat="server" Text="Show Administrators" OnClick="Button_showAdmin_Click" /></td><td></td><td></td>
                                </tr>
                            </table>
                            <asp:ListBox ID="ListBox_showAdmin" runat="server" Height="300px"></asp:ListBox>
                            <br />
                            <h2>Train driver list</h2>
                            <table>
                                <tr>
                                    <td><asp:Button ID="Button_showTrain" runat="server" Text="Show Train Drivers" OnClick="Button_showTrain_Click" /></td><td></td><td></td>
                                </tr>
                            </table>
                            <asp:ListBox ID="ListBox_showTrain" runat="server" Height="300px"></asp:ListBox>
						</div>
					</section>

				

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
