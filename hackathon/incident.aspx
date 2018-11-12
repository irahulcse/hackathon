<%@ Page Language="C#" AutoEventWireup="true" CodeFile="incident.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  

	
	<meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<title> &mdash; Forest Fire</title>
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<meta name="description" content="Free HTML5 Website Template by FreeHTML5.co" />
	<meta name="keywords" content="free website templates, free html5, free template, free bootstrap, free website template, html5, css3, mobile first, responsive" />
	<meta name="author" content="FreeHTML5.co" />



  	<!-- Facebook and Twitter integration -->
	<meta property="og:title" content=""/>
	<meta property="og:image" content=""/>
	<meta property="og:url" content=""/>
	<meta property="og:site_name" content=""/>
	<meta property="og:description" content=""/>
	<meta name="twitter:title" content="" />
	<meta name="twitter:image" content="" />
	<meta name="twitter:url" content="" />
	<meta name="twitter:card" content="" />

	<link href="https://fonts.googleapis.com/css?family=Work+Sans:300,400,500,700,800" rel="stylesheet">
	
	<!-- Animate.css -->
	<link rel="stylesheet" href="css/animate.css">
	<!-- Icomoon Icon Fonts-->
	<link rel="stylesheet" href="css/icomoon.css">
	<!-- Bootstrap  -->
	<link rel="stylesheet" href="css/bootstrap.css">

	<!-- Magnific Popup -->
	<link rel="stylesheet" href="css/magnific-popup.css">

	<!-- Owl Carousel  -->
	<link rel="stylesheet" href="css/owl.carousel.min.css">
	<link rel="stylesheet" href="css/owl.theme.default.min.css">
	<!-- Flexslider  -->
	<link rel="stylesheet" href="css/flexslider.css">

	<!-- Theme style  -->
	<link rel="stylesheet" href="css/style.css">

	<!-- Modernizr JS -->
	<script src="js/modernizr-2.6.2.min.js"></script>
	<!-- FOR IE9 below -->
	<!--[if lt IE 9]>
	<script src="js/respond.min.js"></script>
	<![endif]-->

	</head>
	<body>
		
	<div class="fh5co-loader"></div>
	
	<div id="page">
	<nav class="fh5co-nav" role="navigation">
		<div class="top-menu">
			<div class="container">
				<div class="row">
					<div class="col-xs-2">
						<div id="fh5co-logo"><a href="index.aspx">Fiery_OK<span>.</span></a></div>
					</div>
					<div class="col-xs-10 text-right menu-1">
						<ul>
							<li><a href="index.aspx">Home</a></li>
							<li class="active"><a href="incident.aspx">Recent Incident</a></li>
							
							<li><a href="about.aspx">About</a></li>
							<li><a href="contact.aspx">Contact</a></li>
							<li class="btn-cta"><a href="login.aspx"><span>Login</span></a></li>
                            <li class="btn-cta"><a href="emergency.aspx"><span>Emergency</span></a></li>
							<li class="btn-cta"><a href="register.aspx"><span>Sign Up</span></a></li>
						</ul>
					</div>
				</div>
				
			</div>
		</div>
	</nav>
        
	<%--<aside id="fh5co-hero" class="js-fullheight">
		<div class="flexslider js-fullheight">
			<ul class="slides">
		   	<li style="background-image: url(images/img_bg_1.jpg);">
		   		
		   		<div class="container">
		   			<div class="col-md-10 col-md-offset-1 text-center js-fullheight slider-text">
		   				<div class="slider-text-inner desc">
		   					<h2 class="heading-section">RECENT INCIDENTS</h2>

