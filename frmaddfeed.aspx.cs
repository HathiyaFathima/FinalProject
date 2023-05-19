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

public partial class frmaddfeed : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select * from chat1 where duser=  '" + Session["docuser"].ToString() + "' and status='0'", con);
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "INS")
        {
            OleDbConnection con;
            string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            con = new OleDbConnection(strConnString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from chat1 where chid='" + e.CommandArgument.ToString() + "'", con);
            // OleDbCommand cmd = new OleDbCommand("Select qual,desg,address1,phno1,image1 from profile",con);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TextBox5.Text = dr["ques"].ToString();
                //TextBox9.Text = dr["ddos"].ToString();
                //TextBox6.Text = dr["pfer"].ToString();
                //Session["cat"] = dr["dcname"].ToString();
                Label1.Text = dr["chid"].ToString();
                
                Panel1.Visible = true;
            }
            dr.Close();
            con.Close();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection con;
        string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
        con = new OleDbConnection(strConnString);
        con.Open();

        OleDbCommand cmd1 = new OleDbCommand("update chat1 set status='1',ans='" + TextBox6.Text + "',dname='" + Session["dname"] + "',dimage='" + Session["Image"] + "' where chid='" + Label1.Text + "'", con);
        cmd1.ExecuteNonQuery();
        con.Close();
        Server.Transfer("frmaddfeed.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Server.Transfer("frmaddfeed.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Server.Transfer("frmupdatedoctor1.aspx");
    }
}