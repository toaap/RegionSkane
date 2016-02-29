namespace RegionSkane
{
    partial class RegionView
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
            this.avtalsnrTxt = new System.Windows.Forms.TextBox();
            this.avtalsnrLbl = new System.Windows.Forms.Label();
            this.laddaAvtalBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.apaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handläggareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leverantörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikelgruppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editAdminBox = new System.Windows.Forms.GroupBox();
            this.editAdminMsgLbl = new System.Windows.Forms.Label();
            this.editAdminDeleteBtn = new System.Windows.Forms.Button();
            this.editAdminUpdateBtn = new System.Windows.Forms.Button();
            this.editAdminIdSearchBtn = new System.Windows.Forms.Button();
            this.editAdminMailTxt = new System.Windows.Forms.TextBox();
            this.editAdminIdLbl = new System.Windows.Forms.Label();
            this.editAdminIdTxt = new System.Windows.Forms.TextBox();
            this.editAdminPhoneLbl = new System.Windows.Forms.Label();
            this.editAdminPhoneTxt = new System.Windows.Forms.TextBox();
            this.editAdminMailLbl = new System.Windows.Forms.Label();
            this.editAdminNameTxt = new System.Windows.Forms.TextBox();
            this.editAdminNameLbl = new System.Windows.Forms.Label();
            this.addAdminBox = new System.Windows.Forms.GroupBox();
            this.addAdminMailTxt = new System.Windows.Forms.TextBox();
            this.returnMsgLbl = new System.Windows.Forms.Label();
            this.addAdminBtn = new System.Windows.Forms.Button();
            this.addAdminIdTxt = new System.Windows.Forms.TextBox();
            this.addAdminPhoneTxt = new System.Windows.Forms.TextBox();
            this.addAdminIdLbl = new System.Windows.Forms.Label();
            this.addAdminNameLbl = new System.Windows.Forms.Label();
            this.addAdminNameTxt = new System.Windows.Forms.TextBox();
            this.addAdminMailLbl = new System.Windows.Forms.Label();
            this.addAdminPhoneLbl = new System.Windows.Forms.Label();
            this.addContractBox = new System.Windows.Forms.GroupBox();
            this.explainAddContractLbl = new System.Windows.Forms.Label();
            this.editAdminClearFieldsBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.editAdminBox.SuspendLayout();
            this.addAdminBox.SuspendLayout();
            this.addContractBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // avtalsnrTxt
            // 
            this.avtalsnrTxt.Location = new System.Drawing.Point(105, 67);
            this.avtalsnrTxt.Name = "avtalsnrTxt";
            this.avtalsnrTxt.Size = new System.Drawing.Size(149, 20);
            this.avtalsnrTxt.TabIndex = 1;
            this.avtalsnrTxt.Text = "0802521";
            this.avtalsnrTxt.TextChanged += new System.EventHandler(this.avtalsnrTxt_TextChanged);
            // 
            // avtalsnrLbl
            // 
            this.avtalsnrLbl.AutoSize = true;
            this.avtalsnrLbl.Location = new System.Drawing.Point(20, 70);
            this.avtalsnrLbl.Name = "avtalsnrLbl";
            this.avtalsnrLbl.Size = new System.Drawing.Size(79, 13);
            this.avtalsnrLbl.TabIndex = 4;
            this.avtalsnrLbl.Text = "Avtals nummer:";
            this.avtalsnrLbl.Click += new System.EventHandler(this.avtalsnrLbl_Click);
            // 
            // laddaAvtalBtn
            // 
            this.laddaAvtalBtn.Location = new System.Drawing.Point(260, 65);
            this.laddaAvtalBtn.Name = "laddaAvtalBtn";
            this.laddaAvtalBtn.Size = new System.Drawing.Size(114, 23);
            this.laddaAvtalBtn.TabIndex = 10;
            this.laddaAvtalBtn.Text = "Skapa Avtal";
            this.laddaAvtalBtn.UseVisualStyleBackColor = true;
            this.laddaAvtalBtn.Click += new System.EventHandler(this.laddaAvtalBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apaToolStripMenuItem,
            this.administreraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // apaToolStripMenuItem
            // 
            this.apaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsadasToolStripMenuItem,
            this.avslutaProgramToolStripMenuItem});
            this.apaToolStripMenuItem.Name = "apaToolStripMenuItem";
            this.apaToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.apaToolStripMenuItem.Text = "Avtal";
            // 
            // dsadasToolStripMenuItem
            // 
            this.dsadasToolStripMenuItem.Name = "dsadasToolStripMenuItem";
            this.dsadasToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dsadasToolStripMenuItem.Text = "Skapa avtal";
            this.dsadasToolStripMenuItem.Click += new System.EventHandler(this.dsadasToolStripMenuItem_Click);
            // 
            // avslutaProgramToolStripMenuItem
            // 
            this.avslutaProgramToolStripMenuItem.Name = "avslutaProgramToolStripMenuItem";
            this.avslutaProgramToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.avslutaProgramToolStripMenuItem.Text = "Avsluta";
            this.avslutaProgramToolStripMenuItem.Click += new System.EventHandler(this.avslutaProgramToolStripMenuItem_Click);
            // 
            // administreraToolStripMenuItem
            // 
            this.administreraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.handläggareToolStripMenuItem,
            this.leverantörToolStripMenuItem,
            this.artikelgruppToolStripMenuItem});
            this.administreraToolStripMenuItem.Name = "administreraToolStripMenuItem";
            this.administreraToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.administreraToolStripMenuItem.Text = "Administrera";
            // 
            // handläggareToolStripMenuItem
            // 
            this.handläggareToolStripMenuItem.Name = "handläggareToolStripMenuItem";
            this.handläggareToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.handläggareToolStripMenuItem.Text = "Handläggare";
            this.handläggareToolStripMenuItem.Click += new System.EventHandler(this.handläggareToolStripMenuItem_Click);
            // 
            // leverantörToolStripMenuItem
            // 
            this.leverantörToolStripMenuItem.Name = "leverantörToolStripMenuItem";
            this.leverantörToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.leverantörToolStripMenuItem.Text = "Leverantör";
            // 
            // artikelgruppToolStripMenuItem
            // 
            this.artikelgruppToolStripMenuItem.Name = "artikelgruppToolStripMenuItem";
            this.artikelgruppToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.artikelgruppToolStripMenuItem.Text = "Artikelgrupp";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.addContractBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 379);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.editAdminMsgLbl);
            this.panel2.Controls.Add(this.editAdminBox);
            this.panel2.Controls.Add(this.addAdminBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 379);
            this.panel2.TabIndex = 13;
            this.panel2.Visible = false;
            // 
            // editAdminBox
            // 
            this.editAdminBox.Controls.Add(this.editAdminClearFieldsBtn);
            this.editAdminBox.Controls.Add(this.editAdminDeleteBtn);
            this.editAdminBox.Controls.Add(this.editAdminUpdateBtn);
            this.editAdminBox.Controls.Add(this.editAdminIdSearchBtn);
            this.editAdminBox.Controls.Add(this.editAdminMailTxt);
            this.editAdminBox.Controls.Add(this.editAdminIdLbl);
            this.editAdminBox.Controls.Add(this.editAdminIdTxt);
            this.editAdminBox.Controls.Add(this.editAdminPhoneLbl);
            this.editAdminBox.Controls.Add(this.editAdminPhoneTxt);
            this.editAdminBox.Controls.Add(this.editAdminMailLbl);
            this.editAdminBox.Controls.Add(this.editAdminNameTxt);
            this.editAdminBox.Controls.Add(this.editAdminNameLbl);
            this.editAdminBox.Location = new System.Drawing.Point(18, 155);
            this.editAdminBox.Name = "editAdminBox";
            this.editAdminBox.Size = new System.Drawing.Size(511, 160);
            this.editAdminBox.TabIndex = 16;
            this.editAdminBox.TabStop = false;
            this.editAdminBox.Text = "Redigera handläggare";
            // 
            // editAdminMsgLbl
            // 
            this.editAdminMsgLbl.AutoSize = true;
            this.editAdminMsgLbl.Location = new System.Drawing.Point(27, 333);
            this.editAdminMsgLbl.Name = "editAdminMsgLbl";
            this.editAdminMsgLbl.Size = new System.Drawing.Size(0, 13);
            this.editAdminMsgLbl.TabIndex = 25;
            // 
            // editAdminDeleteBtn
            // 
            this.editAdminDeleteBtn.Location = new System.Drawing.Point(144, 90);
            this.editAdminDeleteBtn.Name = "editAdminDeleteBtn";
            this.editAdminDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.editAdminDeleteBtn.TabIndex = 24;
            this.editAdminDeleteBtn.Text = "Tabort";
            this.editAdminDeleteBtn.UseVisualStyleBackColor = true;
            this.editAdminDeleteBtn.Click += new System.EventHandler(this.editAdminDeleteBtn_Click);
            // 
            // editAdminUpdateBtn
            // 
            this.editAdminUpdateBtn.Location = new System.Drawing.Point(63, 90);
            this.editAdminUpdateBtn.Name = "editAdminUpdateBtn";
            this.editAdminUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.editAdminUpdateBtn.TabIndex = 23;
            this.editAdminUpdateBtn.Text = "Uppdatera";
            this.editAdminUpdateBtn.UseVisualStyleBackColor = true;
            this.editAdminUpdateBtn.Click += new System.EventHandler(this.editAdminUpdateBtn_Click);
            // 
            // editAdminIdSearchBtn
            // 
            this.editAdminIdSearchBtn.Location = new System.Drawing.Point(126, 24);
            this.editAdminIdSearchBtn.Name = "editAdminIdSearchBtn";
            this.editAdminIdSearchBtn.Size = new System.Drawing.Size(61, 23);
            this.editAdminIdSearchBtn.TabIndex = 22;
            this.editAdminIdSearchBtn.Text = "Sök";
            this.editAdminIdSearchBtn.UseVisualStyleBackColor = true;
            this.editAdminIdSearchBtn.Click += new System.EventHandler(this.editAdminIdSearchBtn_Click);
            // 
            // editAdminMailTxt
            // 
            this.editAdminMailTxt.Enabled = false;
            this.editAdminMailTxt.Location = new System.Drawing.Point(339, 26);
            this.editAdminMailTxt.Name = "editAdminMailTxt";
            this.editAdminMailTxt.Size = new System.Drawing.Size(159, 20);
            this.editAdminMailTxt.TabIndex = 20;
            // 
            // editAdminIdLbl
            // 
            this.editAdminIdLbl.AutoSize = true;
            this.editAdminIdLbl.Location = new System.Drawing.Point(14, 29);
            this.editAdminIdLbl.Name = "editAdminIdLbl";
            this.editAdminIdLbl.Size = new System.Drawing.Size(43, 13);
            this.editAdminIdLbl.TabIndex = 15;
            this.editAdminIdLbl.Text = "Initialer:";
            // 
            // editAdminIdTxt
            // 
            this.editAdminIdTxt.Location = new System.Drawing.Point(63, 26);
            this.editAdminIdTxt.Name = "editAdminIdTxt";
            this.editAdminIdTxt.Size = new System.Drawing.Size(57, 20);
            this.editAdminIdTxt.TabIndex = 14;
            // 
            // editAdminPhoneLbl
            // 
            this.editAdminPhoneLbl.AutoSize = true;
            this.editAdminPhoneLbl.Location = new System.Drawing.Point(250, 58);
            this.editAdminPhoneLbl.Name = "editAdminPhoneLbl";
            this.editAdminPhoneLbl.Size = new System.Drawing.Size(83, 13);
            this.editAdminPhoneLbl.TabIndex = 18;
            this.editAdminPhoneLbl.Text = "Telefonnummer:";
            // 
            // editAdminPhoneTxt
            // 
            this.editAdminPhoneTxt.Enabled = false;
            this.editAdminPhoneTxt.Location = new System.Drawing.Point(339, 55);
            this.editAdminPhoneTxt.Name = "editAdminPhoneTxt";
            this.editAdminPhoneTxt.Size = new System.Drawing.Size(159, 20);
            this.editAdminPhoneTxt.TabIndex = 21;
            // 
            // editAdminMailLbl
            // 
            this.editAdminMailLbl.AutoSize = true;
            this.editAdminMailLbl.Location = new System.Drawing.Point(295, 29);
            this.editAdminMailLbl.Name = "editAdminMailLbl";
            this.editAdminMailLbl.Size = new System.Drawing.Size(38, 13);
            this.editAdminMailLbl.TabIndex = 17;
            this.editAdminMailLbl.Text = "E-mail:";
            // 
            // editAdminNameTxt
            // 
            this.editAdminNameTxt.Enabled = false;
            this.editAdminNameTxt.Location = new System.Drawing.Point(63, 55);
            this.editAdminNameTxt.Name = "editAdminNameTxt";
            this.editAdminNameTxt.Size = new System.Drawing.Size(156, 20);
            this.editAdminNameTxt.TabIndex = 19;
            // 
            // editAdminNameLbl
            // 
            this.editAdminNameLbl.AutoSize = true;
            this.editAdminNameLbl.Location = new System.Drawing.Point(19, 58);
            this.editAdminNameLbl.Name = "editAdminNameLbl";
            this.editAdminNameLbl.Size = new System.Drawing.Size(38, 13);
            this.editAdminNameLbl.TabIndex = 16;
            this.editAdminNameLbl.Text = "Namn:";
            // 
            // addAdminBox
            // 
            this.addAdminBox.Controls.Add(this.addAdminMailTxt);
            this.addAdminBox.Controls.Add(this.returnMsgLbl);
            this.addAdminBox.Controls.Add(this.addAdminBtn);
            this.addAdminBox.Controls.Add(this.addAdminIdTxt);
            this.addAdminBox.Controls.Add(this.addAdminPhoneTxt);
            this.addAdminBox.Controls.Add(this.addAdminIdLbl);
            this.addAdminBox.Controls.Add(this.addAdminNameLbl);
            this.addAdminBox.Controls.Add(this.addAdminNameTxt);
            this.addAdminBox.Controls.Add(this.addAdminMailLbl);
            this.addAdminBox.Controls.Add(this.addAdminPhoneLbl);
            this.addAdminBox.Location = new System.Drawing.Point(18, 15);
            this.addAdminBox.Name = "addAdminBox";
            this.addAdminBox.Size = new System.Drawing.Size(511, 134);
            this.addAdminBox.TabIndex = 15;
            this.addAdminBox.TabStop = false;
            this.addAdminBox.Text = "Skapa handläggare";
            // 
            // addAdminMailTxt
            // 
            this.addAdminMailTxt.Location = new System.Drawing.Point(339, 25);
            this.addAdminMailTxt.Name = "addAdminMailTxt";
            this.addAdminMailTxt.Size = new System.Drawing.Size(159, 20);
            this.addAdminMailTxt.TabIndex = 8;
            // 
            // returnMsgLbl
            // 
            this.returnMsgLbl.AutoSize = true;
            this.returnMsgLbl.Location = new System.Drawing.Point(9, 159);
            this.returnMsgLbl.Name = "returnMsgLbl";
            this.returnMsgLbl.Size = new System.Drawing.Size(0, 13);
            this.returnMsgLbl.TabIndex = 13;
            // 
            // addAdminBtn
            // 
            this.addAdminBtn.Location = new System.Drawing.Point(63, 86);
            this.addAdminBtn.Name = "addAdminBtn";
            this.addAdminBtn.Size = new System.Drawing.Size(75, 23);
            this.addAdminBtn.TabIndex = 0;
            this.addAdminBtn.Text = "Skapa";
            this.addAdminBtn.UseVisualStyleBackColor = true;
            this.addAdminBtn.Click += new System.EventHandler(this.addAdminBtn_Click);
            // 
            // addAdminIdTxt
            // 
            this.addAdminIdTxt.Location = new System.Drawing.Point(63, 25);
            this.addAdminIdTxt.Name = "addAdminIdTxt";
            this.addAdminIdTxt.Size = new System.Drawing.Size(57, 20);
            this.addAdminIdTxt.TabIndex = 1;
            // 
            // addAdminPhoneTxt
            // 
            this.addAdminPhoneTxt.Location = new System.Drawing.Point(339, 54);
            this.addAdminPhoneTxt.Name = "addAdminPhoneTxt";
            this.addAdminPhoneTxt.Size = new System.Drawing.Size(159, 20);
            this.addAdminPhoneTxt.TabIndex = 9;
            // 
            // addAdminIdLbl
            // 
            this.addAdminIdLbl.AutoSize = true;
            this.addAdminIdLbl.Location = new System.Drawing.Point(14, 28);
            this.addAdminIdLbl.Name = "addAdminIdLbl";
            this.addAdminIdLbl.Size = new System.Drawing.Size(43, 13);
            this.addAdminIdLbl.TabIndex = 3;
            this.addAdminIdLbl.Text = "Initialer:";
            // 
            // addAdminNameLbl
            // 
            this.addAdminNameLbl.AutoSize = true;
            this.addAdminNameLbl.Location = new System.Drawing.Point(19, 57);
            this.addAdminNameLbl.Name = "addAdminNameLbl";
            this.addAdminNameLbl.Size = new System.Drawing.Size(38, 13);
            this.addAdminNameLbl.TabIndex = 4;
            this.addAdminNameLbl.Text = "Namn:";
            // 
            // addAdminNameTxt
            // 
            this.addAdminNameTxt.Location = new System.Drawing.Point(63, 54);
            this.addAdminNameTxt.Name = "addAdminNameTxt";
            this.addAdminNameTxt.Size = new System.Drawing.Size(156, 20);
            this.addAdminNameTxt.TabIndex = 7;
            // 
            // addAdminMailLbl
            // 
            this.addAdminMailLbl.AutoSize = true;
            this.addAdminMailLbl.Location = new System.Drawing.Point(295, 28);
            this.addAdminMailLbl.Name = "addAdminMailLbl";
            this.addAdminMailLbl.Size = new System.Drawing.Size(38, 13);
            this.addAdminMailLbl.TabIndex = 5;
            this.addAdminMailLbl.Text = "E-mail:";
            // 
            // addAdminPhoneLbl
            // 
            this.addAdminPhoneLbl.AutoSize = true;
            this.addAdminPhoneLbl.Location = new System.Drawing.Point(250, 57);
            this.addAdminPhoneLbl.Name = "addAdminPhoneLbl";
            this.addAdminPhoneLbl.Size = new System.Drawing.Size(83, 13);
            this.addAdminPhoneLbl.TabIndex = 6;
            this.addAdminPhoneLbl.Text = "Telefonnummer:";
            // 
            // addContractBox
            // 
            this.addContractBox.Controls.Add(this.explainAddContractLbl);
            this.addContractBox.Controls.Add(this.laddaAvtalBtn);
            this.addContractBox.Controls.Add(this.avtalsnrLbl);
            this.addContractBox.Controls.Add(this.avtalsnrTxt);
            this.addContractBox.Location = new System.Drawing.Point(12, 15);
            this.addContractBox.Name = "addContractBox";
            this.addContractBox.Size = new System.Drawing.Size(448, 125);
            this.addContractBox.TabIndex = 12;
            this.addContractBox.TabStop = false;
            this.addContractBox.Text = "Skapa Avtal";
            // 
            // explainAddContractLbl
            // 
            this.explainAddContractLbl.AutoSize = true;
            this.explainAddContractLbl.Location = new System.Drawing.Point(20, 25);
            this.explainAddContractLbl.Name = "explainAddContractLbl";
            this.explainAddContractLbl.Size = new System.Drawing.Size(381, 26);
            this.explainAddContractLbl.TabIndex = 11;
            this.explainAddContractLbl.Text = "Skapa ett nytt avtal genom att skriva in avtalsnummer, klicka på \"Skapa avtal\" \r\n" +
    "och sedan välja aktiv RS-lista.";
            // 
            // editAdminClearFieldsBtn
            // 
            this.editAdminClearFieldsBtn.Location = new System.Drawing.Point(63, 119);
            this.editAdminClearFieldsBtn.Name = "editAdminClearFieldsBtn";
            this.editAdminClearFieldsBtn.Size = new System.Drawing.Size(75, 23);
            this.editAdminClearFieldsBtn.TabIndex = 25;
            this.editAdminClearFieldsBtn.Text = "Rensa fält";
            this.editAdminClearFieldsBtn.UseVisualStyleBackColor = true;
            this.editAdminClearFieldsBtn.Click += new System.EventHandler(this.editAdminClearFieldsBtn_Click);
            // 
            // RegionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 403);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegionView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avtalsprogram 2016 Region Skåne";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.editAdminBox.ResumeLayout(false);
            this.editAdminBox.PerformLayout();
            this.addAdminBox.ResumeLayout(false);
            this.addAdminBox.PerformLayout();
            this.addContractBox.ResumeLayout(false);
            this.addContractBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox avtalsnrTxt;
        private System.Windows.Forms.Label avtalsnrLbl;
        private System.Windows.Forms.Button laddaAvtalBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem apaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dsadasToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem avslutaProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handläggareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leverantörToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artikelgruppToolStripMenuItem;
        private System.Windows.Forms.GroupBox addContractBox;
        private System.Windows.Forms.Label explainAddContractLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox editAdminBox;
        private System.Windows.Forms.Button editAdminDeleteBtn;
        private System.Windows.Forms.Button editAdminUpdateBtn;
        private System.Windows.Forms.Button editAdminIdSearchBtn;
        private System.Windows.Forms.TextBox editAdminMailTxt;
        private System.Windows.Forms.Label editAdminIdLbl;
        private System.Windows.Forms.TextBox editAdminIdTxt;
        private System.Windows.Forms.Label editAdminPhoneLbl;
        private System.Windows.Forms.TextBox editAdminPhoneTxt;
        private System.Windows.Forms.Label editAdminMailLbl;
        private System.Windows.Forms.TextBox editAdminNameTxt;
        private System.Windows.Forms.Label editAdminNameLbl;
        private System.Windows.Forms.GroupBox addAdminBox;
        private System.Windows.Forms.TextBox addAdminMailTxt;
        private System.Windows.Forms.Label returnMsgLbl;
        private System.Windows.Forms.Button addAdminBtn;
        private System.Windows.Forms.TextBox addAdminIdTxt;
        private System.Windows.Forms.TextBox addAdminPhoneTxt;
        private System.Windows.Forms.Label addAdminIdLbl;
        private System.Windows.Forms.Label addAdminNameLbl;
        private System.Windows.Forms.TextBox addAdminNameTxt;
        private System.Windows.Forms.Label addAdminMailLbl;
        private System.Windows.Forms.Label addAdminPhoneLbl;
        private System.Windows.Forms.Label editAdminMsgLbl;
        private System.Windows.Forms.Button editAdminClearFieldsBtn;
    }
}

