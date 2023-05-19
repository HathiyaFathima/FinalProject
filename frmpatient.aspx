﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmpatient.aspx.cs" Inherits="frmemployee" %>

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
                           
                            
                           
                           
                            
                           
                            <li><a href="Default.aspx">Back>></a></li>
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
                <h4>New Patient Registration</h4>
            </li>
            
        </ol>
    </nav>
    <!-- //breadcrumbs -->
    <!-- login  -->
     <section class="single_grid_w3_main align-w3-abt" id="about" style="     padding-top: 2px;">
        <div class="container">
    <div class="container">
        <form  runat="server" enctype="multipart/form-data" >
               <div class="row sub-w3l my-3">
                <div class="col-md-3">
                    <label for="dop">Patient Name</label>
                                                  <asp:TextBox ID="TextBox2" runat="server"  style="width: 200px; height: 40px;" class="form-control" required></asp:TextBox>
                </div>
                <div class="col-md-3">
                <label for="dop">Gender:</label>
                    <asp:DropDownList ID="DropDownList6" runat="server"  class="form-control"   style="width: 200px;height: 40px" required>
                                            <asp:ListItem Selected="True">Select</asp:ListItem>
                                            <asp:ListItem>Male</asp:ListItem>
                                            <asp:ListItem>Female</asp:ListItem>
                                            </asp:DropDownList>	
                </div>
               
            </div>
             <div class="row sub-w3l my-3">
                <div class="col-md-3">
                    <label for="dop">Address:</label>
                                                  <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" style="    width: 300px; height: 80px;" class="form-control" required></asp:TextBox>
                </div>
               
               
            </div>
            <div class="row sub-w3l my-3">
                <div class="col-md-3">
                    <label for="dop">City:</label>
                                                  <asp:TextBox ID="TextBox1" runat="server" style="width: 200px; height: 40px;" class="form-control" required></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <label for="dop">Pincode:</label>
                         <asp:TextBox ID="TextBox4" runat="server" style="width: 200px; height: 40px;" class="form-control" required></asp:TextBox>
                </div>
               
            </div>
            <div class="row sub-w3l my-3">
                <div class="col-md-3">
                    <label for="dop">Mobile No:</label>
                                                  <asp:TextBox ID="TextBox6" runat="server"  style="width: 200px; height: 40px;" class="form-control" pattern="[0-9]{10}"  required></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <label for="dop">Age:</label>
                                                  <asp:TextBox ID="TextBox7" runat="server"  style="width: 200px; height: 40px;" class="form-control" pattern="[0-9]{1,2}" required></asp:TextBox>
                </div>
               
            </div>
            <div class="row sub-w3l my-3">
                <div class="col-md-3">
                   <label for="dop">Login ID:</label>
                                                  <asp:TextBox ID="TextBox5" runat="server" style="width: 200px; height: 40px;" class="form-control" required></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <label for="dop">Password:</label>
                                                 <asp:TextBox ID="TextBox8" runat="server" TextMode="Password" style="width: 200px; height: 40px;" class="form-control" required></asp:TextBox>
                </div>
               
            </div>
             <div class="row sub-w3l my-3">
                <div class="col-md-3">
                    <label for="Select Catagory">Blood Group:</label>
                                                <asp:DropDownList ID="DropDownList5" runat="server"  class="form-control"   style="width: 200px;height: 40px" required>
                                            <asp:ListItem Selected="True">Select</asp:ListItem>
                                            <asp:ListItem>A+</asp:ListItem>
                                <asp:ListItem>A-</asp:ListItem>
                                <asp:ListItem>B+</asp:ListItem>
                                <asp:ListItem>B-</asp:ListItem>
                                <asp:ListItem>O+</asp:ListItem>
                                <asp:ListItem>O-</asp:ListItem>
                                <asp:ListItem>AB+</asp:ListItem>
                                <asp:ListItem>AB-</asp:ListItem>
                 
                                            </asp:DropDownList>	
                </div>
                <div class="col-md-3">
                    <label for="dop">Email ID:</label>
                                                  <asp:TextBox ID="TextBox9" runat="server"  style="width: 300px; height: 40px;" class="form-control" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$" required></asp:TextBox>
                </div>
            </div>

            


             <div class="row sub-w3l my-3">
                <div class="col-md-3">
                    <label for="dop">Date</label>
                                                <input style="    width: 200px; height: 40px;" type="date" class="form-control" id="Date1" placeholder="" name="dop"   required  >
                </div>
              
               
            </div>
            
            

            <asp:Button ID="Button1" runat="server" Text="Submit" class="btn btn-success"  
                   title="Click to Post" onclick="Button1_Click"/>
                                    <button type="reset" class="btn btn-primary" title="Click to reset content">Reset</button>
           <br />
           
        </form>
    </div>
    </div>
    </section>
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
