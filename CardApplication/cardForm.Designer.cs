namespace CardApplication
{
    partial class cardForm
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
            this.Sendbtn = new System.Windows.Forms.Button();
            this.SendFNametxt = new System.Windows.Forms.TextBox();
            this.Cardbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SendLNametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SendEmailtxt = new System.Windows.Forms.TextBox();
            this.Sendlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sendbtn
            // 
            this.Sendbtn.Location = new System.Drawing.Point(96, 218);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(122, 39);
            this.Sendbtn.TabIndex = 0;
            this.Sendbtn.Text = "Create Sender";
            this.Sendbtn.UseVisualStyleBackColor = true;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // SendFNametxt
            // 
            this.SendFNametxt.Location = new System.Drawing.Point(161, 74);
            this.SendFNametxt.Name = "SendFNametxt";
            this.SendFNametxt.Size = new System.Drawing.Size(100, 26);
            this.SendFNametxt.TabIndex = 1;
            // 
            // Cardbtn
            // 
            this.Cardbtn.Location = new System.Drawing.Point(430, 218);
            this.Cardbtn.Name = "Cardbtn";
            this.Cardbtn.Size = new System.Drawing.Size(152, 37);
            this.Cardbtn.TabIndex = 2;
            this.Cardbtn.Text = "Create Card";
            this.Cardbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // SendLNametxt
            // 
            this.SendLNametxt.Location = new System.Drawing.Point(162, 124);
            this.SendLNametxt.Name = "SendLNametxt";
            this.SendLNametxt.Size = new System.Drawing.Size(100, 26);
            this.SendLNametxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SendEmailtxt
            // 
            this.SendEmailtxt.Location = new System.Drawing.Point(162, 171);
            this.SendEmailtxt.Name = "SendEmailtxt";
            this.SendEmailtxt.Size = new System.Drawing.Size(100, 26);
            this.SendEmailtxt.TabIndex = 7;
            // 
            // Sendlbl
            // 
            this.Sendlbl.AutoSize = true;
            this.Sendlbl.Location = new System.Drawing.Point(426, 74);
            this.Sendlbl.Name = "Sendlbl";
            this.Sendlbl.Size = new System.Drawing.Size(115, 20);
            this.Sendlbl.TabIndex = 8;
            this.Sendlbl.Text = "Senders Name";
            this.Sendlbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // cardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 450);
            this.Controls.Add(this.Sendlbl);
            this.Controls.Add(this.SendEmailtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SendLNametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cardbtn);
            this.Controls.Add(this.SendFNametxt);
            this.Controls.Add(this.Sendbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "cardForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sendbtn;
        private System.Windows.Forms.TextBox SendFNametxt;
        private System.Windows.Forms.Button Cardbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SendLNametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SendEmailtxt;
        private System.Windows.Forms.Label Sendlbl;
    }
}

