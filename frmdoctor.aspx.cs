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
    protected void Button1_Click(object sender, EventArgs e)
    {
        //OleDbConnection con;
        //string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
        //con = new OleDbConnection(strConnString);
        //con.Open();
        //OleDbCommand cmd = new OleDbCommand("select * from supreg where sname='" + TextBox1.Text + "'", con);
        //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        //DataTable dt = new DataTable();
        //da.Fill(dt);
        //if (dt.Rows.Count != 0)
        //{
            
           // Label1.Text = "Supplier Name Already Exists";
            //TextBox1.BorderColor = System.Drawing.Color.Red;
       // }
            //else
        //{
        if (DropDownList2.SelectedValue=="Select")
        {
            MessageBox("Select Department");
        }
        else
        {
            dinsert();
        }
            //}
        //con.Close();
        
           
        
    }
    private void MessageBox(string msg)
    {
        Label lbl = new Label();
        lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
        Page.Controls.Add(lbl);
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
    private void dinsert()
    {
        OleDbConnection con;
        string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
        con = new OleDbConnection(strConnString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("insert into doctor(doctorname,departmentname,mobileno,emailid,loginid,password1,education,experience,consultancy_charge)values('" + TextBox1.Text + "','" + DropDownList2.SelectedValue + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "')", con);
        cmd.ExecuteNonQuery();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('New Doctor Added sucessfully');window.location ='frmdoctor.aspx';", true);
    }
}