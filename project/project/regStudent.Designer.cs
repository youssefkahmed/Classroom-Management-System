namespace project
{
    partial class regStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regStudent));
            this.panel2 = new System.Windows.Forms.Panel();
            this.register = new Bunifu.Framework.UI.BunifuThinButton2();
            this.year = new System.Windows.Forms.ComboBox();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.last_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.first_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.register);
            this.panel2.Controls.Add(this.year);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.email);
            this.panel2.Controls.Add(this.last_name);
            this.panel2.Controls.Add(this.first_name);
            this.panel2.Location = new System.Drawing.Point(146, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 513);
            this.panel2.TabIndex = 8;
            // 
            // register
            // 
            this.register.ActiveBorderThickness = 1;
            this.register.ActiveCornerRadius = 20;
            this.register.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.register.ActiveForecolor = System.Drawing.Color.White;
            this.register.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.register.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("register.BackgroundImage")));
            this.register.ButtonText = "Register";
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.Color.Black;
            this.register.IdleBorderThickness = 1;
            this.register.IdleCornerRadius = 20;
            this.register.IdleFillColor = System.Drawing.Color.Maroon;
            this.register.IdleForecolor = System.Drawing.Color.White;
            this.register.IdleLineColor = System.Drawing.Color.Maroon;
            this.register.Location = new System.Drawing.Point(86, 431);
            this.register.Margin = new System.Windows.Forms.Padding(7);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(292, 52);
            this.register.TabIndex = 15;
            this.register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.register.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // year
            // 
            this.year.BackColor = System.Drawing.Color.White;
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.ForeColor = System.Drawing.Color.Black;
            this.year.FormattingEnabled = true;
            this.year.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.year.Location = new System.Drawing.Point(41, 363);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(350, 30);
            this.year.TabIndex = 14;
            this.year.Text = "Academic Year";
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.HintForeColor = System.Drawing.Color.White;
            this.password.HintText = "Password";
            this.password.isPassword = true;
            this.password.LineFocusedColor = System.Drawing.Color.Maroon;
            this.password.LineIdleColor = System.Drawing.Color.Gray;
            this.password.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(41, 280);
            this.password.Margin = new System.Windows.Forms.Padding(5);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(350, 47);
            this.password.TabIndex = 13;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.HintForeColor = System.Drawing.Color.White;
            this.email.HintText = "Email";
            this.email.isPassword = false;
            this.email.LineFocusedColor = System.Drawing.Color.Maroon;
            this.email.LineIdleColor = System.Drawing.Color.Gray;
            this.email.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.email.LineThickness = 3;
            this.email.Location = new System.Drawing.Point(41, 192);
            this.email.Margin = new System.Windows.Forms.Padding(5);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(350, 50);
            this.email.TabIndex = 12;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // last_name
            // 
            this.last_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.last_name.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name.ForeColor = System.Drawing.Color.White;
            this.last_name.HintForeColor = System.Drawing.Color.White;
            this.last_name.HintText = "Last Name";
            this.last_name.isPassword = false;
            this.last_name.LineFocusedColor = System.Drawing.Color.Maroon;
            this.last_name.LineIdleColor = System.Drawing.Color.Gray;
            this.last_name.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.last_name.LineThickness = 3;
            this.last_name.Location = new System.Drawing.Point(41, 108);
            this.last_name.Margin = new System.Windows.Forms.Padding(5);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(350, 47);
            this.last_name.TabIndex = 11;
            this.last_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // first_name
            // 
            this.first_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.first_name.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name.ForeColor = System.Drawing.Color.White;
            this.first_name.HintForeColor = System.Drawing.Color.White;
            this.first_name.HintText = "First Name";
            this.first_name.isPassword = false;
            this.first_name.LineFocusedColor = System.Drawing.Color.Maroon;
            this.first_name.LineIdleColor = System.Drawing.Color.Gray;
            this.first_name.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.first_name.LineThickness = 3;
            this.first_name.Location = new System.Drawing.Point(41, 27);
            this.first_name.Margin = new System.Windows.Forms.Padding(5);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(350, 47);
            this.first_name.TabIndex = 10;
            this.first_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // regStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.panel2);
            this.Name = "regStudent";
            this.Size = new System.Drawing.Size(778, 594);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 register;
        private System.Windows.Forms.ComboBox year;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox last_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox first_name;
    }
}
