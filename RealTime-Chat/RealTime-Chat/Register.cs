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
    public partial class Register : Form
    {
        Random r = new Random();
        bool suruklenmedurumu = false;
        Point ilkkonum;
        public MySqlConnection db = new MySqlConnection("Server=localhost;Database=rtc;Uid=root;Pwd='';");
        public MySqlCommand cmd = new MySqlCommand();
        public MySqlDataAdapter adtr;
        public MySqlDataReader dr;
        public DataSet ds;


        public Register()
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
            Login log = new Login();
            log.Show();
            this.Close();

        }
        #endregion

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Create(txtUsername.Text, txtPassword.Text, txtEmail.Text, txtFullname.Text, txtSecretanswer.Text);
        }
        #region RegisterForm
        private void Create(String username, String password, String email, String fullname, String secretanswer)
        {
            if (txtUsername.Text.Trim() != "" &&
             txtPassword.Text.Trim() != "" &&
             txtEmail.Text.Trim() != "" &&
             txtFullname.Text.Trim() != "" &&
             txtSecretanswer.Text.Trim() != "")
            {

                Ping ping = new Ping();
                PingReply pingStatus = ping.Send(IPAddress.Parse("216.58.209.14")); // ping connectiın google 
                if (pingStatus.Status == IPStatus.Success)
                {
                    try
                    {
                        db.Close();
                        db.Open();
                        cmd = new MySqlCommand("Insert Into user(username,password,email,fullname,secretanswer,status) Values ('"
                           + username.Trim() + "','"
                           + password.Trim() + "','"
                           + email.Trim() + "','"
                           + fullname.Trim() + "','"
                           + secretanswer.Trim() + "','"
                           + 0 + "')", db);
                        object sonuc = null;
                        sonuc = cmd.ExecuteNonQuery();
                        db.Close();
                        if (sonuc != null)
                        {
                            MessageBox.Show("successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            txtEmail.Text = "";
                            txtFullname.Text = "";
                            txtSecretanswer.Text = "";
                            this.Close();
                            Login log = new Login();
                            log.Show();
                            db.Close();
                        }
                        else
                        {
                            MessageBox.Show("Could not add to add.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            db.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Take another email or username", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.Message.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Check your internet connection.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    db.Close();
                }
            }
            else
            {
                MessageBox.Show("can not be empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                db.Close();
            }

        }
        #endregion
    }
}