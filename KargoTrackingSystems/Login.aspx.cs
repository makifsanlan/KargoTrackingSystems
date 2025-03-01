using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace KargoTrackingSystems
{
    public partial class Login : System.Web.UI.Page
    {
        CargoTracking_DBEntities baglanti = new CargoTracking_DBEntities();
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection();


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String UserName, user_password;

            UserName = txtUserName.Text;

            user_password = txtPassword.Text;
            try
            {
                String querry = "SELECT* FROM Login_new WHERE UserName='" + txtUserName.Text + "' AND password= '" + txtPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count>0)
                {

                    UserName = txtUserName.Text;
                    user_password = txtPassword.Text;
                    Default form2 = new Default();
                    
                }
                else
                {
                    
                }
            }
            catch (Exception)
            {
                Label5.Text = "Giriş başarısızdır.";

                throw;
            }
            
            }
        }
    
}