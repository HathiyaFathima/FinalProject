﻿using System;
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
    protected string ttime { get; set; }
    protected string ttime1 { get; set; }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dread();
            
          //dread();
            //dread111();
        }
    }
  
    private void dread111()
    {
        OleDbConnection con;
        string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
        con = new OleDbConnection(strConnString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select patientname from patient", con);
        OleDbDataReader dr;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            //DropDownList1.Items.Add(dr["patientname"].ToString());
        }
        dr.Close();
        con.Close();
    }
    private void dread11()
    {
        
    }
   
    private void dgrid()
    {
        OleDbConnection con;
        string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
        con = new OleDbConnection(strConnString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select * from doctor where departmentname='" + DropDownList2.SelectedValue + "'", con);
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    private void dgrid1()
    {
       
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
            OleDbCommand cmd = new OleDbCommand("delete from appointment where cstr(idno)='" + e.CommandArgument.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            dgrid();
        }
    }
    
    private void MessageBox(string msg)
    {
        Label lbl = new Label();
        lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
        Page.Controls.Add(lbl);
    }
    private void dupdate()
    {
        
           
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Appointment Approved sucessfully');window.location ='frmapproveappoint.aspx';", true);
        
    }
    private void delete()
    {
        

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("frmpatreatment.aspx");
        //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Appointment Deleted sucessfully');window.location ='frmeditappoint.aspx';", true);
        
    }
    private void dfill()
    {
       
        
    }
    private void dfill2()
    {
       
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        
        
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
    protected void DropDownList2_SelectedIndexChanged1(object sender, EventArgs e)
    {
        dgrid();
    }
}