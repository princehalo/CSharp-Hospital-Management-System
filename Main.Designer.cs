namespace EDI_Hospital_Management_System
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sideMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.primLogoBox = new System.Windows.Forms.PictureBox();
            this.adminMnuBtn = new System.Windows.Forms.Button();
            this.cshUnitBtn = new System.Windows.Forms.Button();
            this.hmoNhisAcctBtn = new System.Windows.Forms.Button();
            this.patientsBtn = new System.Windows.Forms.Button();
            this.DptBtn = new System.Windows.Forms.Button();
            this.frontDeskBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.minButton = new System.Windows.Forms.Button();
            this.DtLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.DtTimer = new System.Windows.Forms.Timer(this.components);
            this.patientDetails1 = new EDI_Hospital_Management_System.PatientDetails();
            this.appointments1 = new EDI_Hospital_Management_System.Appointments();
            this.newPatient1 = new EDI_Hospital_Management_System.NewPatient();
            this.fDeskMenu1 = new EDI_Hospital_Management_System.FDeskMenu();
            this.patientsMenu1 = new EDI_Hospital_Management_System.PatientsMenu();
            this.hmoNhisAcct1 = new EDI_Hospital_Management_System.hmoNhisAcct();
            this.cashUnit1 = new EDI_Hospital_Management_System.CashUnit();
            this.adminMenu1 = new EDI_Hospital_Management_System.AdminMenu();
            this.dptMenu1 = new EDI_Hospital_Management_System.DptMenu();
            this.sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.primLogoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenu
            // 
            this.sideMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sideMenu.BackgroundImage")));
            this.sideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sideMenu.Controls.Add(this.label1);
            this.sideMenu.Controls.Add(this.primLogoBox);
            this.sideMenu.Controls.Add(this.adminMnuBtn);
            this.sideMenu.Controls.Add(this.cshUnitBtn);
            this.sideMenu.Controls.Add(this.hmoNhisAcctBtn);
            this.sideMenu.Controls.Add(this.patientsBtn);
            this.sideMenu.Controls.Add(this.DptBtn);
            this.sideMenu.Controls.Add(this.frontDeskBtn);
            this.sideMenu.Controls.Add(this.homeBtn);
            this.sideMenu.Controls.Add(this.logoBox);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 0);
            this.sideMenu.MaximumSize = new System.Drawing.Size(207, 650);
            this.sideMenu.MinimumSize = new System.Drawing.Size(46, 650);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(188, 650);
            this.sideMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 625);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Developed by:";
            // 
            // primLogoBox
            // 
            this.primLogoBox.BackColor = System.Drawing.Color.Transparent;
            this.primLogoBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("primLogoBox.BackgroundImage")));
            this.primLogoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.primLogoBox.Enabled = false;
            this.primLogoBox.Location = new System.Drawing.Point(153, 616);
            this.primLogoBox.Name = "primLogoBox";
            this.primLogoBox.Size = new System.Drawing.Size(32, 32);
            this.primLogoBox.TabIndex = 1;
            this.primLogoBox.TabStop = false;
            // 
            // adminMnuBtn
            // 
            this.adminMnuBtn.BackColor = System.Drawing.Color.Transparent;
            this.adminMnuBtn.FlatAppearance.BorderSize = 0;
            this.adminMnuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminMnuBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminMnuBtn.ForeColor = System.Drawing.Color.White;
            this.adminMnuBtn.Image = ((System.Drawing.Image)(resources.GetObject("adminMnuBtn.Image")));
            this.adminMnuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminMnuBtn.Location = new System.Drawing.Point(0, 398);
            this.adminMnuBtn.Name = "adminMnuBtn";
            this.adminMnuBtn.Size = new System.Drawing.Size(188, 51);
            this.adminMnuBtn.TabIndex = 1;
            this.adminMnuBtn.Text = "   ADMINISTRATION";
            this.adminMnuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adminMnuBtn.UseVisualStyleBackColor = false;
            this.adminMnuBtn.Click += new System.EventHandler(this.adminMnuBtn_Click);
            // 
            // cshUnitBtn
            // 
            this.cshUnitBtn.BackColor = System.Drawing.Color.Transparent;
            this.cshUnitBtn.FlatAppearance.BorderSize = 0;
            this.cshUnitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cshUnitBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cshUnitBtn.ForeColor = System.Drawing.Color.White;
            this.cshUnitBtn.Image = ((System.Drawing.Image)(resources.GetObject("cshUnitBtn.Image")));
            this.cshUnitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cshUnitBtn.Location = new System.Drawing.Point(0, 341);
            this.cshUnitBtn.Name = "cshUnitBtn";
            this.cshUnitBtn.Size = new System.Drawing.Size(188, 51);
            this.cshUnitBtn.TabIndex = 1;
            this.cshUnitBtn.Text = "   CASH UNIT";
            this.cshUnitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cshUnitBtn.UseVisualStyleBackColor = false;
            this.cshUnitBtn.Click += new System.EventHandler(this.cshUnitBtn_Click);
            // 
            // hmoNhisAcctBtn
            // 
            this.hmoNhisAcctBtn.BackColor = System.Drawing.Color.Transparent;
            this.hmoNhisAcctBtn.FlatAppearance.BorderSize = 0;
            this.hmoNhisAcctBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hmoNhisAcctBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmoNhisAcctBtn.ForeColor = System.Drawing.Color.White;
            this.hmoNhisAcctBtn.Image = ((System.Drawing.Image)(resources.GetObject("hmoNhisAcctBtn.Image")));
            this.hmoNhisAcctBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hmoNhisAcctBtn.Location = new System.Drawing.Point(0, 287);
            this.hmoNhisAcctBtn.Name = "hmoNhisAcctBtn";
            this.hmoNhisAcctBtn.Size = new System.Drawing.Size(188, 51);
            this.hmoNhisAcctBtn.TabIndex = 1;
            this.hmoNhisAcctBtn.Text = "   HMO/NHIS\r\n    ACCOUNTS";
            this.hmoNhisAcctBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.hmoNhisAcctBtn.UseVisualStyleBackColor = false;
            this.hmoNhisAcctBtn.Click += new System.EventHandler(this.hmoNhisAcctBtn_Click);
            // 
            // patientsBtn
            // 
            this.patientsBtn.BackColor = System.Drawing.Color.Transparent;
            this.patientsBtn.FlatAppearance.BorderSize = 0;
            this.patientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientsBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsBtn.ForeColor = System.Drawing.Color.White;
            this.patientsBtn.Image = ((System.Drawing.Image)(resources.GetObject("patientsBtn.Image")));
            this.patientsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientsBtn.Location = new System.Drawing.Point(0, 233);
            this.patientsBtn.Name = "patientsBtn";
            this.patientsBtn.Size = new System.Drawing.Size(188, 51);
            this.patientsBtn.TabIndex = 1;
            this.patientsBtn.Text = "   PATIENTS";
            this.patientsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.patientsBtn.UseVisualStyleBackColor = false;
            this.patientsBtn.Click += new System.EventHandler(this.patientsBtn_Click);
            // 
            // DptBtn
            // 
            this.DptBtn.BackColor = System.Drawing.Color.Transparent;
            this.DptBtn.FlatAppearance.BorderSize = 0;
            this.DptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DptBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DptBtn.ForeColor = System.Drawing.Color.White;
            this.DptBtn.Image = ((System.Drawing.Image)(resources.GetObject("DptBtn.Image")));
            this.DptBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DptBtn.Location = new System.Drawing.Point(0, 183);
            this.DptBtn.Name = "DptBtn";
            this.DptBtn.Size = new System.Drawing.Size(188, 51);
            this.DptBtn.TabIndex = 1;
            this.DptBtn.Text = "   DEPARTMENTS";
            this.DptBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DptBtn.UseVisualStyleBackColor = false;
            this.DptBtn.Click += new System.EventHandler(this.DptBtn_Click);
            // 
            // frontDeskBtn
            // 
            this.frontDeskBtn.BackColor = System.Drawing.Color.Transparent;
            this.frontDeskBtn.FlatAppearance.BorderSize = 0;
            this.frontDeskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frontDeskBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frontDeskBtn.ForeColor = System.Drawing.Color.White;
            this.frontDeskBtn.Image = ((System.Drawing.Image)(resources.GetObject("frontDeskBtn.Image")));
            this.frontDeskBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.frontDeskBtn.Location = new System.Drawing.Point(0, 133);
            this.frontDeskBtn.Name = "frontDeskBtn";
            this.frontDeskBtn.Size = new System.Drawing.Size(188, 51);
            this.frontDeskBtn.TabIndex = 1;
            this.frontDeskBtn.Text = "   FRONT DESK";
            this.frontDeskBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.frontDeskBtn.UseVisualStyleBackColor = false;
            this.frontDeskBtn.Click += new System.EventHandler(this.frontDeskBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(0, 83);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(188, 51);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "   HOME";
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.Color.Transparent;
            this.logoBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoBox.BackgroundImage")));
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(0, 0);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(188, 77);
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            // 
            // minButton
            // 
            this.minButton.BackColor = System.Drawing.Color.Transparent;
            this.minButton.FlatAppearance.BorderSize = 0;
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Image = ((System.Drawing.Image)(resources.GetObject("minButton.Image")));
            this.minButton.Location = new System.Drawing.Point(992, 0);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(34, 34);
            this.minButton.TabIndex = 1;
            this.minButton.UseVisualStyleBackColor = false;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // DtLabel
            // 
            this.DtLabel.AutoSize = true;
            this.DtLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtLabel.ForeColor = System.Drawing.Color.White;
            this.DtLabel.Location = new System.Drawing.Point(217, 9);
            this.DtLabel.Name = "DtLabel";
            this.DtLabel.Size = new System.Drawing.Size(0, 19);
            this.DtLabel.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1028, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(34, 34);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(519, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 19);
            this.TimeLabel.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopPanel.BackgroundImage")));
            this.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopPanel.Controls.Add(this.TimeLabel);
            this.TopPanel.Controls.Add(this.closeButton);
            this.TopPanel.Controls.Add(this.DtLabel);
            this.TopPanel.Controls.Add(this.minButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(188, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1062, 35);
            this.TopPanel.TabIndex = 5;
            // 
            // DtTimer
            // 
            this.DtTimer.Tick += new System.EventHandler(this.DtTimer_Tick);
            // 
            // patientDetails1
            // 
            this.patientDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientDetails1.Location = new System.Drawing.Point(188, 35);
            this.patientDetails1.MaximumSize = new System.Drawing.Size(1062, 615);
            this.patientDetails1.Name = "patientDetails1";
            this.patientDetails1.Size = new System.Drawing.Size(1062, 615);
            this.patientDetails1.TabIndex = 15;
            this.patientDetails1.Visible = false;
            // 
            // appointments1
            // 
            this.appointments1.Location = new System.Drawing.Point(188, 35);
            this.appointments1.MaximumSize = new System.Drawing.Size(1062, 615);
            this.appointments1.Name = "appointments1";
            this.appointments1.Size = new System.Drawing.Size(1062, 615);
            this.appointments1.TabIndex = 14;
            this.appointments1.Visible = false;
            // 
            // newPatient1
            // 
            this.newPatient1.BackColor = System.Drawing.SystemColors.Control;
            this.newPatient1.Location = new System.Drawing.Point(188, 35);
            this.newPatient1.MaximumSize = new System.Drawing.Size(1062, 615);
            this.newPatient1.Name = "newPatient1";
            this.newPatient1.Size = new System.Drawing.Size(1062, 615);
            this.newPatient1.TabIndex = 13;
            this.newPatient1.Visible = false;
            // 
            // fDeskMenu1
            // 
            this.fDeskMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.fDeskMenu1.Location = new System.Drawing.Point(187, 35);
            this.fDeskMenu1.MaximumSize = new System.Drawing.Size(217, 615);
            this.fDeskMenu1.Name = "fDeskMenu1";
            this.fDeskMenu1.Size = new System.Drawing.Size(217, 615);
            this.fDeskMenu1.TabIndex = 7;
            this.fDeskMenu1.Visible = false;
            // 
            // patientsMenu1
            // 
            this.patientsMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.patientsMenu1.Location = new System.Drawing.Point(187, 35);
            this.patientsMenu1.MaximumSize = new System.Drawing.Size(217, 615);
            this.patientsMenu1.Name = "patientsMenu1";
            this.patientsMenu1.Size = new System.Drawing.Size(217, 615);
            this.patientsMenu1.TabIndex = 9;
            this.patientsMenu1.Visible = false;
            // 
            // hmoNhisAcct1
            // 
            this.hmoNhisAcct1.BackColor = System.Drawing.Color.White;
            this.hmoNhisAcct1.Location = new System.Drawing.Point(188, 35);
            this.hmoNhisAcct1.Name = "hmoNhisAcct1";
            this.hmoNhisAcct1.Size = new System.Drawing.Size(1062, 615);
            this.hmoNhisAcct1.TabIndex = 12;
            this.hmoNhisAcct1.Visible = false;
            // 
            // cashUnit1
            // 
            this.cashUnit1.BackColor = System.Drawing.SystemColors.Control;
            this.cashUnit1.Location = new System.Drawing.Point(188, 35);
            this.cashUnit1.MaximumSize = new System.Drawing.Size(1062, 615);
            this.cashUnit1.Name = "cashUnit1";
            this.cashUnit1.Size = new System.Drawing.Size(1062, 615);
            this.cashUnit1.TabIndex = 11;
            this.cashUnit1.Visible = false;
            // 
            // adminMenu1
            // 
            this.adminMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.adminMenu1.Location = new System.Drawing.Point(187, 35);
            this.adminMenu1.Name = "adminMenu1";
            this.adminMenu1.Size = new System.Drawing.Size(217, 615);
            this.adminMenu1.TabIndex = 10;
            this.adminMenu1.Visible = false;
            // 
            // dptMenu1
            // 
            this.dptMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dptMenu1.Location = new System.Drawing.Point(187, 35);
            this.dptMenu1.MaximumSize = new System.Drawing.Size(217, 615);
            this.dptMenu1.Name = "dptMenu1";
            this.dptMenu1.Size = new System.Drawing.Size(217, 615);
            this.dptMenu1.TabIndex = 8;
            this.dptMenu1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 650);
            this.Controls.Add(this.patientDetails1);
            this.Controls.Add(this.appointments1);
            this.Controls.Add(this.newPatient1);
            this.Controls.Add(this.fDeskMenu1);
            this.Controls.Add(this.patientsMenu1);
            this.Controls.Add(this.hmoNhisAcct1);
            this.Controls.Add(this.cashUnit1);
            this.Controls.Add(this.adminMenu1);
            this.Controls.Add(this.dptMenu1);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.sideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.sideMenu.ResumeLayout(false);
            this.sideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.primLogoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Button hmoNhisAcctBtn;
        private System.Windows.Forms.Button patientsBtn;
        private System.Windows.Forms.Button DptBtn;
        private System.Windows.Forms.Button frontDeskBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button cshUnitBtn;
        private System.Windows.Forms.PictureBox primLogoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Label DtLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Timer DtTimer;
        private System.Windows.Forms.Button adminMnuBtn;
        private FDeskMenu fDeskMenu1;
        private DptMenu dptMenu1;
        private PatientsMenu patientsMenu1;
        private AdminMenu adminMenu1;
        private CashUnit cashUnit1;
        private hmoNhisAcct hmoNhisAcct1;
        private NewPatient newPatient1;
        private Appointments appointments1;
        private PatientDetails patientDetails1;
    }
}

