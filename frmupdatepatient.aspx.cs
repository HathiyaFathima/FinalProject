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
               // dread();
            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from patient where loginid='" + Session["user"].ToString() + "'", con);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["appname"] = dr["idno"].ToString();
                Session["appname1"] = dr["patientname"].ToString();
                TextBox2.Text = dr["patientname"].ToString();
                DropDownList6.SelectedValue = dr["gender"].ToString();
                TextBox3.Text = dr["address"].ToString();
                TextBox1.Text = dr["city"].ToString();
                TextBox4.Text = dr["pincode"].ToString();

                TextBox6.Text = dr["mobileno"].ToString();
                TextBox7.Text = dr["age"].ToString();
                TextBox5.Text = dr["loginid"].ToString();
                DropDownList5.SelectedValue = dr["bloodgroup"].ToString();
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
            OleDbCommand cmd = new OleDbCommand("update patient set patientname='" + TextBox2.Text + "',gender='" + DropDownList6.SelectedValue + "',address='" + TextBox3.Text + "',city='" + TextBox1.Text + "',pincode='" + TextBox4.Text + "',mobileno='" + TextBox6.Text + "',age='" + TextBox7.Text + "',loginid='" + TextBox5.Text + "',bloodgroup='" + DropDownList5.SelectedValue + "' where loginid='" + Session["user"].ToString() + "'", con);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Patient updates sucessfully');window.location ='frmupdatepatient.aspx';", true);
       
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        OleDbConnection con;
            string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            con = new OleDbConnection(strConnString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("delete from doctor where cstr(idno)='" + Session["fmid"].ToString() + "'", con);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Patient deleted sucessfully');window.location ='frmviewpatient.aspx';", true);
        
    }
    private void dread()
    {
        OleDbConnection con;
        string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
        con = new OleDbConnection(strConnString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select depname from department", con);
        OleDbDataReader dr;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            //DropDownList2.Items.Add(dr["depname"].ToString());
        }
        dr.Close();
        con.Close();
    }
}