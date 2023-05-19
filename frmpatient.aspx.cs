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
            
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList5.SelectedValue == "Select" || DropDownList6.SelectedValue == "Select")
        {
            MessageBox("Select gender and blood group");
        }
        else
        {
            string dop = Request.Form["dop"];
            OleDbConnection con;
            string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            con = new OleDbConnection(strConnString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into patient(patientname,gender,address,city,pincode,mobileno,age,loginid,password1,bloodgroup,fdate,femail)values('" + TextBox2.Text + "','" + DropDownList6.SelectedValue + "','" + TextBox3.Text + "','" + TextBox1.Text + "','" + TextBox4.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox5.Text + "','" + TextBox8.Text + "','" + DropDownList5.SelectedValue + "',format('" + dop + "','MMMM dd, yyyy'),'" + TextBox9.Text + "')", con);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('New Patient Added sucessfully');window.location ='frmpatient.aspx';", true);
        }
    }
    private void MessageBox(string msg)
    {
        Label lbl = new Label();
        lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
        Page.Controls.Add(lbl);
    }
    static string strID;
    int myID;
    private void dread()
    {
        OleDbConnection con;
        string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
        con = new OleDbConnection(strConnString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select max(eid) as eid from empreg", con);
        OleDbDataReader dr;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            string strid = dr["eid"].ToString();
            if (strid == "")
            {
              TextBox2.Text = "EMP-0001";
                strID = "1";
            }
            else
            {
                myID = Convert.ToInt32(dr["eid"]) + 1;
                strID = myID.ToString();
                if (myID >= 1 && myID <= 9)
                {
                    TextBox2.Text = "EMP-000" + myID.ToString();
                }
                else if (myID >= 10 && myID <= 99)
                {
                    TextBox2.Text = "EMP-00" + myID.ToString();
                }
                else if (myID >= 100 && myID <= 999)
                {
                    TextBox2.Text = "EMP-0" + myID.ToString();
                }

                else
                {
                    //MessageBox.Show("CustomerID Exists: Contact Service center", "Customer Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        dr.Close();
        con.Close();
    }
}