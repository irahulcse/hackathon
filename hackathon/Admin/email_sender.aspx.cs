using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    SqlCommand com;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

        //var str = "select * from emergency";
        //com = new SqlCommand(str, con);
        //MemoryStream stream = new MemoryStream();
        //byte[] image = (byte[])com.ExecuteScalar();
        //stream.Write(image, 0, image.Length);
        //Bitmap bitmap = new Bitmap(stream);
        //Response.ContentType = "image/Jpeg";
        //bitmap.Save(Response.OutputStream, ImageFormat.Jpeg);
        //con.Close();
        //stream.Close();
    }

    //protected void grd_RowDataBound(object sender, GridViewRowEventArgs e)
    //{
    //    if (e.Row.RowType == DataControlRowType.DataRow)
    //    {
    //        System.Web.UI.HtmlControls.HtmlImage imageControl = (System.Web.UI.HtmlControls.HtmlImage)e.Row.FindControl("imageControl");
    //        if (((DataRowView)e.Row.DataItem)["image"] != DBNull.Value)
    //        {
    //            imageControl.Src = "data:image/png;base64," + Convert.ToBase64String((byte[])(((DataRowView)e.Row.DataItem))["image"]);
    //        }
    //    }
    //}

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand(" select DISTINCT t.email from register_hck t,emergency t1 where t.address=t1.address union select DISTINCT t1.email from register_hck t, emergency t1 where t.address = t1.address ", con);
        ArrayList emailArray = new ArrayList();
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            emailArray.Add(dr["email"]);
        }
        foreach (string email in emailArray)
        {
            const string username = "dtilak1999@gmail.com";
            const string password = "Sanyam99+";
            // SmtpClient smtpclient = new SmtpClient();
            SmtpClient smtpclient = new SmtpClient();
            MailMessage mail = new MailMessage();
            MailAddress fromaddress = new MailAddress("dtilak1999@gmail.com");
            smtpclient.Host = "smtp.gmail.com";
            smtpclient.Port = 587;
            mail.From = fromaddress;
            mail.To.Add(email);
            mail.Subject = "Forest Fire in Your Area";
            mail.Body = "<html><head><title></title></head><body><p>There is a fire in your city look at in our website and aware others also.</p></body></html> ";
            mail.IsBodyHtml = true;
            smtpclient.EnableSsl = true;
            smtpclient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpclient.Credentials = new System.Net.NetworkCredential(username, password);
            smtpclient.Send(mail);
            Label1.Text = "Your email was sent sucessfully ";
            dr.Close();
            con.Close();




        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/index.aspx");
    }
}