namespace TFM_CLEANING
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.endBTN = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.secondlotLBL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.firstlotLBL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.counterLBL1 = new System.Windows.Forms.Label();
            this.counterLBL3 = new System.Windows.Forms.Label();
            this.counterLBL2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.startimeLBL = new System.Windows.Forms.Label();
            this.endTimeLBL = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Automotive Line";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cycle Count";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.endBTN);
            this.groupBox1.Controls.Add(this.startBtn);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.counterLBL1);
            this.groupBox1.Controls.Add(this.counterLBL3);
            this.groupBox1.Controls.Add(this.counterLBL2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(21, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 296);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // endBTN
            // 
            this.endBTN.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endBTN.Location = new System.Drawing.Point(197, 239);
            this.endBTN.Name = "endBTN";
            this.endBTN.Size = new System.Drawing.Size(104, 31);
            this.endBTN.TabIndex = 11;
            this.endBTN.Text = "End Process";
            this.endBTN.UseVisualStyleBackColor = true;
            this.endBTN.Click += new System.EventHandler(this.endBTN_Click);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(73, 239);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(104, 31);
            this.startBtn.TabIndex = 10;
            this.startBtn.Text = "Start Process";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.secondlotLBL);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(96, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 61);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // secondlotLBL
            // 
            this.secondlotLBL.Location = new System.Drawing.Point(40, 28);
            this.secondlotLBL.Name = "secondlotLBL";
            this.secondlotLBL.Size = new System.Drawing.Size(108, 20);
            this.secondlotLBL.TabIndex = 6;
            this.secondlotLBL.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Second Lot";
            this.label6.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.firstlotLBL);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(96, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 61);
            this.panel1.TabIndex = 8;
            // 
            // firstlotLBL
            // 
            this.firstlotLBL.Location = new System.Drawing.Point(40, 28);
            this.firstlotLBL.Name = "firstlotLBL";
            this.firstlotLBL.Size = new System.Drawing.Size(108, 20);
            this.firstlotLBL.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Lot";
            // 
            // counterLBL1
            // 
            this.counterLBL1.AutoSize = true;
            this.counterLBL1.BackColor = System.Drawing.Color.Chartreuse;
            this.counterLBL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.counterLBL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLBL1.Location = new System.Drawing.Point(212, 41);
            this.counterLBL1.Name = "counterLBL1";
            this.counterLBL1.Size = new System.Drawing.Size(32, 33);
            this.counterLBL1.TabIndex = 7;
            this.counterLBL1.Text = "0";
            // 
            // counterLBL3
            // 
            this.counterLBL3.AutoSize = true;
            this.counterLBL3.BackColor = System.Drawing.Color.Chartreuse;
            this.counterLBL3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.counterLBL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLBL3.Location = new System.Drawing.Point(136, 41);
            this.counterLBL3.Name = "counterLBL3";
            this.counterLBL3.Size = new System.Drawing.Size(32, 33);
            this.counterLBL3.TabIndex = 6;
            this.counterLBL3.Text = "0";
            // 
            // counterLBL2
            // 
            this.counterLBL2.AutoSize = true;
            this.counterLBL2.BackColor = System.Drawing.Color.Chartreuse;
            this.counterLBL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.counterLBL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLBL2.Location = new System.Drawing.Point(174, 41);
            this.counterLBL2.Name = "counterLBL2";
            this.counterLBL2.Size = new System.Drawing.Size(32, 33);
            this.counterLBL2.TabIndex = 4;
            this.counterLBL2.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Start Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "End Time:";
            // 
            // startimeLBL
            // 
            this.startimeLBL.AutoSize = true;
            this.startimeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startimeLBL.Location = new System.Drawing.Point(124, 404);
            this.startimeLBL.Name = "startimeLBL";
            this.startimeLBL.Size = new System.Drawing.Size(0, 16);
            this.startimeLBL.TabIndex = 8;
            // 
            // endTimeLBL
            // 
            this.endTimeLBL.AutoSize = true;
            this.endTimeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeLBL.Location = new System.Drawing.Point(121, 442);
            this.endTimeLBL.Name = "endTimeLBL";
            this.endTimeLBL.Size = new System.Drawing.Size(0, 16);
            this.endTimeLBL.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(21, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 68);
            this.panel3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tab Dye Cleaning";
            // 
            // backBTN
            // 
            this.backBTN.Location = new System.Drawing.Point(348, 443);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(75, 23);
            this.backBTN.TabIndex = 11;
            this.backBTN.Text = "Menu";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 478);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.endTimeLBL);
            this.Controls.Add(this.startimeLBL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox secondlotLBL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox firstlotLBL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label counterLBL1;
        private System.Windows.Forms.Label counterLBL3;
        private System.Windows.Forms.Label counterLBL2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label startimeLBL;
        private System.Windows.Forms.Label endTimeLBL;
        private System.Windows.Forms.Button endBTN;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBTN;
    }
}

