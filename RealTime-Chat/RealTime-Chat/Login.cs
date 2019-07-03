using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;
using System.Net;
using System.Threading;

namespace RealTime_Chat
{
    public partial class Login : Form
    {
        Random r = new Random();
        bool suruklenmedurumu = false;
        Point ilkkonum;
        public MySqlConnection db = new MySqlConnection("Server=localhost;Database=rtc;Uid=root;Pwd='';");
        public MySqlCommand cmd = new MySqlCommand();
        public MySqlDataAdapter adtr;
        public MySqlDataReader dr;
        public DataSet ds;

        public Login()
        {
            InitializeComponent();
        }
      
         
       

                
         

        #region MouseMove
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenmedurumu) 
            {
                this.Left = e.X + this.Left - (ilkkonum.X);
                this.Top = e.Y + this.Top - (ilkkonum.Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            suruklenmedurumu = true; 
            this.Cursor = Cursors.SizeAll; 
            ilkkonum = e.Location; 
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            suruklenmedurumu = false; 
            this.Cursor = Cursors.Default; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void btnRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SignIn(txtUsername.Text, txtPassword.Text);
        }
        #region SignIn
        private void SignIn(String username, String password) {

            try
            {
                db.Close();
                db.Open();
                cmd = new MySqlCommand("Select *From user where username  ='" + username + "'", db);
                dr = cmd.ExecuteReader();
                if (username.Trim() != "" && password.Trim() != "")
                {
                    Ping ping = new Ping();
                    PingReply pingStatus = ping.Send(IPAddress.Parse("216.58.209.14"));
                    if (pingStatus.Status == IPStatus.Success)
                    {
                        if (dr.Read())
                        {
                            if (username.ToString() == dr["username"].ToString())
                            {
                                if (password.ToString() == dr["password"].ToString())
                                {
                                    String id = dr["id"].ToString();
                                    Properties.Settings.Default.id = Convert.ToInt16(dr["id"]);
                                    Properties.Settings.Default.username = dr["username"].ToString();
                                    Properties.Settings.Default.password = dr["password"].ToString();
                                    Properties.Settings.Default.email = dr["email"].ToString();
                                    Properties.Settings.Default.fullname = dr["fullname"].ToString();
                                    Properties.Settings.Default.secretanswer = dr["secretanswer"].ToString();
                                    Properties.Settings.Default.status = Convert.ToInt16(dr["status"]);
                                    Properties.Settings.Default.Save();
                                    db.Close();
                                    cmd = new MySqlCommand();
                                    db.Open();
                                    cmd.Connection = db;
                                    cmd.CommandText = "Update user set status='" + 1 + "' where id=" + id + "";
                                    cmd.ExecuteNonQuery();
                                    db.Close();
                                    Main main = new Main();
                                    main.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Your password is missing or incorrect..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    db.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Your username is missing or incorrect.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                db.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No such user.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            db.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Check your Internet connection.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        db.Close();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        #endregion

        private void btnForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot forgot = new Forgot();
            forgot.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //If you want the program to open once, remove the lines.
            /*
             Mutex Mtx = new Mutex(false, "SINGLE_INSTANCE_APP_MUTEX");
            if (Mtx.WaitOne(0, false) == false)
            {
                Mtx.Close();
                Mtx = null;
                Application.Exit();
            }
             */
        }
    }
}
