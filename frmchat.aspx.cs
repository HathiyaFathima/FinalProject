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

public partial class frmchat : System.Web.UI.Page
{
    static string schat;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dread11();
            OleDbConnection con;
            string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            con = new OleDbConnection(strConnString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from patient where loginid='" + Session["user"].ToString() + "'", con);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label16.Text = dr["patientname"].ToString();
                Label15.Text = dr["femail"].ToString();
                Label1.Text = dr["gender"].ToString();

            }
            dr.Close();
            con.Close();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        dread();
        OleDbConnection con;
        string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
        con = new OleDbConnection(strConnString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("insert into chat1(cid,chid,dept,name1,pid,ques,image1,status,duser)values('" + strID + "','" + strID + "','" + DropDownList1.SelectedValue + "','" + Label16.Text + "','" + Session["user"].ToString() + "','" + TextBox5.Text + "','" + schat + "','0','" + DropDownList2.SelectedValue + "')", con);
        cmd.ExecuteNonQuery();
        con.Close();
        MessageBox("Query Added...");
        TextBox5.Text = "";
        DropDownList1.ClearSelection();
        DropDownList2.ClearSelection();
    }
    private void dread11()
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
            DropDownList1.Items.Add(dr["ftype"].ToString());
        }
        dr.Close();
        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("frmupdatepatient.aspx");
    }
    private void MessageBox(string msg)
    {
        Label lbl = new Label();
        lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
        Page.Controls.Add(lbl);
    }
    static string strID;
    static string strID1;
    int myID;
    private void dread()
    {
        OleDbConnection con;
        string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
        con = new OleDbConnection(strConnString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select max(cid) as did from chat1", con);
        OleDbDataReader dr;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            string strid = dr["did"].ToString();
            if (strid == "")
            {
                strID1= "CH-0001";
                strID = "1";
            }
            else
            {
                myID = Convert.ToInt32(dr["did"]) + 1;
                strID = myID.ToString();
                if (myID >= 1 && myID <= 9)
                {
                    strID1= "CH-000" + myID.ToString();
                }
                else if (myID >= 10 && myID <= 99)
                {
                    strID1 = "CH-00" + myID.ToString();
                }
                else if (myID >= 100 && myID <= 999)
                {
                    strID1 = "CH-0" + myID.ToString();
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
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        DropDownList2.Items.Add("Select");
        OleDbConnection con;
        string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
        con = new OleDbConnection(strConnString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select * from doctor where departmentname='" + DropDownList1.SelectedValue + "'", con);
        OleDbDataReader dr;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            DropDownList2.Items.Add(dr["loginid"].ToString());
            
        }
        dr.Close();
        con.Close();
    }
}