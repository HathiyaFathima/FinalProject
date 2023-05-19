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
            dfill1();
            dfill2();
            dfill3();
            dfill4();
            dfill5();
            dfill6();
            dfill7();
            dfill8();
            dfill9();
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel6.Visible = false;
            Panel7.Visible = false;
            Panel8.Visible = false;
            Panel9.Visible = false;
            Panel10.Visible = false;
        }
    }
    static string strID;
    int myID;
    private void dread()
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        
    }
    private void dfill_data()
    {
        OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select * from fdata1 where fstat=(select max(fstat) as fstat from fdata1)", con);
        OleDbDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Label1.Text = dr["dname"].ToString();
            Label2.Text = dr["ftype"].ToString();
        }
        dr.Close();
        con.Close();
        dgid();
    }
    
    private void dgid()
    {
        OleDbConnection con;
        string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
        con = new OleDbConnection(strConnString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select * from doctor where departmentname='" + Label2.Text + "'", con);
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    private void dfill1()
    {
        OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select distinct sym1 from Fdata where sym1<>''", con);
        OleDbDataReader dr;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {

            RadioButtonList1.Items.Add(dr["sym1"].ToString());
        }
        dr.Close();
        con.Close();
    }
    private void dfill2()
    {
        OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select distinct sym2 from Fdata where sym2<>''", con);
        OleDbDataReader dr;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {

            RadioButtonList2.Items.Add(dr["sym2"].ToString());
        }
        dr.Close();
        con.Close();
    }
    private void dfill3()
    {
        OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select distinct sym3 from Fdata where sym3<>''", con);
        OleDbDataReader dr;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {

            RadioButtonList3.Items.Add(dr["sym3"].ToString());
        }
        dr.Close();
        con.Close();
    }
    private void dfill4()
    {
        OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select distinct sym4 from Fdata where sym4<>''", con);
        OleDbDataReader dr;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {

            RadioButtonList4.Items.Add(dr["sym4"].ToString());
        }
        dr.Close();
        con.Close();
    }
    private void dfill5()
    {
        OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select distinct sym5 from Fdata where sym5<>''", con);
        OleDbDataReader dr;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {

            RadioButtonList5.Items.Add(dr["sym5"].ToString());
        }
        dr.Close();
        con.Close();
    }
    private void dfill6()
    {
        OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select distinct sym6 from Fdata where sym6<>''", con);
        OleDbDataReader dr;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {

            RadioButtonList6.Items.Add(dr["sym6"].ToString());
        }
        dr.Close();
        con.Close();
    }
    private void dfill7()
    {
        OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select distinct sym7 from Fdata where sym7<>''", con);
        OleDbDataReader dr;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {

            RadioButtonList7.Items.Add(dr["sym7"].ToString());
        }
        dr.Close();
        con.Close();
    }
    private void dfill8()
    {
        OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select distinct sym8 from Fdata where sym8<>''", con);
        OleDbDataReader dr;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {

            RadioButtonList8.Items.Add(dr["sym8"].ToString());
        }
        dr.Close();
        con.Close();
    }
    private void dfill9()
    {
        OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select distinct sym9 from Fdata where sym9<>''", con);
        OleDbDataReader dr;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {

            RadioButtonList9.Items.Add(dr["sym9"].ToString());
        }
        dr.Close();
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
           // arr = TextBox3.Text.Split(',');
            //arr[4].ToString();
            OleDbConnection con;
            string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            con = new OleDbConnection(strConnString);
            con.Open();
            //OleDbCommand cmd = new OleDbCommand("insert into fdata1(dname,sym,ftype)values('" + TextBox1.Text + "','" + TextBox3.Text + "','" + TextBox2.Text + "')", con);
           // cmd.ExecuteNonQuery();
            //OleDbCommand cmd1 = new OleDbCommand("insert into FData(dname,sym1,sym2,sym3,sym4,sym5,sym6,sym7,sym8,sym9,ftype)values('" + TextBox1.Text + "','" + arr[0].ToString() + "','" + arr[1].ToString() + "','" + arr[2].ToString() + "','" + arr[3].ToString() + "','" + arr[4].ToString() + "','" + arr[5].ToString() + "','" + arr[6].ToString() + "','" + arr[7].ToString() + "','" + arr[8].ToString() + "','" + TextBox2.Text + "')", con);
            //cmd1.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('New Disease Added sucessfully');window.location ='frmadisease.aspx';", true);
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = true;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = false;
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = false;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = true;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = false;
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = true;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = false;
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = true;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = false;
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = true;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = false;
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = true;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = true;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = false;
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = true;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = false;
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = true;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = false;
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = true;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = false;
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = true;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = false;
    }
    protected void Button14_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = true;
        Panel9.Visible = false;
        Panel10.Visible = false;
    }
    protected void Button15_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = true;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = false;
    }
    protected void Button16_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = true;
        Panel10.Visible = false;
    }
    protected void Button17_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = true;
        Panel9.Visible = false;
        Panel10.Visible = false;
    }
    static string fdata;
    protected void Button18_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = true;
        fdata = RadioButtonList1.SelectedValue + "," + RadioButtonList2.SelectedValue + "," + RadioButtonList3.SelectedValue + "," + RadioButtonList4.SelectedValue + "," + RadioButtonList5.SelectedValue + "," + RadioButtonList6.SelectedValue + "," + RadioButtonList7.SelectedValue + "," + RadioButtonList8.SelectedValue + "," + RadioButtonList9.SelectedValue;
        ddetection(fdata);
        dfill_data();
    }
    protected void Button25_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = true;
        fdata = RadioButtonList1.SelectedValue + "," + RadioButtonList2.SelectedValue;
        ddetection(fdata);
        dfill_data();
    }
    protected void Button24_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = true;
        fdata = RadioButtonList1.SelectedValue + "," + RadioButtonList2.SelectedValue + "," + RadioButtonList3.SelectedValue;
        ddetection(fdata);
        dfill_data();
    }
    protected void Button23_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = true;
        fdata = RadioButtonList1.SelectedValue + "," + RadioButtonList2.SelectedValue + "," + RadioButtonList3.SelectedValue + "," + RadioButtonList4.SelectedValue;
        ddetection(fdata);
        dfill_data();
    }
    protected void Button22_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = true;
        fdata = RadioButtonList1.SelectedValue + "," + RadioButtonList2.SelectedValue + "," + RadioButtonList3.SelectedValue + "," + RadioButtonList4.SelectedValue + "," + RadioButtonList5.SelectedValue;
        ddetection(fdata);
        dfill_data();
    }
    protected void Button21_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = true;
        fdata = RadioButtonList1.SelectedValue + "," + RadioButtonList2.SelectedValue + "," + RadioButtonList3.SelectedValue + "," + RadioButtonList4.SelectedValue + "," + RadioButtonList5.SelectedValue + "," + RadioButtonList6.SelectedValue;
        ddetection(fdata);
        dfill_data();
    }
    protected void Button20_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = true;
        fdata = RadioButtonList1.SelectedValue + "," + RadioButtonList2.SelectedValue + "," + RadioButtonList3.SelectedValue + "," + RadioButtonList4.SelectedValue + "," + RadioButtonList5.SelectedValue + "," + RadioButtonList6.SelectedValue + "," + RadioButtonList7.SelectedValue;
        ddetection(fdata);
        dfill_data();
    }
    protected void Button19_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = true;
        fdata = RadioButtonList1.SelectedValue + "," + RadioButtonList2.SelectedValue + "," + RadioButtonList3.SelectedValue + "," + RadioButtonList4.SelectedValue + "," + RadioButtonList5.SelectedValue + "," + RadioButtonList6.SelectedValue + "," + RadioButtonList7.SelectedValue + "," + RadioButtonList8.SelectedValue;
        ddetection(fdata);
        dfill_data();
    }
    private void ddetection(string fdata)
    {
        OleDbConnection con;
        string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
        con = new OleDbConnection(strConnString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select sym,ID from fdata1", con);
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        int JJ = 0;
        foreach (DataRow dr1 in dt.Rows)
        {
            MatchsMaker match = new MatchsMaker(Convert.ToString(dt.Rows[JJ][0]), fdata);
            OleDbCommand cmd1 = new OleDbCommand("update fdata1 set fstat='" + match.Score + "' where cstr(ID)='" + Convert.ToString(dt.Rows[JJ][1]) + "'", con);
            cmd1.ExecuteNonQuery();
            JJ = JJ + 1;
        }
        con.Close();
    }
    static string pname,gender,mob,emai11;
    private void dddata()
    {
        OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from patient where loginid='" + Session["user"].ToString() + "'", con);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               
                pname = dr["patientname"].ToString();
                gender = dr["gender"].ToString();
                mob = dr["mobileno"].ToString();
                emai11 = dr["femail"].ToString();
               
            }
            dr.Close();
            con.Close();
        }
    static string dname,duser;
    private void dddata11()
    {
        OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
        con.Open();
        OleDbCommand cmd = new OleDbCommand("select * from doctor where departmentname='" + Label2.Text + "'", con);
        OleDbDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {

            dname = dr["doctorname"].ToString();
           
            duser = dr["loginid"].ToString();
           

        }
        dr.Close();
        con.Close();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "INS")
        {
            Session["fmid"] = e.CommandArgument.ToString();
            dddata();
            dddata11();
            OleDbConnection con;
            string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            con = new OleDbConnection(strConnString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into book1(puser,pname,gender,mob,email1,duser,dname,fstat)values('" + Session["user"].ToString() + "','" + pname + "','" + gender + "','" + mob + "','" + emai11 + "','" + duser + "','" + dname + "','0')", con);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('New Appointment Request Added sucessfully');window.location ='frmpredict.aspx';", true);
        }
    }


    }
   

