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
    static string fpath;
    static string str;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
                dread();
            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from doctor where cstr(idno)='" + Session["fmid"].ToString() + "'", con);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                TextBox1.Text = dr["doctorname"].ToString();
                DropDownList2.SelectedValue = dr["departmentname"].ToString();
                TextBox6.Text = dr["mobileno"].ToString();
                TextBox7.Text = dr["emailid"].ToString();
                TextBox3.Text = dr["loginid"].ToString();
                
                TextBox5.Text = dr["education"].ToString();
                TextBox8.Text = dr["experience"].ToString();
                TextBox9.Text = dr["consultancy_charge"].ToString();
            }
            dr.Close();
            con.Close();
        }
        
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
            OleDbCommand cmd = new OleDbCommand("update doctor set doctorname='" + TextBox1.Text + "',departmentname='" + DropDownList2.SelectedValue + "',mobileno='" + TextBox6.Text + "',emailid='" + TextBox7.Text + "',loginid='" + TextBox3.Text + "',education='" + TextBox5.Text + "',experience='" + TextBox8.Text + "',consultancy_charge='" + TextBox9.Text + "' where cstr(idno)='" + Session["fmid"].ToString() + "'", con);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Doctor updates sucessfully');window.location ='frmedit1.aspx';", true);
       
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        OleDbConnection con;
            string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            con = new OleDbConnection(strConnString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("delete from doctor where cstr(idno)='" + Session["fmid"].ToString() + "'", con);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Doctor deleted sucessfully');window.location ='frmedit1.aspx';", true);
        
    }
    private void dread()
    {
        OleDbConnection con;
        string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
        con = new OleDbConnection(strConnString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select distinct ftype as ftype from Fdata", con);
        OleDbDataReader dr;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            DropDownList2.Items.Add(dr["ftype"].ToString());
        }
        dr.Close();
        con.Close();
    }
}