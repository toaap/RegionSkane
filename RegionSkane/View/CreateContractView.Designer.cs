namespace RegionSkane
{
    partial class CreateContractView
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
            this.handSearchBtn = new System.Windows.Forms.Button();
            this.searchHandTxt = new System.Windows.Forms.TextBox();
            this.handLbl = new System.Windows.Forms.Label();
            this.lopnrLbl = new System.Windows.Forms.Label();
            this.lopnrDataGrid = new System.Windows.Forms.DataGridView();
            this.saveBtn = new System.Windows.Forms.Button();
            this.avtalLbl = new System.Windows.Forms.Label();
            this.namnLbl = new System.Windows.Forms.Label();
            this.handNamnTxt = new System.Windows.Forms.TextBox();
            this.avtalsnrTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.handMailTxt = new System.Windows.Forms.TextBox();
            this.handTelTxt = new System.Windows.Forms.TextBox();
            this.eMailLbl = new System.Windows.Forms.Label();
            this.handTelLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.startDateLbl = new System.Windows.Forms.Label();
            this.lastDateLbl = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stopDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.handIdTxt = new System.Windows.Forms.TextBox();
            this.handidLbl = new System.Windows.Forms.Label();
            this.handComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lopNbrBox = new System.Windows.Forms.GroupBox();
            this.adminBox = new System.Windows.Forms.GroupBox();
            this.pickHandLbl = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.GroupBox();
            this.msgLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lopnrDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.lopNbrBox.SuspendLayout();
            this.adminBox.SuspendLayout();
            this.dateBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // handSearchBtn
            // 
            this.handSearchBtn.Location = new System.Drawing.Point(264, 58);
            this.handSearchBtn.Name = "handSearchBtn";
            this.handSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.handSearchBtn.TabIndex = 0;
            this.handSearchBtn.Text = "Sök";
            this.handSearchBtn.UseVisualStyleBackColor = true;
            this.handSearchBtn.Click += new System.EventHandler(this.searchAdministrator_Click);
            // 
            // searchHandTxt
            // 
            this.searchHandTxt.Location = new System.Drawing.Point(114, 60);
            this.searchHandTxt.Name = "searchHandTxt";
            this.searchHandTxt.Size = new System.Drawing.Size(144, 20);
            this.searchHandTxt.TabIndex = 1;
            this.searchHandTxt.TextChanged += new System.EventHandler(this.searchHandTxt_TextChanged);
            // 
            // handLbl
            // 
            this.handLbl.AutoSize = true;
            this.handLbl.Location = new System.Drawing.Point(17, 63);
            this.handLbl.Name = "handLbl";
            this.handLbl.Size = new System.Drawing.Size(91, 13);
            this.handLbl.TabIndex = 2;
            this.handLbl.Text = "Sök handläggare:";
            this.handLbl.Click += new System.EventHandler(this.handLbl_Click);
            // 
            // lopnrLbl
            // 
            this.lopnrLbl.AutoSize = true;
            this.lopnrLbl.Location = new System.Drawing.Point(43, 22);
            this.lopnrLbl.Name = "lopnrLbl";
            this.lopnrLbl.Size = new System.Drawing.Size(65, 13);
            this.lopnrLbl.TabIndex = 4;
            this.lopnrLbl.Text = "Löpnummer:";
            // 
            // lopnrDataGrid
            // 
            this.lopnrDataGrid.AllowUserToAddRows = false;
            this.lopnrDataGrid.AllowUserToDeleteRows = false;
            this.lopnrDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lopnrDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lopnrDataGrid.Location = new System.Drawing.Point(114, 22);
            this.lopnrDataGrid.Name = "lopnrDataGrid";
            this.lopnrDataGrid.Size = new System.Drawing.Size(375, 184);
            this.lopnrDataGrid.TabIndex = 5;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(154, 587);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(110, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Skapa avtal";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // avtalLbl
            // 
            this.avtalLbl.AutoSize = true;
            this.avtalLbl.Location = new System.Drawing.Point(43, 38);
            this.avtalLbl.Name = "avtalLbl";
            this.avtalLbl.Size = new System.Drawing.Size(71, 13);
            this.avtalLbl.TabIndex = 7;
            this.avtalLbl.Text = "Avtalnummer:";
            // 
            // namnLbl
            // 
            this.namnLbl.AutoSize = true;
            this.namnLbl.Location = new System.Drawing.Point(70, 136);
            this.namnLbl.Name = "namnLbl";
            this.namnLbl.Size = new System.Drawing.Size(38, 13);
            this.namnLbl.TabIndex = 8;
            this.namnLbl.Text = "Namn:";
            this.namnLbl.Click += new System.EventHandler(this.namnLbl_Click);
            // 
            // handNamnTxt
            // 
            this.handNamnTxt.Enabled = false;
            this.handNamnTxt.Location = new System.Drawing.Point(114, 133);
            this.handNamnTxt.Name = "handNamnTxt";
            this.handNamnTxt.Size = new System.Drawing.Size(144, 20);
            this.handNamnTxt.TabIndex = 9;
            this.handNamnTxt.TextChanged += new System.EventHandler(this.handNamnTxt_TextChanged);
            // 
            // avtalsnrTxt
            // 
            this.avtalsnrTxt.Enabled = false;
            this.avtalsnrTxt.Location = new System.Drawing.Point(120, 35);
            this.avtalsnrTxt.Name = "avtalsnrTxt";
            this.avtalsnrTxt.Size = new System.Drawing.Size(144, 20);
            this.avtalsnrTxt.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Skapa ny";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // handMailTxt
            // 
            this.handMailTxt.Enabled = false;
            this.handMailTxt.Location = new System.Drawing.Point(345, 136);
            this.handMailTxt.Name = "handMailTxt";
            this.handMailTxt.Size = new System.Drawing.Size(144, 20);
            this.handMailTxt.TabIndex = 12;
            this.handMailTxt.TextChanged += new System.EventHandler(this.handMailTxt_TextChanged);
            // 
            // handTelTxt
            // 
            this.handTelTxt.Enabled = false;
            this.handTelTxt.Location = new System.Drawing.Point(345, 110);
            this.handTelTxt.Name = "handTelTxt";
            this.handTelTxt.Size = new System.Drawing.Size(144, 20);
            this.handTelTxt.TabIndex = 13;
            this.handTelTxt.TextChanged += new System.EventHandler(this.handTelTxt_TextChanged);
            // 
            // eMailLbl
            // 
            this.eMailLbl.AutoSize = true;
            this.eMailLbl.Location = new System.Drawing.Point(301, 139);
            this.eMailLbl.Name = "eMailLbl";
            this.eMailLbl.Size = new System.Drawing.Size(38, 13);
            this.eMailLbl.TabIndex = 14;
            this.eMailLbl.Text = "E-mail:";
            this.eMailLbl.Click += new System.EventHandler(this.eMailLbl_Click);
            // 
            // handTelLbl
            // 
            this.handTelLbl.AutoSize = true;
            this.handTelLbl.Location = new System.Drawing.Point(293, 113);
            this.handTelLbl.Name = "handTelLbl";
            this.handTelLbl.Size = new System.Drawing.Size(46, 13);
            this.handTelLbl.TabIndex = 15;
            this.handTelLbl.Text = "Telefon:";
            this.handTelLbl.Click += new System.EventHandler(this.handTelLbl_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(270, 587);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(110, 23);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "Avbryt";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // startDateLbl
            // 
            this.startDateLbl.AutoSize = true;
            this.startDateLbl.Location = new System.Drawing.Point(47, 32);
            this.startDateLbl.Name = "startDateLbl";
            this.startDateLbl.Size = new System.Drawing.Size(61, 13);
            this.startDateLbl.TabIndex = 17;
            this.startDateLbl.Text = "Startdatum:";
            // 
            // lastDateLbl
            // 
            this.lastDateLbl.AutoSize = true;
            this.lastDateLbl.Location = new System.Drawing.Point(282, 31);
            this.lastDateLbl.Name = "lastDateLbl";
            this.lastDateLbl.Size = new System.Drawing.Size(57, 13);
            this.lastDateLbl.TabIndex = 18;
            this.lastDateLbl.Text = "Slutdatum:";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(114, 28);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.startDateTimePicker.TabIndex = 19;
            // 
            // stopDateTimePicker
            // 
            this.stopDateTimePicker.Location = new System.Drawing.Point(345, 28);
            this.stopDateTimePicker.Name = "stopDateTimePicker";
            this.stopDateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.stopDateTimePicker.TabIndex = 20;
            // 
            // handIdTxt
            // 
            this.handIdTxt.Enabled = false;
            this.handIdTxt.Location = new System.Drawing.Point(114, 107);
            this.handIdTxt.Name = "handIdTxt";
            this.handIdTxt.Size = new System.Drawing.Size(144, 20);
            this.handIdTxt.TabIndex = 21;
            // 
            // handidLbl
            // 
            this.handidLbl.AutoSize = true;
            this.handidLbl.Location = new System.Drawing.Point(29, 110);
            this.handidLbl.Name = "handidLbl";
            this.handidLbl.Size = new System.Drawing.Size(79, 13);
            this.handidLbl.TabIndex = 22;
            this.handidLbl.Text = "Handläggareid:";
            // 
            // handComboBox
            // 
            this.handComboBox.FormattingEnabled = true;
            this.handComboBox.Location = new System.Drawing.Point(114, 33);
            this.handComboBox.Name = "handComboBox";
            this.handComboBox.Size = new System.Drawing.Size(144, 21);
            this.handComboBox.TabIndex = 26;
            this.handComboBox.SelectedIndexChanged += new System.EventHandler(this.handComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.msgLbl);
            this.groupBox1.Controls.Add(this.lopNbrBox);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.adminBox);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.dateBox);
            this.groupBox1.Controls.Add(this.avtalLbl);
            this.groupBox1.Controls.Add(this.avtalsnrTxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 625);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skapa Avtal";
            // 
            // lopNbrBox
            // 
            this.lopNbrBox.Controls.Add(this.lopnrDataGrid);
            this.lopNbrBox.Controls.Add(this.lopnrLbl);
            this.lopNbrBox.Location = new System.Drawing.Point(6, 323);
            this.lopNbrBox.Name = "lopNbrBox";
            this.lopNbrBox.Size = new System.Drawing.Size(501, 222);
            this.lopNbrBox.TabIndex = 30;
            this.lopNbrBox.TabStop = false;
            this.lopNbrBox.Text = "Skriv in löpnummer för leverantör";
            // 
            // adminBox
            // 
            this.adminBox.Controls.Add(this.handTelTxt);
            this.adminBox.Controls.Add(this.pickHandLbl);
            this.adminBox.Controls.Add(this.button1);
            this.adminBox.Controls.Add(this.handLbl);
            this.adminBox.Controls.Add(this.handComboBox);
            this.adminBox.Controls.Add(this.handidLbl);
            this.adminBox.Controls.Add(this.searchHandTxt);
            this.adminBox.Controls.Add(this.handIdTxt);
            this.adminBox.Controls.Add(this.handSearchBtn);
            this.adminBox.Controls.Add(this.eMailLbl);
            this.adminBox.Controls.Add(this.namnLbl);
            this.adminBox.Controls.Add(this.handMailTxt);
            this.adminBox.Controls.Add(this.handNamnTxt);
            this.adminBox.Controls.Add(this.handTelLbl);
            this.adminBox.Location = new System.Drawing.Point(6, 147);
            this.adminBox.Name = "adminBox";
            this.adminBox.Size = new System.Drawing.Size(501, 170);
            this.adminBox.TabIndex = 29;
            this.adminBox.TabStop = false;
            this.adminBox.Text = "Välj avtalshandläggare";
            // 
            // pickHandLbl
            // 
            this.pickHandLbl.AutoSize = true;
            this.pickHandLbl.Location = new System.Drawing.Point(19, 36);
            this.pickHandLbl.Name = "pickHandLbl";
            this.pickHandLbl.Size = new System.Drawing.Size(89, 13);
            this.pickHandLbl.TabIndex = 27;
            this.pickHandLbl.Text = "Välj handläggare:";
            // 
            // dateBox
            // 
            this.dateBox.Controls.Add(this.startDateTimePicker);
            this.dateBox.Controls.Add(this.lastDateLbl);
            this.dateBox.Controls.Add(this.stopDateTimePicker);
            this.dateBox.Controls.Add(this.startDateLbl);
            this.dateBox.Location = new System.Drawing.Point(6, 75);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(501, 66);
            this.dateBox.TabIndex = 28;
            this.dateBox.TabStop = false;
            this.dateBox.Text = "Välj avtalsdatum";
            // 
            // msgLbl
            // 
            this.msgLbl.AutoSize = true;
            this.msgLbl.Location = new System.Drawing.Point(23, 562);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(0, 13);
            this.msgLbl.TabIndex = 31;
            // 
            // CreateContractView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 649);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateContractView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skapa avtal";
            this.Load += new System.EventHandler(this.AddHandledareView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lopnrDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.lopNbrBox.ResumeLayout(false);
            this.lopNbrBox.PerformLayout();
            this.adminBox.ResumeLayout(false);
            this.adminBox.PerformLayout();
            this.dateBox.ResumeLayout(false);
            this.dateBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button handSearchBtn;
        private System.Windows.Forms.TextBox searchHandTxt;
        private System.Windows.Forms.Label handLbl;
        private System.Windows.Forms.Label lopnrLbl;
        private System.Windows.Forms.DataGridView lopnrDataGrid;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label avtalLbl;
        private System.Windows.Forms.Label namnLbl;
        private System.Windows.Forms.TextBox handNamnTxt;
        private System.Windows.Forms.TextBox avtalsnrTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox handMailTxt;
        private System.Windows.Forms.TextBox handTelTxt;
        private System.Windows.Forms.Label eMailLbl;
        private System.Windows.Forms.Label handTelLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label startDateLbl;
        private System.Windows.Forms.Label lastDateLbl;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker stopDateTimePicker;
        private System.Windows.Forms.TextBox handIdTxt;
        private System.Windows.Forms.Label handidLbl;
        private System.Windows.Forms.ComboBox handComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox dateBox;
        private System.Windows.Forms.GroupBox lopNbrBox;
        private System.Windows.Forms.GroupBox adminBox;
        private System.Windows.Forms.Label pickHandLbl;
        private System.Windows.Forms.Label msgLbl;
    }
}