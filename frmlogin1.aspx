<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmlogin1.aspx.cs" Inherits="frmlogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
    <form id="form1" runat="server">
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
                            
                            
                            <li class="nav-right-sty mt-lg-0 mt-sm-4 mt-3">
                                <a href="frmlogin.aspx" class="reqe-button text-uppercase active">Login</a>
                                <a href="frmpatient.aspx" class="reqe-button text-uppercase">Register</a>
                                 <a href="frmlogin1.aspx" class="reqe-button text-uppercase">Patient Login</a>
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
                <h4>Patient Login</h4>
            </li>
            
        </ol>
    </nav>
    <!-- //breadcrumbs -->
    <!-- login  -->
    <section class="single_grid_w3_main align-w3-abt" id="about" style="     padding-top: 4px; padding-left:200px ">
        <div class="container">
       
        <form action="#" method="post" >

            <div class="form-group">
                <label for="recipient-name" class="col-form-label">Username</label>
                <input type="text" class="form-control" placeholder="your name" name="name1" id="recipient-name"
                    required="">
            </div>
            <div class="form-group">
                <label for="password" class="col-form-label">Password</label>
                <input type="password" class="form-control" placeholder="*****" name="password1" id="password" required="">
            </div>
           
            <div class="right-w3l">
            <asp:Button ID="Button1" runat="server" Text="Login" class="btn btn-success"  
                   title="Click to Post" onclick="Button1_Click" />
              
            </div>
           
            
        </form>
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
    </form>
</body>
</html>
