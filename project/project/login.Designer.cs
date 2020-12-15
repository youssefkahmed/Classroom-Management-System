namespace project
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.login1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 33);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(998, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 34);
            this.label4.TabIndex = 7;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(1053, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 34);
            this.label3.TabIndex = 6;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 640);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(735, 86);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(148, 58);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Login";
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.HintForeColor = System.Drawing.Color.Empty;
            this.email.HintText = "Enter Email";
            this.email.isPassword = false;
            this.email.LineFocusedColor = System.Drawing.Color.Maroon;
            this.email.LineIdleColor = System.Drawing.Color.Gray;
            this.email.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.email.LineThickness = 3;
            this.email.Location = new System.Drawing.Point(613, 254);
            this.email.Margin = new System.Windows.Forms.Padding(6);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(422, 52);
            this.email.TabIndex = 3;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.HintForeColor = System.Drawing.Color.Empty;
            this.password.HintText = "Enter Password";
            this.password.isPassword = true;
            this.password.LineFocusedColor = System.Drawing.Color.Maroon;
            this.password.LineIdleColor = System.Drawing.Color.Gray;
            this.password.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(613, 401);
            this.password.Margin = new System.Windows.Forms.Padding(6);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(422, 52);
            this.password.TabIndex = 4;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // login1
            // 
            this.login1.ActiveBorderThickness = 1;
            this.login1.ActiveCornerRadius = 20;
            this.login1.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.login1.ActiveForecolor = System.Drawing.Color.White;
            this.login1.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.login1.BackColor = System.Drawing.SystemColors.Control;
            this.login1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login1.BackgroundImage")));
            this.login1.ButtonText = "LogIn";
            this.login1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login1.ForeColor = System.Drawing.Color.Black;
            this.login1.IdleBorderThickness = 1;
            this.login1.IdleCornerRadius = 20;
            this.login1.IdleFillColor = System.Drawing.Color.Maroon;
            this.login1.IdleForecolor = System.Drawing.Color.White;
            this.login1.IdleLineColor = System.Drawing.Color.Maroon;
            this.login1.Location = new System.Drawing.Point(673, 543);
            this.login1.Margin = new System.Windows.Forms.Padding(7);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(292, 55);
            this.login1.TabIndex = 5;
            this.login1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login1.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(571, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 36);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(571, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 36);
            this.label2.TabIndex = 7;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 670);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuThinButton2 login1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}