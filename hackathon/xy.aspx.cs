using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Default5 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
    }
    private void LoadImages()
    {
        SqlCommand cmd = new SqlCommand("select * from emergency ",con);
        SqlDataReader ds = cmd.ExecuteReader();
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
}