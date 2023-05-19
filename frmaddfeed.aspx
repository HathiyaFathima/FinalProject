<%@ Page Title="" Language="C#" MasterPageFile="~/frmpatient.master" AutoEventWireup="true" CodeFile="frmaddfeed.aspx.cs" Inherits="frmaddfeed" %>

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
        <h2><a href=""> Post Solution</a></h2></td></tr></table></td></tr>
         
        <tr><td ><table style="width:580px;"><tr><td align="right" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray; width:580px; " >
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false"  HeaderStyle-BackColor="purple"
        HeaderStyle-ForeColor="white" RowStyle-Font-Bold="true" RowStyle-Font-Size="10pt" RowStyle-HorizontalAlign="Center"
        RowStyle-ForeColor="green" Width="570px" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label3" runat="server" Text="Chat ID"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%#bind("chid") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label6" runat="server" Text="Patient Name"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%#bind("name1") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>
                    <asp:Label ID="Label13" runat="server" Text="Department"></asp:Label>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label14" runat="server" Text='<%#bind("dept") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
           
               <asp:TemplateField>
                            <HeaderTemplate>
                       
                    </HeaderTemplate>
                                <ItemTemplate>
                                   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="INS" BorderStyle="None" ForeColor="white" BackColor="#3399ff" Font-Overline="false"  Text="Reply" CommandArgument='<%# bind("chid")%>'></asp:LinkButton>
                                                        
                                </ItemTemplate>
                            </asp:TemplateField>
                            
        </Columns>
        <RowStyle Font-Bold="True" Font-Size="10pt" ForeColor="purple" />
        <HeaderStyle BackColor="#3399ff" ForeColor="White" />
    </asp:GridView>
           </td>
           
           </tr></table></td></tr>
    
       <asp:Panel ID="Panel1" runat="server" Visible="false">
       
       
        <tr><td ><table style="width:580px;"><tr><td align="right" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray; width:200px; " >
            Chat ID
           </td>
           <td align="center" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:80px; " >:
           </td>
           <td align="left" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:300px; " >
               <asp:Label ID="Label1" runat="server" Text="Pid" Width="218px"></asp:Label>
           </td>
           </tr></table></td></tr>
           
        <tr><td ><table style="width:580px;"><tr><td align="right" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:200px;  " >
            Question
           </td>
           <td align="center" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:80px;  " >:
           </td>
           <td align="left" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:300px;  " >
               <asp:TextBox ID="TextBox5" runat="server" Width="243px" BackColor="#FFFFCC" 
                   ForeColor="Blue" Font-Names="Calibri" Font-Size="12pt" Font-Bold="true"
                   BorderColor="#3399FF" BorderStyle="Dashed" Height="68px" 
                   TextMode="MultiLine"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                   ControlToValidate="TextBox5" ErrorMessage="*" ValidationGroup="A" 
                   ForeColor="Red"></asp:RequiredFieldValidator>
           </td>
           </tr></table></td></tr>
            
            
            <tr><td ><table style="width:580px;"><tr><td align="right" 
                    style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:200px;" 
                     >Answer
           </td>
           <td align="center" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:80px;  " >:
           </td>
           <td align="left" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:305px;  " >
               <asp:TextBox ID="TextBox6" runat="server" Width="243px" BackColor="#FFFFCC" 
                   ForeColor="Blue" Font-Names="Calibri" Font-Size="12pt" Font-Bold="true"
                   BorderColor="#3399FF" BorderStyle="Dashed" Height="68px" 
                   TextMode="MultiLine"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                   ControlToValidate="TextBox6" ErrorMessage="*" ValidationGroup="A" 
                   ForeColor="Red"></asp:RequiredFieldValidator>
           </td>
           </tr></table></td></tr>
           
           
          
          
            <tr><td ><table style="width:580px;"><tr><td align="right" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray; width:200px; " >
           </td>
           <td align="center" 
                    style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;" 
                    class="style9" >
           </td>
           <td align="left" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:300px; " >
                 <asp:Button ID="Button1" runat="server" Text="Add Chat" BorderStyle="None" 
                    Height="19px" Width="81px" Font-Bold="true" BackColor="#3399ff"  ValidationGroup="A"
                    ForeColor="White" OnClick="Button1_Click" /> &nbsp;
        

           </td>
           </tr></table></td></tr></asp:Panel>
        
           <tr><td align="center" style="font-weight: bold; font-size: 12pt; font-family: Calibri; color:Gray;width:300px; " >
                
                    <asp:Button ID="Button4" runat="server" Text="Back" BorderStyle="None" 
                    Height="19px" Width="70px" Font-Bold="true" BackColor="#3399ff"  
                    ForeColor="White" onclick="Button4_Click"   />

           </td></tr>
               
    </table></div>
</asp:Content>

  