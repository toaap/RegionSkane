namespace RegionSkane.View
{
    partial class CreateHandView
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
            this.button1 = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.TextBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.mailLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.returnMsgLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Skapa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(98, 30);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(57, 20);
            this.idText.TabIndex = 1;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(49, 33);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(43, 13);
            this.idLbl.TabIndex = 3;
            this.idLbl.Text = "Initialer:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(54, 62);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 13);
            this.nameLbl.TabIndex = 4;
            this.nameLbl.Text = "Namn:";
            // 
            // mailLbl
            // 
            this.mailLbl.AutoSize = true;
            this.mailLbl.Location = new System.Drawing.Point(54, 94);
            this.mailLbl.Name = "mailLbl";
            this.mailLbl.Size = new System.Drawing.Size(38, 13);
            this.mailLbl.TabIndex = 5;
            this.mailLbl.Text = "E-mail:";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(9, 122);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(83, 13);
            this.phoneLbl.TabIndex = 6;
            this.phoneLbl.Text = "Telefonnummer:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(98, 59);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(149, 20);
            this.nameTxt.TabIndex = 7;
            // 
            // mailTxt
            // 
            this.mailTxt.Location = new System.Drawing.Point(98, 91);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(149, 20);
            this.mailTxt.TabIndex = 8;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(98, 119);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(149, 20);
            this.phoneTxt.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Avbryt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // returnMsgLbl
            // 
            this.returnMsgLbl.AutoSize = true;
            this.returnMsgLbl.Location = new System.Drawing.Point(9, 159);
            this.returnMsgLbl.Name = "returnMsgLbl";
            this.returnMsgLbl.Size = new System.Drawing.Size(0, 13);
            this.returnMsgLbl.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mailTxt);
            this.groupBox1.Controls.Add(this.returnMsgLbl);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.idText);
            this.groupBox1.Controls.Add(this.phoneTxt);
            this.groupBox1.Controls.Add(this.idLbl);
            this.groupBox1.Controls.Add(this.nameLbl);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.mailLbl);
            this.groupBox1.Controls.Add(this.phoneLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 231);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skapa handläggare";
            // 
            // CreateHandView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 253);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateHandView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skapa handläggare";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label mailLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox mailTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label returnMsgLbl;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}