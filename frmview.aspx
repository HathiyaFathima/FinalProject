<%@ Page Title="" Language="C#" MasterPageFile="~/frmpatient.master" AutoEventWireup="true" CodeFile="frmview.aspx.cs" Inherits="frmview" %>

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
    
        </style>
    <div class="container">
   
   <table style="width:580px;" >
   <tr><td ><table style="width:580px;"><tr><td align="center" style="font-weight: bold; font-size: 18pt; font-family: Calibri; color:#3399ff " >
        SMART HEALTH PREDICTION</td></tr></table></td></tr>
   
   <tr><td ><table style="width:580px;"><tr><td align="left" style="font-weight: bold; font-size: 12pt; font-family: Calibri; " >
        <h2><a href=""> View Solution Information</a></h2></td></tr></table></td></tr>
         
          
        <tr><td ><table style="width:580px;"><tr><td align="right" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray; width:560px; " >
           <asp:DataList ID="DataList1" runat="server" RepeatColumns="1"  
              RepeatDirection="Horizontal" HorizontalAlign="left"  HeaderStyle-HorizontalAlign="left" ItemStyle-HorizontalAlign="left" ItemStyle-Font-Names="Calibri" ItemStyle-Font-Bold="true" ItemStyle-Font-Size="11pt">
        <ItemTemplate>
        <table width="560px" ><tr>
        <td id="Td3" runat="server" style="width:440px" valign="top" >
        <table id="Table2" runat="server" style="width:440px" align="left">
        <tr><td style="width:440px;"> <b style="font-size:11pt; font-family:Calibri; font-weight:bolder">Patient Name : </b>
        <asp:Label ID="Label1" runat="server" Text='<%#Eval("name1") %>' Font-Size="11pt" Font-Bold="true" ForeColor="red" Font-Names="Calibri"></asp:Label>
        </td></tr>
      
         
               
        </table>
        </td></tr>      
        </table>
         <table id="Table3" runat="server" style="width:560px"><tr id="Tr3" runat="server"><td id="Td5" runat="server" style="width:560px;">
        <b style="font-size:11pt; color:Blue; font-family:Calibri; font-weight:bolder" >Question: <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </b>
        <asp:Label ID="Label9" runat="server" Text='<%#Eval("ques") %>' Font-Size="11pt" Font-Bold="true" ForeColor="black" Font-Names="Calibri"></asp:Label>
        </td></tr>
        </table>

        <table width="560px" ><tr>
        <td id="Td7" runat="server" style="width:440px" valign="top" >
        <table id="Table5" runat="server" style="width:440px" align="left">
        <tr><td style="width:440px;"> <b style="font-size:11pt; font-family:Calibri; font-weight:bolder">Doctor Name : </b>
        <asp:Label ID="Label2" runat="server" Text='<%#Eval("dname") %>' Font-Size="11pt" Font-Bold="true" ForeColor="red" Font-Names="Calibri"></asp:Label>
        </td></tr>
      
         
               
        </table>
        </td></tr>      
        </table>
         <table id="Table6" runat="server" style="width:560px"><tr id="Tr4" runat="server"><td id="Td8" runat="server" style="width:560px;">
        <b style="font-size:11pt; color:Blue; font-family:Calibri; font-weight:bolder" >Answer: <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </b>
        <asp:Label ID="Label3" runat="server" Text='<%#Eval("ans") %>' Font-Size="11pt" Font-Bold="true" ForeColor="black" Font-Names="Calibri"></asp:Label>
        </td></tr>
        </table>

        </ItemTemplate>
        </asp:DataList>
           
           
           </td>
           
           </tr></table></td></tr>
    
           <tr><td align="left" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:300px; " >
                 <asp:Button ID="Button1" runat="server" Text="Chat" BorderStyle="None" 
                    Height="19px" Width="77px" Font-Bold="true" BackColor="#3399ff"  ValidationGroup="A"
                    ForeColor="White" onclick="Button1_Click" /> &nbsp;
                    
           </td></tr>
               
    </table></div>
</asp:Content>