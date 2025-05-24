namespace WindowsFormsApplication1.AllUserControl
{
    partial class UC_Additems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddItemBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TxtCatergory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Catergory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.BorderRadius = 21;
            this.AddItemBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddItemBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddItemBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddItemBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddItemBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.AddItemBtn.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemBtn.ForeColor = System.Drawing.Color.White;
            this.AddItemBtn.Location = new System.Drawing.Point(281, 415);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(208, 45);
            this.AddItemBtn.TabIndex = 4;
            this.AddItemBtn.Text = "Add Item";
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // TxtCatergory
            // 
            this.TxtCatergory.BackColor = System.Drawing.Color.Transparent;
            this.TxtCatergory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TxtCatergory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtCatergory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCatergory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCatergory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtCatergory.ForeColor = System.Drawing.Color.Black;
            this.TxtCatergory.ItemHeight = 30;
            this.TxtCatergory.Items.AddRange(new object[] {
            "Beverages",
            "Dessert",
            "Rice & Pasta",
            "Appetizers.",
            "Meal & Combo"});
            this.TxtCatergory.Location = new System.Drawing.Point(200, 138);
            this.TxtCatergory.Name = "TxtCatergory";
            this.TxtCatergory.Size = new System.Drawing.Size(396, 36);
            this.TxtCatergory.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtCatergory.TabIndex = 5;
            this.TxtCatergory.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // TxtItemName
            // 
            this.TxtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtItemName.DefaultText = "";
            this.TxtItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtItemName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtItemName.ForeColor = System.Drawing.Color.Black;
            this.TxtItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtItemName.Location = new System.Drawing.Point(199, 231);
            this.TxtItemName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtItemName.Name = "TxtItemName";
            this.TxtItemName.PasswordChar = '\0';
            this.TxtItemName.PlaceholderText = "";
            this.TxtItemName.SelectedText = "";
            this.TxtItemName.Size = new System.Drawing.Size(396, 36);
            this.TxtItemName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtItemName.TabIndex = 6;
            this.TxtItemName.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // TxtPrice
            // 
            this.TxtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPrice.DefaultText = "";
            this.TxtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrice.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.ForeColor = System.Drawing.Color.Black;
            this.TxtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrice.Location = new System.Drawing.Point(199, 321);
            this.TxtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.PasswordChar = '\0';
            this.TxtPrice.PlaceholderText = "";
            this.TxtPrice.SelectedText = "";
            this.TxtPrice.Size = new System.Drawing.Size(396, 36);
            this.TxtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtPrice.TabIndex = 7;
            this.TxtPrice.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_Additems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtItemName);
            this.Controls.Add(this.TxtCatergory);
            this.Controls.Add(this.AddItemBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_Additems";
            this.Size = new System.Drawing.Size(781, 514);
            this.Load += new System.EventHandler(this.UC_Additems_Load);
            this.Leave += new System.EventHandler(this.UC_Additems_Leave_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button AddItemBtn;
        private Guna.UI2.WinForms.Guna2ComboBox TxtCatergory;
        private Guna.UI2.WinForms.Guna2TextBox TxtItemName;
        private Guna.UI2.WinForms.Guna2TextBox TxtPrice;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
