<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmdisease.aspx.cs" Inherits="frmemployee" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8" />
    <meta name="keywords" content="SMART HEALTH PREDICTION Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
	SmartPhone Compatible web template, free WebDesigns for Nokia, Samsung, LG, Sony Ericsson, Motorola web design" />
    <script>
        addEventListener("load", function () {
            setTimeout(hideURLbar, 0);
        }, false);

        function hideURLbar() {
            window.scrollTo(0, 1);
        }
    </script>
    <!-- Custom Theme files -->
    <link href="css/bootstrap.css" type="text/css" rel="stylesheet" media="all">
    <link href="css/style.css" type="text/css" rel="stylesheet" media="all">
    <!-- font-awesome icons -->
    <link href="css/font-awesome.min.css" rel="stylesheet">
    <!-- //Custom Theme files -->
    <!-- online-fonts -->
    <link href="//fonts.googleapis.com/css?family=Poppins:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i"
        rel="stylesheet">
    <link href="//fonts.googleapis.com/css?family=Lato:100,100i,300,300i,400,400i,700,700i,900,900i" rel="stylesheet">
</head>
<body>
      <div>
     <header id="home">
        <div class="container">
            <div class="header d-lg-flex justify-content-between align-items-center py-sm-3 py-2 px-sm-2 px-1">
                <!-- logo -->
                <div id="logo">
                    <h1><a href="index.html">SMART HEALTH PREDICTION</a></h1>
                </div>
                <!-- //logo -->
                <!-- nav -->
                <div class="nav_w3ls ml-lg-5">
                    <nav>
                        <label for="drop" class="toggle">Menu</label>
                        <input type="checkbox" id="drop" />
                        <ul class="menu">
                          <li><a href="frmupdatedoctor1.aspx">Profile</a></li>
                          
                           <li><a href="frmdisease.aspx">View  Disease</a></li>
                           <li><a href="frmappoint.aspx">Appointment</a></li>
                           
                            <li><a href="frmviewpatient.aspx">View  Patient</a></li>
                    <li><a href="frmaddfeed.aspx">Post Solution</a></li>
                            <li><a href="Default.aspx">Log Out</a></li>
                            <li class="nav-right-sty mt-lg-0 mt-sm-4 mt-3">
                             
                            </li>
                        </ul>
                    </nav>
                </div>
                <!-- //nav -->
            </div>
        </div>
    </header>
    <!-- //header -->
    <!-- inner banner -->
    <div class="inner-banner-w3ls d-flex flex-column justify-content-center align-items-center">
    </div>
    <!-- //inner banner -->
    <!-- breadcrumbs -->
    <nav aria-label="breadcrumb">
        <ol class="breadcrumb d-flex justify-content-center">
            <li class="breadcrumb-item">
                <h4>View Disease Record</h4>
            </li>
            
        </ol>
    </nav>
    <!-- //breadcrumbs -->
    <!-- login  -->
    <div class="modal-body align-w3">
        <form  runat="server" enctype="multipart/form-data" >

          <div class="form-group">
                                       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false"  HeaderStyle-BackColor="purple"
        HeaderStyle-ForeColor="white" RowStyle-Font-Bold="true" RowStyle-Font-Size="10pt" 
                                           RowStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center"
        RowStyle-ForeColor="green" Width="737px" OnRowCommand="GridView1_RowCommand" >
        <Columns>
           
           
          
          
           <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label20" runat="server" Text="Disease Name"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label21" runat="server" Text='<%#bind("dname") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label120" runat="server" Text="Symptoms"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label121" runat="server" Text='<%#Eval("sym") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label920" runat="server" Text="Type"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label921" runat="server" Text='<%#Eval("ftype") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

           
                                </Columns>
        <RowStyle Font-Bold="True" Font-Size="10pt" ForeColor="purple" />
        <HeaderStyle BackColor="#ff0000" ForeColor="White" />
    </asp:GridView> 
                             </div>

                            
            <div class="row sub-w3l my-3">
            </div>
           

            &nbsp;&nbsp;
                </form>
    </div>

    <!-- //login -->

    <!-- footer -->
   
    <!-- //footer -->
    <!-- copyright -->
    <div class="cpy-right text-center">
        <p class="text-wh">Online SMART HEALTH PREDICTION System
        </p>
    </div>
    <!-- //copyright -->
    <!-- move top icon -->
    <a href="#home" class="move-top text-center">
        <span class="fa fa-level-up" aria-hidden="true"></span>
    </a>
    </div>
    <script type="text/javascript">
        function readURL(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();

                reader.onload = function (e) {
                    $('#blah')
                        .attr('src', e.target.result)
                        .width(80)
                        .height(80);
                };

                reader.readAsDataURL(input.files[0]);
            }
        }
</script>

 
  <!-- Scripts -->
  <script type="text/javascript" src="js/libs/jquery-1.12.4.min.js"></script>
  <script type="text/javascript" src="js/libs/bootstrap.min.js"></script>
  <script type="text/javascript" src="js/libs/jquery.typer.min.js"></script>
  <script type="text/javascript" src="js/libs/jquery.justifiedGallery.min.js"></script>
  <script type="text/javascript" src="js/libs/jquery.magnific-popup.js"></script>
  <script type="text/javascript" src="js/libs/masonry.pkgd.js"></script>
  <script type="text/javascript" src="js/libs/owl.carousel.js"></script>
  <script type="text/javascript" src="js/libs/isotope.pkgd.min.js"></script>
  <script type="text/javascript" src="js/scripts.js"></script>
</body>
</html>
