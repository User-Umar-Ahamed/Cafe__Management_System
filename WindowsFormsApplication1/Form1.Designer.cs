namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.Username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameTxtbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTxtbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.Loginbtn = new Guna.UI2.WinForms.Guna2Button();
            this.ContinueAsGuestlink = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Username.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Username.Location = new System.Drawing.Point(168, 248);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(85, 19);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(169, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UsernameTxtbx
            // 
            this.UsernameTxtbx.Animated = true;
            this.UsernameTxtbx.AutoRoundedCorners = true;
            this.UsernameTxtbx.BorderRadius = 11;
            this.UsernameTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTxtbx.DefaultText = "";
            this.UsernameTxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTxtbx.Font = new System.Drawing.Font("Tw Cen MT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxtbx.ForeColor = System.Drawing.Color.Black;
            this.UsernameTxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTxtbx.Location = new System.Drawing.Point(165, 282);
            this.UsernameTxtbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsernameTxtbx.Name = "UsernameTxtbx";
            this.UsernameTxtbx.PasswordChar = '\0';
            this.UsernameTxtbx.PlaceholderText = "Enter Username";
            this.UsernameTxtbx.SelectedText = "";
            this.UsernameTxtbx.Size = new System.Drawing.Size(293, 25);
            this.UsernameTxtbx.TabIndex = 3;
            this.UsernameTxtbx.TextChanged += new System.EventHandler(this.UsernameTxtbx_TextChanged);
            // 
            // PasswordTxtbx
            // 
            this.PasswordTxtbx.Animated = true;
            this.PasswordTxtbx.AutoRoundedCorners = true;
            this.PasswordTxtbx.BorderRadius = 11;
            this.PasswordTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxtbx.DefaultText = "";
            this.PasswordTxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxtbx.Font = new System.Drawing.Font("Tw Cen MT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtbx.ForeColor = System.Drawing.Color.Black;
            this.PasswordTxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxtbx.Location = new System.Drawing.Point(165, 352);
            this.PasswordTxtbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordTxtbx.Name = "PasswordTxtbx";
            this.PasswordTxtbx.PasswordChar = '*';
            this.PasswordTxtbx.PlaceholderText = "Enter Password";
            this.PasswordTxtbx.SelectedText = "";
            this.PasswordTxtbx.Size = new System.Drawing.Size(293, 25);
            this.PasswordTxtbx.TabIndex = 4;
            // 
            // Loginbtn
            // 
            this.Loginbtn.BorderRadius = 20;
            this.Loginbtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Loginbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.Loginbtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.Loginbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Loginbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Loginbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Loginbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Loginbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.Loginbtn.Font = new System.Drawing.Font("Tw Cen MT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.Location = new System.Drawing.Point(223, 393);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(180, 45);
            this.Loginbtn.TabIndex = 5;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // ContinueAsGuestlink
            // 
            this.ContinueAsGuestlink.AutoSize = true;
            this.ContinueAsGuestlink.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueAsGuestlink.LinkColor = System.Drawing.Color.White;
            this.ContinueAsGuestlink.Location = new System.Drawing.Point(241, 457);
            this.ContinueAsGuestlink.Name = "ContinueAsGuestlink";
            this.ContinueAsGuestlink.Size = new System.Drawing.Size(140, 20);
            this.ContinueAsGuestlink.TabIndex = 6;
            this.ContinueAsGuestlink.TabStop = true;
            this.ContinueAsGuestlink.Text = "Continue as Guest";
            this.ContinueAsGuestlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.cancel_25px;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 27);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Cafe_logo;
            this.pictureBox1.Location = new System.Drawing.Point(141, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(649, 592);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ContinueAsGuestlink);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.PasswordTxtbx);
            this.Controls.Add(this.UsernameTxtbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTxtbx;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTxtbx;
        private Guna.UI2.WinForms.Guna2Button Loginbtn;
        private System.Windows.Forms.LinkLabel ContinueAsGuestlink;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

