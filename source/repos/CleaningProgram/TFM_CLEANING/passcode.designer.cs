namespace TFM_CLEANING
{
    partial class passcode
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
            this.pwdTBX = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.counterTBX = new System.Windows.Forms.TextBox();
            this.idTBX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.changeBTN = new System.Windows.Forms.Button();
            this.resetcounterboxTBX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // pwdTBX
            // 
            this.pwdTBX.Location = new System.Drawing.Point(58, 96);
            this.pwdTBX.Name = "pwdTBX";
            this.pwdTBX.PasswordChar = '*';
            this.pwdTBX.Size = new System.Drawing.Size(226, 20);
            this.pwdTBX.TabIndex = 1;
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(125, 122);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(93, 23);
            this.enterBtn.TabIndex = 2;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Set Maximum";
            this.label3.Visible = false;
            // 
            // counterTBX
            // 
            this.counterTBX.Enabled = false;
            this.counterTBX.Location = new System.Drawing.Point(137, 162);
            this.counterTBX.Name = "counterTBX";
            this.counterTBX.Size = new System.Drawing.Size(136, 20);
            this.counterTBX.TabIndex = 6;
            this.counterTBX.Visible = false;
            this.counterTBX.TextChanged += new System.EventHandler(this.counterTBX_TextChanged);
            // 
            // idTBX
            // 
            this.idTBX.Location = new System.Drawing.Point(58, 45);
            this.idTBX.Name = "idTBX";
            this.idTBX.Size = new System.Drawing.Size(226, 20);
            this.idTBX.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID";
            // 
            // changeBTN
            // 
            this.changeBTN.Location = new System.Drawing.Point(137, 223);
            this.changeBTN.Name = "changeBTN";
            this.changeBTN.Size = new System.Drawing.Size(93, 23);
            this.changeBTN.TabIndex = 9;
            this.changeBTN.Text = "Set Changes";
            this.changeBTN.UseVisualStyleBackColor = true;
            this.changeBTN.Click += new System.EventHandler(this.changeBTN_Click);
            // 
            // resetcounterboxTBX
            // 
            this.resetcounterboxTBX.Enabled = false;
            this.resetcounterboxTBX.Location = new System.Drawing.Point(137, 188);
            this.resetcounterboxTBX.Name = "resetcounterboxTBX";
            this.resetcounterboxTBX.Size = new System.Drawing.Size(136, 20);
            this.resetcounterboxTBX.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Reset Counter";
            // 
            // passcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 312);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resetcounterboxTBX);
            this.Controls.Add(this.changeBTN);
            this.Controls.Add(this.idTBX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.counterTBX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.pwdTBX);
            this.Controls.Add(this.label1);
            this.Name = "passcode";
            this.Text = "passcode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pwdTBX;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox counterTBX;
        private System.Windows.Forms.TextBox idTBX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button changeBTN;
        private System.Windows.Forms.TextBox resetcounterboxTBX;
        private System.Windows.Forms.Label label5;
    }
}