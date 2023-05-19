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
            dread();
            TextBox1.Text = Session["appname1"].ToString();
        }
    }
    static string strID;
    int myID;
    private void dread()
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
            dinsert();
            
       
        
    }
    private void MessageBox(string msg)
    {
        Label lbl = new Label();
        lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
        Page.Controls.Add(lbl);
    }
    private void dinsert()
    {
            OleDbConnection con;
            string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            con = new OleDbConnection(strConnString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into feedback(pname,feedback)values('" + TextBox1.Text + "','" + TextBox3.Text + "')", con);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('New Feedback Added sucessfully');window.location ='frmfeedback.aspx';", true);
    }
    
}