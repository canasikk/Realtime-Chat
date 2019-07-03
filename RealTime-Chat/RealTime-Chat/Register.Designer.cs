namespace RealTime_Chat
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new ns1.BunifuMetroTextbox();
            this.txtPassword = new ns1.BunifuMetroTextbox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new ns1.BunifuMetroTextbox();
            this.txtFullname = new ns1.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSecretanswer = new ns1.BunifuMetroTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 44);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(256, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(170)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(10, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Register";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(204)))), ((int)(((byte)(129)))));
            this.txtUsername.BorderColorIdle = System.Drawing.Color.White;
            this.txtUsername.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(204)))), ((int)(((byte)(129)))));
            this.txtUsername.BorderThickness = 2;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.isPassword = false;
            this.txtUsername.Location = new System.Drawing.Point(13, 98);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(275, 35);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(204)))), ((int)(((byte)(129)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.White;
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(204)))), ((int)(((byte)(129)))));
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.isPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(13, 172);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(275, 35);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(176, 428);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(112, 35);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "E-Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fullname";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(204)))), ((int)(((byte)(129)))));
            this.txtEmail.BorderColorIdle = System.Drawing.Color.White;
            this.txtEmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(204)))), ((int)(((byte)(129)))));
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.isPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(13, 239);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 35);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFullname
            // 
            this.txtFullname.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(204)))), ((int)(((byte)(129)))));
            this.txtFullname.BorderColorIdle = System.Drawing.Color.White;
            this.txtFullname.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(204)))), ((int)(((byte)(129)))));
            this.txtFullname.BorderThickness = 2;
            this.txtFullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFullname.ForeColor = System.Drawing.Color.White;
            this.txtFullname.isPassword = false;
            this.txtFullname.Location = new System.Drawing.Point(13, 310);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(275, 35);
            this.txtFullname.TabIndex = 4;
            this.txtFullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Secret Answer";
            // 
            // txtSecretanswer
            // 
            this.txtSecretanswer.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(204)))), ((int)(((byte)(129)))));
            this.txtSecretanswer.BorderColorIdle = System.Drawing.Color.White;
            this.txtSecretanswer.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(204)))), ((int)(((byte)(129)))));
            this.txtSecretanswer.BorderThickness = 2;
            this.txtSecretanswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSecretanswer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSecretanswer.ForeColor = System.Drawing.Color.White;
            this.txtSecretanswer.isPassword = false;
            this.txtSecretanswer.Location = new System.Drawing.Point(13, 378);
            this.txtSecretanswer.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecretanswer.Name = "txtSecretanswer";
            this.txtSecretanswer.Size = new System.Drawing.Size(275, 35);
            this.txtSecretanswer.TabIndex = 5;
            this.txtSecretanswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(170)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(301, 513);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtSecretanswer);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(301, 513);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(301, 513);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuMetroTextbox txtUsername;
        private ns1.BunifuMetroTextbox txtPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ns1.BunifuMetroTextbox txtEmail;
        private ns1.BunifuMetroTextbox txtFullname;
        private System.Windows.Forms.Label label6;
        private ns1.BunifuMetroTextbox txtSecretanswer;
    }
}

