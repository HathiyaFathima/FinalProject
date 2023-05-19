<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmfeedback.aspx.cs" Inherits="frmemployee" %>

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
                           
                           <li><a href="frmupdatepatient.aspx">Profile</a></li>
                            <li><a href="frmpredict.aspx">Search Disease</a></li>
                            <li><a href="doc_Report.aspx">Search Doctor</a></li>
                            <li><a href="frmchat.aspx">Post Query</a></li>
                            <li><a href="frmview.aspx">View Solution</a></li>
                           <li><a href="frmfeedback.aspx">Feedback</a></li>
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
                <h4>Add Feedback</h4>
            </li>
            
        </ol>
    </nav>
    <!-- //breadcrumbs -->
    <!-- login  -->
    <div class="modal-body align-w3">
        <form  runat="server" enctype="multipart/form-data" >
               <div class="row sub-w3l my-3">
               
                <div class="col-md-6">
                    <label for="dop">Patient Name:</label>
                                                  <asp:TextBox ID="TextBox1" runat="server" style="width: 300px; height: 40px;" class="form-control" required></asp:TextBox>
                </div>
               
            </div>
            
           
             <div class="row sub-w3l my-3">
                <div class="col-md-6">
                    <label for="dop">Feedback:</label>
                                                <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" style="width: 300px; height: 80px;" class="form-control" required></asp:TextBox>
                </div>
              
               
            </div>
    

            <asp:Button ID="Button1" runat="server" Text="Submit" class="btn btn-success"  
                   title="Click to Post" onclick="Button1_Click"/>
                                    <button type="reset" class="btn btn-primary" title="Click to reset content">Reset</button>
           
           
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
