<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmpredict.aspx.cs" Inherits="frmemployee" %>

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
                <h4>Disease Prediction</h4>
                
            </li>
            
        </ol>
    </nav>
    <!-- //breadcrumbs -->
    <!-- login  -->
    <div class="modal-body align-w3">
        <form  runat="server" enctype="multipart/form-data" >
               
               
               <asp:Panel ID="Panel1" runat="server">
                        <div class="row">

                           <fieldset class="fs2 fs">
        <h4 class="fs-title">Choose Your Symptoms1</h4>
                               <asp:RadioButtonList ID="RadioButtonList1"  runat="server">
                               </asp:RadioButtonList>
      
       
                                      <asp:Button ID="Button3" BackColor="#3366ff" runat="server" Text="Next" 
                                   class="next action-button next_btn" onclick="Button3_Click" 
                                      ></asp:Button>
    </fieldset>
                       
                        </div></asp:Panel>

               
            
            
               
               <asp:Panel ID="Panel2" runat="server">
                        <div class="row">

                           <fieldset class="fs2 fs">
        <h4 class="fs-title">Choose Your Symptoms2</h4>
                               <asp:RadioButtonList ID="RadioButtonList2"  runat="server">
                               </asp:RadioButtonList>
      
       
        <asp:Button ID="Button2" BackColor="#3366ff" runat="server" Text="Previous" 
                                   class="previous action-button pre_btn" onclick="Button2_Click" 
                                      ></asp:Button>
                                      <asp:Button ID="Button4" BackColor="#3366ff" runat="server" Text="Next" 
                                   class="next action-button next_btn" onclick="Button4_Click" 
                                      ></asp:Button>
                               <asp:Button ID="Button25" runat="server" BackColor="#3366ff" 
                                   class="next action-button next_btn" onclick="Button25_Click" Text="Predict" />
    </fieldset>
                       
                        </div></asp:Panel>

               
          
               
               <asp:Panel ID="Panel3" runat="server">
                        <div class="row">

                           <fieldset class="fs2 fs">
        <h4 class="fs-title">Choose Your Symptoms3</h4>
                               <asp:RadioButtonList ID="RadioButtonList3"  runat="server">
                               </asp:RadioButtonList>
      
       
        <asp:Button ID="Button5" BackColor="#3366ff" runat="server" Text="Previous" 
                                   class="previous action-button pre_btn" onclick="Button5_Click" 
                                      ></asp:Button>
                                      <asp:Button ID="Button6" BackColor="#3366ff" runat="server" Text="Next" 
                                   class="next action-button next_btn" onclick="Button6_Click" 
                                      ></asp:Button>
                               <asp:Button ID="Button24" runat="server" BackColor="#3366ff" 
                                   class="next action-button next_btn" onclick="Button24_Click" Text="Predict" />
    </fieldset>
                       
                        </div></asp:Panel>

               
            
               <asp:Panel ID="Panel4" runat="server">
                        <div class="row">

                           <fieldset class="fs2 fs">
        <h4 class="fs-title">Choose Your Symptoms4</h4>
                               <asp:RadioButtonList ID="RadioButtonList4"  runat="server">
                               </asp:RadioButtonList>
      
       
        <asp:Button ID="Button7" BackColor="#3366ff" runat="server" Text="Previous" 
                                   class="previous action-button pre_btn" onclick="Button7_Click" 
                                      ></asp:Button>
                                      <asp:Button ID="Button8" BackColor="#3366ff" runat="server" Text="Next" 
                                   class="next action-button next_btn" onclick="Button8_Click" 
                                      ></asp:Button>
                               <asp:Button ID="Button23" runat="server" BackColor="#3366ff" 
                                   class="next action-button next_btn" onclick="Button23_Click" Text="Predict" />
    </fieldset>
                       
                        </div></asp:Panel>

               
            
               
               <asp:Panel ID="Panel5" runat="server">
                        <div class="row">

                           <fieldset class="fs2 fs">
        <h4 class="fs-title">Choose Your Symptoms5</h4>
                               <asp:RadioButtonList ID="RadioButtonList5" runat="server">
                               </asp:RadioButtonList>
      
       
        <asp:Button ID="Button9" BackColor="#3366ff" runat="server" Text="Previous" 
                                   class="previous action-button pre_btn" onclick="Button9_Click" 
                                      ></asp:Button>
                                      <asp:Button ID="Button10" BackColor="#3366ff" runat="server" Text="Next" 
                                   class="next action-button next_btn" onclick="Button10_Click" 
                                      ></asp:Button>
                               <asp:Button ID="Button22" runat="server" BackColor="#3366ff" 
                                   class="next action-button next_btn" onclick="Button22_Click" Text="Predict" />
    </fieldset>
                       
                        </div></asp:Panel>

               
            
               
               <asp:Panel ID="Panel6" runat="server">
                        <div class="row">

                           <fieldset class="fs2 fs">
        <h4 class="fs-title">Choose Your Symptoms6</h4>
                               <asp:RadioButtonList ID="RadioButtonList6" runat="server">
                               </asp:RadioButtonList>
      
       
        <asp:Button ID="Button11" BackColor="#3366ff" runat="server" Text="Previous" 
                                   class="previous action-button pre_btn" onclick="Button11_Click" 
                                      ></asp:Button>
                                      <asp:Button ID="Button12" BackColor="#3366ff" runat="server" Text="Next" 
                                   class="next action-button next_btn" onclick="Button12_Click" 
                                      ></asp:Button>
                               <asp:Button ID="Button21" runat="server" BackColor="#3366ff" 
                                   class="next action-button next_btn" onclick="Button21_Click" Text="Predict" />
    </fieldset>
                       
                        </div></asp:Panel>

               
            
               
               <asp:Panel ID="Panel7" runat="server">
                        <div class="row">

                           <fieldset class="fs2 fs">
        <h4 class="fs-title">Choose Your Symptoms7</h4>
                               <asp:RadioButtonList ID="RadioButtonList7" runat="server">
                               </asp:RadioButtonList>
      
       
        <asp:Button ID="Button13" BackColor="#3366ff" runat="server" Text="Previous" 
                                   class="previous action-button pre_btn" onclick="Button13_Click" 
                                      ></asp:Button>
                                      <asp:Button ID="Button14" BackColor="#3366ff" runat="server" Text="Next" 
                                   class="next action-button next_btn" onclick="Button14_Click" 
                                      ></asp:Button>
                               <asp:Button ID="Button20" runat="server" BackColor="#3366ff" 
                                   class="next action-button next_btn" onclick="Button20_Click" Text="Predict" />
    </fieldset>
                       
                        </div></asp:Panel>

               
           
               
               <asp:Panel ID="Panel8" runat="server">
                        <div class="row">

                           <fieldset class="fs2 fs">
        <h4 class="fs-title">Choose Your Symptoms8</h4>
                               <asp:RadioButtonList ID="RadioButtonList8" runat="server">
                               </asp:RadioButtonList>
      
       
        <asp:Button ID="Button15" BackColor="#3366ff" runat="server" Text="Previous" 
                                   class="previous action-button pre_btn" onclick="Button15_Click" 
                                      ></asp:Button>
                                      <asp:Button ID="Button16" BackColor="#3366ff" runat="server" Text="Next" 
                                   class="next action-button next_btn" onclick="Button16_Click" 
                                      ></asp:Button>
                               <asp:Button ID="Button19" runat="server" BackColor="#3366ff" 
                                   class="next action-button next_btn"  Text="Predict" 
                                   onclick="Button19_Click" />
    </fieldset>
                       
                        </div></asp:Panel>

               
           
               
               <asp:Panel ID="Panel9" runat="server">
                        <div class="row">

                           <fieldset class="fs2 fs">
        <h4 class="fs-title">Choose Your Symptoms9</h4>
                               <asp:RadioButtonList ID="RadioButtonList9" runat="server">
                               </asp:RadioButtonList>
      
       
        <asp:Button ID="Button17" BackColor="#3366ff" runat="server" Text="Previous" 
                                   class="previous action-button pre_btn" onclick="Button17_Click" 
                                      ></asp:Button>
                                      <asp:Button ID="Button18" BackColor="#3366ff" runat="server" Text="Predict" 
                                   class="next action-button next_btn" onclick="Button18_Click" 
                                      ></asp:Button>
    </fieldset>
                       
                        </div></asp:Panel>

             <div class="row sub-w3l my-3">
              <asp:Panel ID="Panel10" runat="server">
                        <div class="row">
                            <asp:Label ID="Label3" runat="server" Text="Predicted Disease Name: " ></asp:Label>
                            <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
                            
                        </div>
                        <div class="row">
                        <asp:Label ID="Label4" runat="server" Text="Disease Type: " ></asp:Label>
                            <asp:Label ID="Label2" runat="server" Text="" ForeColor="Red"></asp:Label>
                        </div>
                        <div class="row">
                          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false"  HeaderStyle-BackColor="purple"
        HeaderStyle-ForeColor="white" RowStyle-Font-Bold="true" RowStyle-Font-Size="10pt" 
                                           RowStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center"
        RowStyle-ForeColor="green" Width="737px" OnRowCommand="GridView1_RowCommand"   >
        <Columns>
           
           
          
          
           <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label20" runat="server" Text="Doctor Name"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label21" runat="server" Text='<%#bind("doctorname") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label9120" runat="server" Text="Email_ID"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                   <asp:Label ID="Label321" runat="server" Text='<%#bind("emailid") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label920" runat="server" Text="Mobile Number"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                   <asp:Label ID="Label221" runat="server" Text='<%#bind("mobileno") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <HeaderTemplate>
                       <asp:Label ID="Label46" runat="server" Text="Action"></asp:Label>
                    </HeaderTemplate>
                                <ItemTemplate>
                                   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="INS"  ForeColor="Green"  Font-Overline="false"  Text="Request Appointment" CommandArgument='<%# bind("idno")%>'></asp:LinkButton>
                                                        
                                </ItemTemplate>
                            </asp:TemplateField>
          
                                </Columns>
        <RowStyle Font-Bold="True" Font-Size="10pt" ForeColor="purple" />
        <HeaderStyle BackColor="#ff0000" ForeColor="White" />
    </asp:GridView> 
                        </div>
                        </asp:Panel>
               </div>

         
           
        </form>
    </div>

    <!-- //login -->

    <!-- footer -->
   
    <!-- //footer -->
    <!-- copyright -->
    <div class="cpy-right text-center">
        <p class="text-wh">SMART HEALTH PREDICTION
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
