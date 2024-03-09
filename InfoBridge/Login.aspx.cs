using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Microsoft.AspNet.FriendlyUrls;
using System.Web.Services.Description;
using System.Windows;

namespace InfoBridge
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if(Label1.Text == "Login Sucessfully")
            {
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                MessageBox.Show("Invalid exception");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            string validusername = "admin";
            string validpassword = "admin"; 

            if(username == validusername && password == validpassword)
            {
                Label1.Text = "Login Sucessfully";
                Label1.ForeColor = System.Drawing.Color.Green;
                Response.Redirect("~/Default.aspx");
               
            }
            else
            {
                Response.Write("Username & Password Not Matched");
            }
            
        }
    }
}