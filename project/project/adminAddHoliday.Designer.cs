namespace project
{
    partial class adminAddHoliday
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminAddHoliday));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.start_date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.end_date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.type = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Holiday Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Holiday Start Date";
            // 
            // start_date
            // 
            this.start_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.start_date.BorderRadius = 0;
            this.start_date.ForeColor = System.Drawing.Color.White;
            this.start_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_date.FormatCustom = "dd-MMM-yy";
            this.start_date.Location = new System.Drawing.Point(268, 165);
            this.start_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(326, 44);
            this.start_date.TabIndex = 24;
            this.start_date.Value = new System.DateTime(2020, 4, 11, 0, 0, 0, 0);
            // 
            // end_date
            // 
            this.end_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.end_date.BorderRadius = 0;
            this.end_date.ForeColor = System.Drawing.Color.White;
            this.end_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_date.FormatCustom = "dd-MMM-yy";
            this.end_date.Location = new System.Drawing.Point(268, 284);
            this.end_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(326, 44);
            this.end_date.TabIndex = 25;
            this.end_date.Value = new System.DateTime(2020, 4, 11, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Holiday End Date";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Submit";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.Location = new System.Drawing.Point(207, 412);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(7);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(292, 55);
            this.bunifuThinButton21.TabIndex = 27;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // type
            // 
            this.type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.type.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.ForeColor = System.Drawing.Color.White;
            this.type.HintForeColor = System.Drawing.Color.White;
            this.type.HintText = "Type";
            this.type.isPassword = false;
            this.type.LineFocusedColor = System.Drawing.Color.Maroon;
            this.type.LineIdleColor = System.Drawing.Color.Gray;
            this.type.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.type.LineThickness = 3;
            this.type.Location = new System.Drawing.Point(268, 46);
            this.type.Margin = new System.Windows.Forms.Padding(5);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(350, 47);
            this.type.TabIndex = 28;
            this.type.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // adminAddHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.type);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.end_date);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "adminAddHoliday";
            this.Size = new System.Drawing.Size(777, 511);
            this.Load += new System.EventHandler(this.adminAddHoliday_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker start_date;
        private Bunifu.Framework.UI.BunifuDatepicker end_date;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuMaterialTextbox type;
    }
}
