<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="person.aspx.cs" Inherits="nabane.person" %>

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
							<h2>Nærum banen - Backend Handin 5</h2>
							<h2>Nærumbanen – eller Jægersborg-Nærum Jernbane</h2>
							<p>er en lokalbane, oprindeligt mellem Lyngby og Vedbæk, nu mellem Jægersborg og Nærum.</p>
							<nav class="space">
                            <ul class="my-row">
                                <li><a href="index.aspx">Index</a></li>
                                <li><a href="person.aspx">Persons</a></li>
                                <li><a href="binary.aspx">Binary text file</a></li>
                            </ul>
                        </nav>
						</header>
						<div class="content">
                            <h2>Create a new Person</h2>
							<table>
                                <tr>
                                    <td>ID: </td><td><asp:TextBox ID="TextBox_id" runat="server"></asp:TextBox></td><td></td>
                                </tr>
                                <tr>
                                    <td>Name: </td><td><asp:TextBox ID="TextBox_name" runat="server"></asp:TextBox></td><td></td>
                                </tr>
                                <tr>
                                    <td>Age: </td><td><asp:TextBox ID="TextBox_age" runat="server"></asp:TextBox></td><td></td>
                                </tr>
                                <tr>
                                    <td>Email: </td><td><asp:TextBox ID="TextBox_email" runat="server"></asp:TextBox></td><td></td>
                                </tr>
                                <tr>
                                    <td>Keycard number: </td><td><asp:TextBox ID="TextBox_keycard" runat="server"></asp:TextBox></td><td></td>
                                </tr>
                                <tr>
                                    <td><asp:Button ID="Button_createPerson" runat="server" Text="Create" OnClick="Button_createPerson_Click" /></td><td></td><td></td>
                                </tr>
                                <tr>
                                    <td><asp:Label ID="Label_createError" ForeColor="Red" Font-Bold="true" runat="server" Text=""></asp:Label></td><td></td><td></td>
                                </tr>
							</table>
                            <table>
                                <tr>
                                    <td><asp:Button ID="Button_createBinary" runat="server" Text="Create Binary Text" OnClick="Button_createBinary_Click" /></td><td></td><td></td>
                                </tr>
                            </table>

                            <asp:ListBox ID="ListBox_show" runat="server" Height="300px"></asp:ListBox>

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
