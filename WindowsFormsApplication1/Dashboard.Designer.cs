namespace WindowsFormsApplication1
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logoutlink = new System.Windows.Forms.LinkLabel();
            this.CloseBTN = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.RemoveitemsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateItemsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Additembtn = new Guna.UI2.WinForms.Guna2Button();
            this.PlaceOrderBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_RemoveItems1 = new WindowsFormsApplication1.AllUserControl.UC_RemoveItems();
            this.uC_UpdateItems1 = new WindowsFormsApplication1.AllUserControl.UC_UpdateItems();
            this.uC_PlaceOrder1 = new WindowsFormsApplication1.AllUserControl.UC_PlaceOrder();
            this.uC_Additems1 = new WindowsFormsApplication1.AllUserControl.UC_Additems();
            this.uC_Welcome1 = new WindowsFormsApplication1.AllUserControl.UC_Welcome();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.uC_RemoveItems1);
            this.panel2.Controls.Add(this.uC_UpdateItems1);
            this.panel2.Controls.Add(this.uC_PlaceOrder1);
            this.panel2.Controls.Add(this.uC_Additems1);
            this.panel2.Controls.Add(this.uC_Welcome1);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(220, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 514);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.Logoutlink);
            this.panel1.Controls.Add(this.CloseBTN);
            this.panel1.Controls.Add(this.RemoveitemsBtn);
            this.panel1.Controls.Add(this.UpdateItemsBtn);
            this.panel1.Controls.Add(this.Additembtn);
            this.panel1.Controls.Add(this.PlaceOrderBtn);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 514);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Logoutlink
            // 
            this.Logoutlink.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.Logoutlink, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Logoutlink.Font = new System.Drawing.Font("Century Gothic", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutlink.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.Logoutlink.Location = new System.Drawing.Point(95, 457);
            this.Logoutlink.Name = "Logoutlink";
            this.Logoutlink.Size = new System.Drawing.Size(63, 19);
            this.Logoutlink.TabIndex = 4;
            this.Logoutlink.TabStop = true;
            this.Logoutlink.Text = "Logout";
            this.Logoutlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logoutlink_LinkClicked);
            // 
            // CloseBTN
            // 
            this.guna2Transition1.SetDecoration(this.CloseBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CloseBTN.Image = global::WindowsFormsApplication1.Properties.Resources.cancel_25px;
            this.CloseBTN.ImageRotate = 0F;
            this.CloseBTN.Location = new System.Drawing.Point(0, 0);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CloseBTN.Size = new System.Drawing.Size(25, 25);
            this.CloseBTN.TabIndex = 0;
            this.CloseBTN.TabStop = false;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // RemoveitemsBtn
            // 
            this.RemoveitemsBtn.BorderRadius = 16;
            this.RemoveitemsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.RemoveitemsBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.RemoveitemsBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Transition1.SetDecoration(this.RemoveitemsBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.RemoveitemsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RemoveitemsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RemoveitemsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RemoveitemsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RemoveitemsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.RemoveitemsBtn.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F);
            this.RemoveitemsBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveitemsBtn.Location = new System.Drawing.Point(27, 232);
            this.RemoveitemsBtn.Name = "RemoveitemsBtn";
            this.RemoveitemsBtn.Size = new System.Drawing.Size(202, 41);
            this.RemoveitemsBtn.TabIndex = 3;
            this.RemoveitemsBtn.Text = "Remove Items";
            this.RemoveitemsBtn.Click += new System.EventHandler(this.RemoveitemsBtn_Click);
            // 
            // UpdateItemsBtn
            // 
            this.UpdateItemsBtn.BorderRadius = 16;
            this.UpdateItemsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.UpdateItemsBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.UpdateItemsBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Transition1.SetDecoration(this.UpdateItemsBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.UpdateItemsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateItemsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateItemsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateItemsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateItemsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.UpdateItemsBtn.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateItemsBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateItemsBtn.Location = new System.Drawing.Point(27, 174);
            this.UpdateItemsBtn.Name = "UpdateItemsBtn";
            this.UpdateItemsBtn.Size = new System.Drawing.Size(202, 41);
            this.UpdateItemsBtn.TabIndex = 2;
            this.UpdateItemsBtn.Text = "Update Items";
            this.UpdateItemsBtn.Click += new System.EventHandler(this.UpdateItemsBtn_Click);
            // 
            // Additembtn
            // 
            this.Additembtn.BorderRadius = 16;
            this.Additembtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Additembtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.Additembtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Transition1.SetDecoration(this.Additembtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Additembtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Additembtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Additembtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Additembtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Additembtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.Additembtn.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F);
            this.Additembtn.ForeColor = System.Drawing.Color.White;
            this.Additembtn.Location = new System.Drawing.Point(27, 111);
            this.Additembtn.Name = "Additembtn";
            this.Additembtn.Size = new System.Drawing.Size(202, 41);
            this.Additembtn.TabIndex = 1;
            this.Additembtn.Text = "Add Items";
            this.Additembtn.Click += new System.EventHandler(this.Additembtn_Click);
            // 
            // PlaceOrderBtn
            // 
            this.PlaceOrderBtn.BorderRadius = 16;
            this.PlaceOrderBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.PlaceOrderBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.PlaceOrderBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Transition1.SetDecoration(this.PlaceOrderBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PlaceOrderBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PlaceOrderBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PlaceOrderBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PlaceOrderBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PlaceOrderBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.PlaceOrderBtn.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F);
            this.PlaceOrderBtn.ForeColor = System.Drawing.Color.White;
            this.PlaceOrderBtn.Location = new System.Drawing.Point(27, 51);
            this.PlaceOrderBtn.Name = "PlaceOrderBtn";
            this.PlaceOrderBtn.Size = new System.Drawing.Size(202, 41);
            this.PlaceOrderBtn.TabIndex = 0;
            this.PlaceOrderBtn.Text = "Place Order";
            this.PlaceOrderBtn.Click += new System.EventHandler(this.PlaceOrderBtn_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 30;
            this.guna2Elipse7.TargetControl = this.panel2;
            // 
            // uC_RemoveItems1
            // 
            this.uC_RemoveItems1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_RemoveItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_RemoveItems1.Location = new System.Drawing.Point(0, 0);
            this.uC_RemoveItems1.Name = "uC_RemoveItems1";
            this.uC_RemoveItems1.Size = new System.Drawing.Size(781, 514);
            this.uC_RemoveItems1.TabIndex = 4;
            this.uC_RemoveItems1.Load += new System.EventHandler(this.uC_RemoveItems1_Load);
            // 
            // uC_UpdateItems1
            // 
            this.uC_UpdateItems1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_UpdateItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_UpdateItems1.Location = new System.Drawing.Point(0, 0);
            this.uC_UpdateItems1.Name = "uC_UpdateItems1";
            this.uC_UpdateItems1.Size = new System.Drawing.Size(781, 514);
            this.uC_UpdateItems1.TabIndex = 3;
            // 
            // uC_PlaceOrder1
            // 
            this.uC_PlaceOrder1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_PlaceOrder1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_PlaceOrder1.Location = new System.Drawing.Point(0, 0);
            this.uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            this.uC_PlaceOrder1.Size = new System.Drawing.Size(772, 517);
            this.uC_PlaceOrder1.TabIndex = 2;
            // 
            // uC_Additems1
            // 
            this.uC_Additems1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_Additems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Additems1.Location = new System.Drawing.Point(3, 0);
            this.uC_Additems1.Name = "uC_Additems1";
            this.uC_Additems1.Size = new System.Drawing.Size(778, 511);
            this.uC_Additems1.TabIndex = 1;
            // 
            // uC_Welcome1
            // 
            this.uC_Welcome1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_Welcome1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Welcome1.Location = new System.Drawing.Point(0, 3);
            this.uC_Welcome1.Name = "uC_Welcome1";
            this.uC_Welcome1.Size = new System.Drawing.Size(781, 514);
            this.uC_Welcome1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBTN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button PlaceOrderBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox CloseBTN;
        private Guna.UI2.WinForms.Guna2Button RemoveitemsBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateItemsBtn;
        private Guna.UI2.WinForms.Guna2Button Additembtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.LinkLabel Logoutlink;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AllUserControl.UC_Welcome uC_Welcome1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AllUserControl.UC_Additems uC_Additems1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private AllUserControl.UC_PlaceOrder uC_PlaceOrder1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private AllUserControl.UC_UpdateItems uC_UpdateItems1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private AllUserControl.UC_RemoveItems uC_RemoveItems1;
    }
}