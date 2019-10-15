namespace TFM_CLEANING
{
    partial class CleaningBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.empTBX = new System.Windows.Forms.TextBox();
            this.cleaningCBX = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cycleTBX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.alarmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "SILA BUAT CLEANING!";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "End";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AccessibleName = "datetimePicker";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Cleaning Items";
            // 
            // label3
            // 
            this.label3.AccessibleName = "datetimePicker";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Employee Id";
            // 
            // empTBX
            // 
            this.empTBX.AccessibleName = "datetimePicker";
            this.empTBX.Location = new System.Drawing.Point(33, 123);
            this.empTBX.Name = "empTBX";
            this.empTBX.Size = new System.Drawing.Size(100, 20);
            this.empTBX.TabIndex = 42;
            // 
            // cleaningCBX
            // 
            this.cleaningCBX.FormattingEnabled = true;
            this.cleaningCBX.Items.AddRange(new object[] {
            "Die Cleaning",
            "Wax Cleaning",
            "Dummy OAI",
            "Puncher Exchange/Polish",
            "Check Tool"});
            this.cleaningCBX.Location = new System.Drawing.Point(185, 123);
            this.cleaningCBX.Name = "cleaningCBX";
            this.cleaningCBX.Size = new System.Drawing.Size(121, 21);
            this.cleaningCBX.TabIndex = 48;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AccessibleName = "datetimePicker";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Cleaning Cycle";
            // 
            // cycleTBX
            // 
            this.cycleTBX.AccessibleName = "datetimePicker";
            this.cycleTBX.Location = new System.Drawing.Point(338, 124);
            this.cycleTBX.Name = "cycleTBX";
            this.cycleTBX.Size = new System.Drawing.Size(100, 20);
            this.cycleTBX.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Start";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "End";
            // 
            // alarmButton
            // 
            this.alarmButton.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmButton.Location = new System.Drawing.Point(116, 237);
            this.alarmButton.Name = "alarmButton";
            this.alarmButton.Size = new System.Drawing.Size(279, 37);
            this.alarmButton.TabIndex = 54;
            this.alarmButton.Text = "Henti Alarm";
            this.alarmButton.UseVisualStyleBackColor = true;
            this.alarmButton.Visible = false;
            this.alarmButton.Click += new System.EventHandler(this.alarmButton_Click);
            // 
            // CleaningBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(578, 229);
            this.Controls.Add(this.alarmButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cycleTBX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cleaningCBX);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.empTBX);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CleaningBox";
            this.Text = "MessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox empTBX;
        private System.Windows.Forms.ComboBox cleaningCBX;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cycleTBX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button alarmButton;
    }
}