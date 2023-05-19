using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;

public partial class frmemployee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dgrid();
        }
    }
    private void dgrid()
    {
        OleDbConnection con;
        string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
        con = new OleDbConnection(strConnString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select * from book1 where fstat='0' and duser='" + Session["docuser"].ToString() + "'", con);
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "INS")
        {
            Session["fmid"] = e.CommandArgument.ToString();
            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from book1 where cstr(ID)='" + Session["fmid"].ToString() + "'", con);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["femail"] = dr["email1"].ToString();
                
            }
            dr.Close();
            con.Close();
            Server.Transfer("frmappdata.aspx");

        }
    }
    private void MessageBox(string msg)
    {
        Label lbl = new Label();
        lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
        Page.Controls.Add(lbl);
    }
   
    
}