<%@ Page Title="" Language="C#" MasterPageFile="~/frmpatient.master" AutoEventWireup="true" CodeFile="frmchat.aspx.cs" Inherits="frmchat" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style type="text/css">
    body {
      background-color:#ccffff;
      
      font-family: arial
    }
     .container {
      background-color:white;
      max-width: 580px;
      
    }
    h2 {
      color: #333;
      font-family:@FangSong;
      font-size: 20px;
      
      font-weight: 400;
      text-align: center;
    }
    h2 a {
      color: #333
    }
    
        .style9
        {
            width: 76px;
        }
    
    </style>
    <div class="container">
   
   <table style="width:580px;" >
   <tr><td ><table style="width:580px;"><tr><td align="center" style="font-weight: bold; font-size: 18pt; font-family: Calibri; color:#3399ff " >
        SMART HEALTH PREDICTION</td></tr></table></td></tr>
   
   <tr><td ><table style="width:580px;"><tr><td align="left" style="font-weight: bold; font-size: 12pt; font-family: Calibri; " >
        <h2><a href="">Chat</a></h2></td></tr></table></td></tr>
        <tr><td ><table style="width:580px;"><tr>
           
           <td align="left" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:580px; " >
               To help us serve you better, please provide some information before we begin your chat
           </td>
           </tr></table></td></tr>
        <tr><td ><table style="width:580px;"><tr><td align="right" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray; width:200px; " >
            Disease Type
           </td>
           <td align="center" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:80px; " >:
           </td>
           <td align="left" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:300px; " >
               
               <asp:DropDownList ID="DropDownList1" runat="server" Width="150px" Height="25px" BackColor="#FFFFCC" 
                   ForeColor="Blue" Font-Names="Calibri" Font-Size="12pt" Font-Bold="true"
                   BorderColor="#3399FF" AutoPostBack="True" 
                   onselectedindexchanged="DropDownList1_SelectedIndexChanged" >
<asp:ListItem Selected="True" Value="Select"></asp:ListItem>


</asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
        ControlToValidate="DropDownList1" InitialValue="Select" ValidationGroup="A"
        ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
               
           </td>
           </tr></table></td></tr>
            <tr><td ><table style="width:580px;"><tr><td align="right" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray; width:200px; " >
                Username of Doctor
           </td>
           <td align="center" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:80px; " >:
           </td>
           <td align="left" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:300px; " >
               
               <asp:DropDownList ID="DropDownList2" runat="server" Width="150px" Height="25px" BackColor="#FFFFCC" 
                   ForeColor="Blue" Font-Names="Calibri" Font-Size="12pt" Font-Bold="true"
                   BorderColor="#3399FF" >
<asp:ListItem Selected="True" Value="Select"></asp:ListItem>

                  

</asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="DropDownList2" InitialValue="Select" ValidationGroup="A"
        ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
               
           </td>
           </tr></table></td></tr>
        <tr><td ><table style="width:580px;"><tr><td align="right" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:200px;  " >Full Name
           </td>
           <td align="center" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:80px;  " >:
           </td>
           <td align="left" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:300px;  " >
               <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
           </td>
           </tr></table></td></tr>
           <tr><td ><table style="width:580px;"><tr><td align="right" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:200px;  " >Gender
           </td>
           <td align="center" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:80px;  " >:
           </td>
           <td align="left" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:300px;  " >
               <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
           </td>
           </tr></table></td></tr>
            <tr><td ><table style="width:580px;"><tr><td align="right" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:200px;  " >Email_ID
           </td>
           <td align="center" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:80px;  " >:
           </td>
           <td align="left" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:300px;  " >
               <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
           </td>
           </tr></table></td></tr>
           
            <tr><td ><table style="width:580px;"><tr><td align="right" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:200px;  " >
                Your Question
           </td>
           <td align="center" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:80px;  " >:
           </td>
           <td align="left" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:300px;  " >
               <asp:TextBox ID="TextBox5" runat="server" Width="243px" BackColor="#FFFFCC" 
                   ForeColor="Blue" Font-Names="Calibri" Font-Size="12pt" Font-Bold="true"
                   BorderColor="#3399FF" BorderStyle="Dashed" Height="68px" 
                   TextMode="MultiLine"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                   ControlToValidate="TextBox5" ErrorMessage="*" ValidationGroup="A" ForeColor="Red"></asp:RequiredFieldValidator>
           </td>
           </tr></table></td></tr>
            <tr><td ><table style="width:580px;"><tr><td align="right" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray; width:200px; " >
           </td>
           <td align="center" 
                    style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;" 
                    class="style9" >
           </td>
           <td align="left" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:300px; " >
                 <asp:Button ID="Button1" runat="server" Text="Post" BorderStyle="None" 
                    Height="19px" Width="70px" Font-Bold="true" BackColor="#3399ff"  ValidationGroup="A"
                    ForeColor="White" OnClick="Button1_Click" /> &nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Back" BorderStyle="None" 
                    Height="19px" Width="70px" Font-Bold="true" BackColor="#3399ff"  
                    ForeColor="White" onclick="Button2_Click"  />

           </td>
           </tr></table></td></tr>
           <tr><td ><table style="width:580px;"><tr><td align="center" style="font-weight: bold; font-size: 14pt; font-family: Calibri; color:#3399ff; width:580px; " >
               &nbsp;</td>
           
           </tr></table></td></tr>
            <tr><td ><table style="width:580px;"><tr><td align="center" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray; width:580px; " >
                &nbsp;</td>
          
           </tr></table></td></tr>
    <tr><td ><table style="width:580px;"><tr><td >
        </td></tr></table></td></tr>
    </table></div>
</asp:Content>



