using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.OleDb;
using System.Web.UI.HtmlControls; 

public partial class frmlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private void MessageBox(string msg)
    {
        Label lbl = new Label();
        lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
        Page.Controls.Add(lbl);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList2.SelectedValue == "Admin")
        {
            string name1 = Request.Form["name1"];
            string password1 = Request.Form["password1"];
            OleDbConnection con;
            string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            con = new OleDbConnection(strConnString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select uname,pass1 from login where uname='" + name1 + "' and pass1='" + password1 + "'", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                //Session["user"] = uname;
                Server.Transfer("frmdoctor.aspx");
            }
            else
            {
                MessageBox("Error Username or Password");
            }
        }
        else
        {
            dread();
        }
    }
    private void dread()
    {
        string name1 = Request.Form["name1"];
            string password1 = Request.Form["password1"];
            OleDbConnection con;
            string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            con = new OleDbConnection(strConnString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select loginid,password1 from doctor where loginid='" + name1 + "' and password1='" + password1 + "'", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                Session["docuser"] = Request.Form["name1"];
                Server.Transfer("frmupdatedoctor1.aspx");
            }
            else
            {
                MessageBox("Error Username or Password");
            }
        }
        
    
}