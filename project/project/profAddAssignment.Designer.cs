namespace project
{
    partial class profAddAssignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profAddAssignment));
            this.submit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.assignment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.course_id = new Bunifu.Framework.UI.BunifuDropdown();
            this.deadline = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.ActiveBorderThickness = 1;
            this.submit.ActiveCornerRadius = 20;
            this.submit.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.submit.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.submit.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submit.BackgroundImage")));
            this.submit.ButtonText = "Submit";
            this.submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.Black;
            this.submit.IdleBorderThickness = 1;
            this.submit.IdleCornerRadius = 20;
            this.submit.IdleFillColor = System.Drawing.Color.Maroon;
            this.submit.IdleForecolor = System.Drawing.Color.White;
            this.submit.IdleLineColor = System.Drawing.Color.Maroon;
            this.submit.Location = new System.Drawing.Point(307, 509);
            this.submit.Margin = new System.Windows.Forms.Padding(7);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(292, 55);
            this.submit.TabIndex = 16;
            this.submit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // assignment
            // 
            this.assignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignment.Location = new System.Drawing.Point(287, 246);
            this.assignment.Multiline = true;
            this.assignment.Name = "assignment";
            this.assignment.Size = new System.Drawing.Size(392, 215);
            this.assignment.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Assignment\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Course ID";
            // 
            // course_id
            // 
            this.course_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.course_id.BorderRadius = 3;
            this.course_id.DisabledColor = System.Drawing.Color.Gray;
            this.course_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_id.ForeColor = System.Drawing.Color.White;
            this.course_id.Items = new string[0];
            this.course_id.Location = new System.Drawing.Point(280, 41);
            this.course_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.course_id.Name = "course_id";
            this.course_id.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.course_id.onHoverColor = System.Drawing.Color.Silver;
            this.course_id.selectedIndex = -1;
            this.course_id.Size = new System.Drawing.Size(392, 43);
            this.course_id.TabIndex = 19;
            this.course_id.onItemSelected += new System.EventHandler(this.course_id_onItemSelected);
            // 
            // deadline
            // 
            this.deadline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.deadline.BorderRadius = 0;
            this.deadline.ForeColor = System.Drawing.Color.White;
            this.deadline.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.deadline.FormatCustom = null;
            this.deadline.Location = new System.Drawing.Point(287, 137);
            this.deadline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deadline.Name = "deadline";
            this.deadline.Size = new System.Drawing.Size(392, 44);
            this.deadline.TabIndex = 24;
            this.deadline.Value = new System.DateTime(2020, 4, 6, 22, 53, 43, 593);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Deadline";
            // 
            // profAddAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.deadline);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.course_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.assignment);
            this.Controls.Add(this.label1);
            this.Name = "profAddAssignment";
            this.Size = new System.Drawing.Size(838, 590);
            this.Load += new System.EventHandler(this.profAddAssignment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 submit;
        private System.Windows.Forms.TextBox assignment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDropdown course_id;
        private Bunifu.Framework.UI.BunifuDatepicker deadline;
        private System.Windows.Forms.Label label3;
    }
}
