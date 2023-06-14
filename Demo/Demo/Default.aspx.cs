using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // string connectionstring = ConfigurationManager.ConnectionStrings["MyConnStr"].ConnectionString;
            string connectionstring = ConfigurationManager.ConnectionStrings["DemoConnStr"].ConnectionString;
            using (SqlConnection conn= new SqlConnection(connectionstring))
            {
                using (SqlCommand command= new SqlCommand("Insert into [Customers](Name,IsSubsribedToNewsLetter,Membershiptype_Id) values('San',1,1)", conn))
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
           string dept= DeptTB.Text;
            string connectionstring = ConfigurationManager.ConnectionStrings["DemoConnStr"].ConnectionString;
            string query = "Insert into Department(DeptId,DeptName) Values(2,'" + dept + "')" ;
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                using(SqlCommand cmd= new SqlCommand(query,conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}