<%--		   					<p class="fh5co-lead">Designed with <i class="icon-heart3"></i> by the fine folks at <a href="http://freehtml5.co" target="_blank">FreeHTML5.co</a></p>
		   				--%></div>
                           
		   			</div>
                       
		   		</div> 
                   <div>
            <div class="auto-style2">
               <%-- <span class="auto-style1"><strong>RECENT INCIDENTS</strong></span><strong><br class="auto-style1" />
               --%> </strong>
            </div>
                           </div>
                   </div>
                      
		   	</li>
		  	</ul>
	  	</div>
	</aside>
        </div>
       <div><form id="form1" runat="server">
        <div>
            <div class="auto-style2">
               <%-- <span class="auto-style1"><strong>RECENT INCIDENTS</strong></span><strong><br class="auto-style1" />--%>
                </strong>
            </div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=.\sqlexpress;Initial Catalog=hackathon;Integrated Security=True;Pooling=False" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [Id], [name], [mobile], [email], [image], [descr] FROM [emergency]"></asp:SqlDataSource>
            <br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" CellPadding="10" ForeColor="Black" GridLines="Horizontal" Height="800px" PageSize="4" Width="1000px" style="margin-left: 66px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellSpacing="5">
                <Columns>
                    <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" ControlStyle-Width="200px" >
<ControlStyle Width="200px"></ControlStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email"  ControlStyle-Width="200px">
<%--<ControlStyle Width="200px"></ControlStyle>--%>
                    </asp:BoundField>
                    <asp:BoundField DataField="mobile" HeaderText="Mobile" SortExpression="mobile"  ControlStyle-Width="200px">
<ControlStyle Width="200px"></ControlStyle>
                    </asp:BoundField>
                     <asp:TemplateField HeaderText="Image">
                   <ItemTemplate>
                       <asp:Image ID="image1" runat="server" Height="200px" Width="200px" ImageUrl='<%#"data:Image/png;base64,"+Convert.ToBase64String((Byte[])Eval("image")) %>' />
                   </ItemTemplate>
               </asp:TemplateField>
                    <asp:BoundField DataField="descr" HeaderText="Detail of Incident" SortExpression="descr" ControlStyle-Width="200px"  >
<ControlStyle Width="200px"></ControlStyle>
                    </asp:BoundField>
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
        </div>
    </form></div>
	
	<!-- jQuery -->
	<script src="js/jquery.min.js"></script>
	<!-- jQuery Easing -->
	<script src="js/jquery.easing.1.3.js"></script>
	<!-- Bootstrap -->
	<script src="js/bootstrap.min.js"></script>
	<!-- Waypoints -->
	<script src="js/jquery.waypoints.min.js"></script>
	<!-- Stellar Parallax -->
	<script src="js/jquery.stellar.min.js"></script>
	<!-- Carousel -->
	<script src="js/owl.carousel.min.js"></script>
	<!-- Flexslider -->
	<script src="js/jquery.flexslider-min.js"></script>
	<!-- countTo -->
	<script src="js/jquery.countTo.js"></script>
	<!-- Magnific Popup -->
	<script src="js/jquery.magnific-popup.min.js"></script>
	<script src="js/magnific-popup-options.js"></script>
	<!-- Main -->
	<script src="js/main.js"></script>

	



<%--    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            color: #FF0000;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>--%>


    <%--<form id="form1" runat="server">
        <div>
            <div class="auto-style2">
                <span class="auto-style1"><strong>RECENT INCIDENTS</strong></span><strong><br class="auto-style1" />
                </strong>
            </div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=.\sqlexpress;Initial Catalog=hackathon;Integrated Security=True;Pooling=False" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [Id], [name], [mobile], [email], [image], [descr] FROM [emergency]"></asp:SqlDataSource>
            <br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" CellPadding="5" ForeColor="#333333" GridLines="None" Height="800px" PageSize="8" Width="1000px" CellSpacing="2" style="margin-left: 66px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" ControlStyle-Width="200px" />
                    <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email"  ControlStyle-Width="200px"/>
                    <asp:BoundField DataField="mobile" HeaderText="Mobile" SortExpression="mobile"  ControlStyle-Width="200px"/>
                     <asp:TemplateField HeaderText="Image">
                   <ItemTemplate>
                       <asp:Image ID="image1" runat="server" Height="200px" Width="200px" ImageUrl='<%#"data:Image/png;base64,"+Convert.ToBase64String((Byte[])Eval("image")) %>' />
                   </ItemTemplate>
               </asp:TemplateField>
                    <asp:BoundField DataField="descr" HeaderText="Detail of Incident" SortExpression="descr" ControlStyle-Width="200px"  />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </div>
    </form>--%>
</body>
</html>
