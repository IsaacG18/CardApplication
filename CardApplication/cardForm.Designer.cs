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
            this.CardBDbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SendLNametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SendEmailtxt = new System.Windows.Forms.TextBox();
            this.Sendlbl = new System.Windows.Forms.Label();
            this.Messagetxt = new System.Windows.Forms.TextBox();
            this.Greetingtxt = new System.Windows.Forms.TextBox();
            this.Recipenettxt = new System.Windows.Forms.TextBox();
            this.Addresstxt = new System.Windows.Forms.TextBox();
            this.colourtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ManufactorDD = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Birthdaybtn = new System.Windows.Forms.Button();
            this.NewBornbtn = new System.Windows.Forms.Button();
            this.Anniversarybtn = new System.Windows.Forms.Button();
            this.CardNBbtn = new System.Windows.Forms.Button();
            this.CardAbtn = new System.Windows.Forms.Button();
            this.variblelbl = new System.Windows.Forms.Label();
            this.varibletxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Sendbtn
            // 
            this.Sendbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
            // CardBDbtn
            // 
            this.CardBDbtn.Location = new System.Drawing.Point(452, 371);
            this.CardBDbtn.Name = "CardBDbtn";
            this.CardBDbtn.Size = new System.Drawing.Size(152, 37);
            this.CardBDbtn.TabIndex = 2;
            this.CardBDbtn.Text = "Create Card";
            this.CardBDbtn.UseVisualStyleBackColor = true;
            this.CardBDbtn.Visible = false;
            this.CardBDbtn.Click += new System.EventHandler(this.CardBDbtn_Click);
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
            this.Sendlbl.Location = new System.Drawing.Point(437, 45);
            this.Sendlbl.Name = "Sendlbl";
            this.Sendlbl.Size = new System.Drawing.Size(115, 20);
            this.Sendlbl.TabIndex = 8;
            this.Sendlbl.Text = "Senders Name";
            this.Sendlbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // Messagetxt
            // 
            this.Messagetxt.Location = new System.Drawing.Point(430, 228);
            this.Messagetxt.Multiline = true;
            this.Messagetxt.Name = "Messagetxt";
            this.Messagetxt.Size = new System.Drawing.Size(230, 81);
            this.Messagetxt.TabIndex = 9;
            // 
            // Greetingtxt
            // 
            this.Greetingtxt.Location = new System.Drawing.Point(430, 100);
            this.Greetingtxt.Name = "Greetingtxt";
            this.Greetingtxt.Size = new System.Drawing.Size(230, 26);
            this.Greetingtxt.TabIndex = 10;
            // 
            // Recipenettxt
            // 
            this.Recipenettxt.Location = new System.Drawing.Point(430, 132);
            this.Recipenettxt.Name = "Recipenettxt";
            this.Recipenettxt.Size = new System.Drawing.Size(230, 26);
            this.Recipenettxt.TabIndex = 11;
            // 
            // Addresstxt
            // 
            this.Addresstxt.Location = new System.Drawing.Point(430, 164);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(230, 26);
            this.Addresstxt.TabIndex = 12;
            this.Addresstxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // colourtxt
            // 
            this.colourtxt.Location = new System.Drawing.Point(430, 196);
            this.colourtxt.Name = "colourtxt";
            this.colourtxt.Size = new System.Drawing.Size(230, 26);
            this.colourtxt.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Greeting";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Recipenet ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Colour";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Message";
            // 
            // ManufactorDD
            // 
            this.ManufactorDD.FormattingEnabled = true;
            this.ManufactorDD.Items.AddRange(new object[] {
            "Cards-R-US",
            "CardMakers",
            "Cards4U",
            "We heart Cards"});
            this.ManufactorDD.Location = new System.Drawing.Point(430, 315);
            this.ManufactorDD.Name = "ManufactorDD";
            this.ManufactorDD.Size = new System.Drawing.Size(230, 28);
            this.ManufactorDD.TabIndex = 21;
            this.ManufactorDD.SelectedIndexChanged += new System.EventHandler(this.ManufactorDD_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Manufactor";
            // 
            // Birthdaybtn
            // 
            this.Birthdaybtn.Location = new System.Drawing.Point(676, 107);
            this.Birthdaybtn.Name = "Birthdaybtn";
            this.Birthdaybtn.Size = new System.Drawing.Size(152, 37);
            this.Birthdaybtn.TabIndex = 23;
            this.Birthdaybtn.Text = "Birthday Card";
            this.Birthdaybtn.UseVisualStyleBackColor = true;
            this.Birthdaybtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewBornbtn
            // 
            this.NewBornbtn.Location = new System.Drawing.Point(676, 147);
            this.NewBornbtn.Name = "NewBornbtn";
            this.NewBornbtn.Size = new System.Drawing.Size(152, 37);
            this.NewBornbtn.TabIndex = 24;
            this.NewBornbtn.Text = "New Born";
            this.NewBornbtn.UseVisualStyleBackColor = true;
            this.NewBornbtn.Click += new System.EventHandler(this.NewBornbtn_Click);
            // 
            // Anniversarybtn
            // 
            this.Anniversarybtn.Location = new System.Drawing.Point(676, 188);
            this.Anniversarybtn.Name = "Anniversarybtn";
            this.Anniversarybtn.Size = new System.Drawing.Size(152, 37);
            this.Anniversarybtn.TabIndex = 25;
            this.Anniversarybtn.Text = "Anniversary";
            this.Anniversarybtn.UseVisualStyleBackColor = true;
            this.Anniversarybtn.Click += new System.EventHandler(this.Anniversarybtn_Click);
            // 
            // CardNBbtn
            // 
            this.CardNBbtn.Location = new System.Drawing.Point(452, 371);
            this.CardNBbtn.Name = "CardNBbtn";
            this.CardNBbtn.Size = new System.Drawing.Size(152, 37);
            this.CardNBbtn.TabIndex = 26;
            this.CardNBbtn.Text = "Create Card";
            this.CardNBbtn.UseVisualStyleBackColor = true;
            this.CardNBbtn.Visible = false;
            this.CardNBbtn.Click += new System.EventHandler(this.CardNBbtn_Click);
            // 
            // CardAbtn
            // 
            this.CardAbtn.Location = new System.Drawing.Point(452, 371);
            this.CardAbtn.Name = "CardAbtn";
            this.CardAbtn.Size = new System.Drawing.Size(152, 37);
            this.CardAbtn.TabIndex = 27;
            this.CardAbtn.Text = "Create Card";
            this.CardAbtn.UseVisualStyleBackColor = true;
            this.CardAbtn.Visible = false;
            this.CardAbtn.Click += new System.EventHandler(this.CardAbtn_Click);
            // 
            // variblelbl
            // 
            this.variblelbl.AutoSize = true;
            this.variblelbl.Location = new System.Drawing.Point(666, 240);
            this.variblelbl.Name = "variblelbl";
            this.variblelbl.Size = new System.Drawing.Size(38, 20);
            this.variblelbl.TabIndex = 29;
            this.variblelbl.Text = "Age";
            this.variblelbl.Visible = false;
            // 
            // varibletxt
            // 
            this.varibletxt.Location = new System.Drawing.Point(709, 237);
            this.varibletxt.Name = "varibletxt";
            this.varibletxt.Size = new System.Drawing.Size(119, 26);
            this.varibletxt.TabIndex = 28;
            this.varibletxt.WordWrap = false;
            // 
            // cardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Sendbtn;
            this.ClientSize = new System.Drawing.Size(1090, 450);
            this.Controls.Add(this.variblelbl);
            this.Controls.Add(this.varibletxt);
            this.Controls.Add(this.CardAbtn);
            this.Controls.Add(this.CardNBbtn);
            this.Controls.Add(this.Anniversarybtn);
            this.Controls.Add(this.NewBornbtn);
            this.Controls.Add(this.Birthdaybtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ManufactorDD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.colourtxt);
            this.Controls.Add(this.Addresstxt);
            this.Controls.Add(this.Recipenettxt);
            this.Controls.Add(this.Greetingtxt);
            this.Controls.Add(this.Messagetxt);
            this.Controls.Add(this.Sendlbl);
            this.Controls.Add(this.SendEmailtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SendLNametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardBDbtn);
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
        private System.Windows.Forms.Button CardBDbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SendLNametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SendEmailtxt;
        private System.Windows.Forms.Label Sendlbl;
        private System.Windows.Forms.TextBox Messagetxt;
        private System.Windows.Forms.TextBox Greetingtxt;
        private System.Windows.Forms.TextBox Recipenettxt;
        private System.Windows.Forms.TextBox Addresstxt;
        private System.Windows.Forms.TextBox colourtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ManufactorDD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Birthdaybtn;
        private System.Windows.Forms.Button NewBornbtn;
        private System.Windows.Forms.Button Anniversarybtn;
        private System.Windows.Forms.Button CardNBbtn;
        private System.Windows.Forms.Button CardAbtn;
        private System.Windows.Forms.Label variblelbl;
        private System.Windows.Forms.TextBox varibletxt;
    }
}

