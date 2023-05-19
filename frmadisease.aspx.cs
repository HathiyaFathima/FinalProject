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
        }
    }
    static string strID;
    int myID;
    private void dread()
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection con;
        string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
        con = new OleDbConnection(strConnString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select sym from fdata1", con);
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count != 0)
        {
            dinsert();
            
        }
        else
        {
            MessageBox("Disease record already exists!");
        }
        con.Close();
        
    }
    private void MessageBox(string msg)
    {
        Label lbl = new Label();
        lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
        Page.Controls.Add(lbl);
    }
    string[] arr = new string[9];
    private void dinsert()
    {
            arr = TextBox3.Text.Split(',');

            MessageBox(arr.Length.ToString());
            OleDbConnection con;
            string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            con = new OleDbConnection(strConnString);
            con.Open();
            if (arr.Length == 1)
            {
                OleDbCommand cmd1 = new OleDbCommand("insert into FData(dname,sym1,ftype)values('" + TextBox1.Text + "','" + arr[0].ToString() + "','" + TextBox2.Text + "')", con);
                cmd1.ExecuteNonQuery();
            }
            if (arr.Length == 2)
            {
                OleDbCommand cmd1 = new OleDbCommand("insert into FData(dname,sym1,sym2,ftype)values('" + TextBox1.Text + "','" + arr[0].ToString() + "','" + arr[1].ToString() + "','" + TextBox2.Text + "')", con);
                cmd1.ExecuteNonQuery();
            }
            if (arr.Length == 3)
            {
                OleDbCommand cmd1 = new OleDbCommand("insert into FData(dname,sym1,sym2,sym3,ftype)values('" + TextBox1.Text + "','" + arr[0].ToString() + "','" + arr[1].ToString() + "','" + arr[2].ToString() + "','" + TextBox2.Text + "')", con);
                cmd1.ExecuteNonQuery();
            }
            if (arr.Length == 4)
            {
                OleDbCommand cmd1 = new OleDbCommand("insert into FData(dname,sym1,sym2,sym3,sym4,ftype)values('" + TextBox1.Text + "','" + arr[0].ToString() + "','" + arr[1].ToString() + "','" + arr[2].ToString() + "','" + arr[3].ToString() + "','" + TextBox2.Text + "')", con);
                cmd1.ExecuteNonQuery();
            }
            if (arr.Length == 5)
            {
                OleDbCommand cmd1 = new OleDbCommand("insert into FData(dname,sym1,sym2,sym3,sym4,sym5,ftype)values('" + TextBox1.Text + "','" + arr[0].ToString() + "','" + arr[1].ToString() + "','" + arr[2].ToString() + "','" + arr[3].ToString() + "','" + arr[4].ToString() + "','" + TextBox2.Text + "')", con);
                cmd1.ExecuteNonQuery();
            }
            if (arr.Length == 6)
            {
                OleDbCommand cmd1 = new OleDbCommand("insert into FData(dname,sym1,sym2,sym3,sym4,sym5,sym6,ftype)values('" + TextBox1.Text + "','" + arr[0].ToString() + "','" + arr[1].ToString() + "','" + arr[2].ToString() + "','" + arr[3].ToString() + "','" + arr[4].ToString() + "','" + arr[5].ToString() + "','" + TextBox2.Text + "')", con);
                cmd1.ExecuteNonQuery();
            }
            if (arr.Length == 7)
            {
                OleDbCommand cmd1 = new OleDbCommand("insert into FData(dname,sym1,sym2,sym3,sym4,sym5,sym6,sym7,ftype)values('" + TextBox1.Text + "','" + arr[0].ToString() + "','" + arr[1].ToString() + "','" + arr[2].ToString() + "','" + arr[3].ToString() + "','" + arr[4].ToString() + "','" + arr[5].ToString() + "','" + arr[6].ToString() + "','" + TextBox2.Text + "')", con);
                cmd1.ExecuteNonQuery();
            }
            if (arr.Length == 8)
            {
                OleDbCommand cmd1 = new OleDbCommand("insert into FData(dname,sym1,sym2,sym3,sym4,sym5,sym6,sym7,sym8,ftype)values('" + TextBox1.Text + "','" + arr[0].ToString() + "','" + arr[1].ToString() + "','" + arr[2].ToString() + "','" + arr[3].ToString() + "','" + arr[4].ToString() + "','" + arr[5].ToString() + "','" + arr[6].ToString() + "','" + arr[7].ToString() + "','" + TextBox2.Text + "')", con);
                cmd1.ExecuteNonQuery();
            }
            if (arr.Length == 9)
            {
                OleDbCommand cmd1 = new OleDbCommand("insert into FData(dname,sym1,sym2,sym3,sym4,sym5,sym6,sym7,sym8,sym9,ftype)values('" + TextBox1.Text + "','" + arr[0].ToString() + "','" + arr[1].ToString() + "','" + arr[2].ToString() + "','" + arr[3].ToString() + "','" + arr[4].ToString() + "','" + arr[5].ToString() + "','" + arr[6].ToString() + "','" + arr[7].ToString() + "','" + arr[8].ToString() + "','" + TextBox2.Text + "')", con);
                cmd1.ExecuteNonQuery();
            }
            OleDbCommand cmd = new OleDbCommand("insert into fdata1(dname,sym,ftype)values('" + TextBox1.Text + "','" + TextBox3.Text + "','" + TextBox2.Text + "')", con);
            cmd.ExecuteNonQuery();
            
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('New Disease Added sucessfully');window.location ='frmadisease.aspx';", true);
    }
    
}