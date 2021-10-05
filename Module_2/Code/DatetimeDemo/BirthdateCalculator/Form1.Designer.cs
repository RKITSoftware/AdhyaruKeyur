
namespace BirthdateCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnreset = new System.Windows.Forms.Button();
            this.btngetage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblmonth = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblsec = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblhour = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbldays = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Birth Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(12, 98);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(177, 62);
            this.btnreset.TabIndex = 1;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btngetage
            // 
            this.btngetage.Location = new System.Drawing.Point(195, 98);
            this.btngetage.Name = "btngetage";
            this.btngetage.Size = new System.Drawing.Size(200, 62);
            this.btngetage.TabIndex = 2;
            this.btngetage.Text = "Get Age";
            this.btngetage.UseVisualStyleBackColor = true;
            this.btngetage.Click += new System.EventHandler(this.btngetage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblmin);
            this.groupBox2.Location = new System.Drawing.Point(148, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 57);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Minutes";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblmin.Location = new System.Drawing.Point(39, 19);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(32, 25);
            this.lblmin.TabIndex = 4;
            this.lblmin.Text = "20";
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblyear.Location = new System.Drawing.Point(39, 19);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(32, 25);
            this.lblyear.TabIndex = 4;
            this.lblyear.Text = "20";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblyear);
            this.groupBox3.Location = new System.Drawing.Point(12, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(113, 57);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Year";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblmonth);
            this.groupBox4.Location = new System.Drawing.Point(148, 183);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(113, 57);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Month";
            // 
            // lblmonth
            // 
            this.lblmonth.AutoSize = true;
            this.lblmonth.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblmonth.Location = new System.Drawing.Point(39, 19);
            this.lblmonth.Name = "lblmonth";
            this.lblmonth.Size = new System.Drawing.Size(32, 25);
            this.lblmonth.TabIndex = 4;
            this.lblmonth.Text = "20";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblsec);
            this.groupBox5.Location = new System.Drawing.Point(282, 261);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(113, 57);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sec";
            // 
            // lblsec
            // 
            this.lblsec.AutoSize = true;
            this.lblsec.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblsec.Location = new System.Drawing.Point(39, 19);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(32, 25);
            this.lblsec.TabIndex = 4;
            this.lblsec.Text = "20";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblhour);
            this.groupBox6.Location = new System.Drawing.Point(12, 261);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(113, 57);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hour";
            // 
            // lblhour
            // 
            this.lblhour.AutoSize = true;
            this.lblhour.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblhour.Location = new System.Drawing.Point(39, 19);
            this.lblhour.Name = "lblhour";
            this.lblhour.Size = new System.Drawing.Size(32, 25);
            this.lblhour.TabIndex = 4;
            this.lblhour.Text = "20";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbldays);
            this.groupBox7.Location = new System.Drawing.Point(282, 183);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(113, 57);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Days";
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldays.Location = new System.Drawing.Point(39, 19);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(32, 25);
            this.lbldays.TabIndex = 4;
            this.lbldays.Text = "20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 341);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btngetage);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Birthdate Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btngetage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblmonth;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblsec;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblhour;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lbldays;
    }
}

