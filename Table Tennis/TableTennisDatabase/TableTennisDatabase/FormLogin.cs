using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TableTennisDatabase
{
    public partial class FormLogin : Form
    {
        SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.MyConnection);
        public FormLogin()
        {
            InitializeComponent();
            pbAttention.Visible = false;
            lblError.Visible = false;           

            // Username = mahsun
            // Password = 123456
        }

        private void pnl_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {

                txtUser.Text = "Username";
                txtUser.ForeColor = Color.DarkGray;

            }
            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.DarkGray;

            }
        }


        private void txtUser_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.DarkGray;

            }
            txtUser.Clear();
            txtUser.ForeColor = Color.White;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                
                txtUser.Text = "Username";
                txtUser.ForeColor = Color.DarkGray;

            }
            txtPassword.Clear();
            txtPassword.ForeColor = Color.White;
            txtPassword.PasswordChar = '●';            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try //Control the username from database
            { 
                sqlConnection.Open();
                DataTable dt = new DataTable();
                SqlCommand loginCmd = new SqlCommand("LoginProcedure", sqlConnection);
                loginCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loginCmd);
                sqlDataAdapter.Fill(dt);

                if (txtUser.Text != dt.Rows[0][0].ToString() || txtPassword.Text != dt.Rows[0][1].ToString())
                {
                    if (txtUser.Text != dt.Rows[0][0].ToString())
                    {
                        lblError.Visible = true;
                        lblError.Text = "Invalid Username!!!";
                        pbAttention.Visible = true;
                        sqlConnection.Close();
                    }
                    if (txtPassword.Text != dt.Rows[0][1].ToString())
                    {
                        lblError.Visible = true;
                        lblError.Text = "Invalid Password!!!";
                        pbAttention.Visible = true;
                        sqlConnection.Close();
                    }
                    
                    
                }    
                else
                {
                    sqlConnection.Close();
                    MainMenu Main = new MainMenu();
                    Main.Show();
                    Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
               
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0'; 
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            
            txtPassword.PasswordChar = '●';
        }
    }
}
