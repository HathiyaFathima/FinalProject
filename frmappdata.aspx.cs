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
using System.Net.Mail; 
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
            OleDbCommand cmd = new OleDbCommand("select * from doctor where loginid='" + Session["docuser"].ToString() + "'", con);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TextBox1.Text = dr["doctorname"].ToString();
                DropDownList2.SelectedValue = dr["departmentname"].ToString();
                TextBox6.Text = dr["mobileno"].ToString();
                TextBox7.Text = dr["emailid"].ToString();
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
            OleDbCommand cmd = new OleDbCommand("update book1 set fstat='1',appdate='" + TextBox3.Text + "',apptime='" + TextBox5.Text + "' where cstr(ID)='" + Session["fmid"].ToString() + "'", con);
            cmd.ExecuteNonQuery();
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(Session["femail"].ToString());
            mailMessage.From = new MailAddress("arun05@gladecloud.in");
            mailMessage.Subject = "Information";
            string strmsg = "Appointment Sheduled. Date:" + TextBox3.Text + "Time:" + TextBox5.Text;
            mailMessage.Body = strmsg.ToString();
            SmtpClient smtpClient = new SmtpClient("mail.gladecloud.in");
            smtpClient.Credentials = new System.Net.NetworkCredential
                     ("arun05@gladecloud.in", "glade**1986");

            smtpClient.Send(mailMessage);

            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Appointment scheduled sucessfully');window.location ='frmappoint.aspx';", true);
       
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        OleDbConnection con;
            string strConnString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            con = new OleDbConnection(strConnString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("delete from doctor where cstr(idno)='" + Session["fmid"].ToString() + "'", con);
            cmd.ExecuteNonQuery();
            






            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Doctor deleted sucessfully');window.location ='frmappoint.aspx';", true);
        
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