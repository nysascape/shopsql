using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseTesting
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void _loginLoginButton_Click(object sender, EventArgs e)
        {
            string userIn = _loginUsernameBox.Text;
            string passIn = _loginPasswordBox.Text;
            string actualPassword = "";
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\databaseTesting\databaseTesting\ShopDatabase.mdf;Integrated Security=True";
            using (SqlConnection sql = new SqlConnection(con))
            {
                string command = "SELECT Users.Username, Passwords.Password FROM Users INNER JOIN Passwords ON Users.UserId=Passwords.UserId WHERE Users.Username=@userinput";
                SqlCommand sqlCom = new SqlCommand(command, sql);
                sqlCom.Parameters.AddWithValue("@userinput", userIn);
                try
                {
                    sql.Open();
                    using (SqlDataReader reader = sqlCom.ExecuteReader())
                    {
                        if(!reader.HasRows)
                        {
                            MessageBox.Show("Reader does not have any rows to show!");
                        }
                        else
                        {
                            while(reader.Read())
                            {
                                actualPassword = reader.GetValue(1).ToString();
                                string toShow = String.Format("Username = {0}\nPassword = {1}", userIn, actualPassword);
                                MessageBox.Show(toShow);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
