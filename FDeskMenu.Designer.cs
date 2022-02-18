namespace EDI_Hospital_Management_System
{
    partial class FDeskMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDeskMenu));
            this.patGenRegBtn = new System.Windows.Forms.Button();
            this.newPatBtn = new System.Windows.Forms.Button();
            this.appntmentBtn = new System.Windows.Forms.Button();
            this.atendcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patGenRegBtn
            // 
            this.patGenRegBtn.BackColor = System.Drawing.Color.Transparent;
            this.patGenRegBtn.FlatAppearance.BorderSize = 0;
            this.patGenRegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patGenRegBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patGenRegBtn.ForeColor = System.Drawing.Color.White;
            this.patGenRegBtn.Image = ((System.Drawing.Image)(resources.GetObject("patGenRegBtn.Image")));
            this.patGenRegBtn.Location = new System.Drawing.Point(108, 108);
            this.patGenRegBtn.Name = "patGenRegBtn";
            this.patGenRegBtn.Size = new System.Drawing.Size(108, 108);
            this.patGenRegBtn.TabIndex = 1;
            this.patGenRegBtn.Text = "PATIENT\'S GENERAL REGISTER";
            this.patGenRegBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.patGenRegBtn.UseVisualStyleBackColor = false;
            // 
            // newPatBtn
            // 
            this.newPatBtn.BackColor = System.Drawing.Color.Transparent;
            this.newPatBtn.FlatAppearance.BorderSize = 0;
            this.newPatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPatBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatBtn.ForeColor = System.Drawing.Color.White;
            this.newPatBtn.Image = ((System.Drawing.Image)(resources.GetObject("newPatBtn.Image")));
            this.newPatBtn.Location = new System.Drawing.Point(108, 1);
            this.newPatBtn.Name = "newPatBtn";
            this.newPatBtn.Size = new System.Drawing.Size(108, 108);
            this.newPatBtn.TabIndex = 2;
            this.newPatBtn.Text = "ADD NEW PATIENT DATA";
            this.newPatBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newPatBtn.UseVisualStyleBackColor = false;
            this.newPatBtn.Click += new System.EventHandler(this.newPatBtn_Click);
            this.newPatBtn.Enter += new System.EventHandler(this.newPatBtn_Enter);
            this.newPatBtn.Leave += new System.EventHandler(this.newPatBtn_Leave);
            // 
            // appntmentBtn
            // 
            this.appntmentBtn.BackColor = System.Drawing.Color.Transparent;
            this.appntmentBtn.FlatAppearance.BorderSize = 0;
            this.appntmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appntmentBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appntmentBtn.ForeColor = System.Drawing.Color.White;
            this.appntmentBtn.Image = ((System.Drawing.Image)(resources.GetObject("appntmentBtn.Image")));
            this.appntmentBtn.Location = new System.Drawing.Point(1, 108);
            this.appntmentBtn.Name = "appntmentBtn";
            this.appntmentBtn.Size = new System.Drawing.Size(108, 108);
            this.appntmentBtn.TabIndex = 3;
            this.appntmentBtn.Text = "APPOINTMENT";
            this.appntmentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.appntmentBtn.UseVisualStyleBackColor = false;
            // 
            // atendcBtn
            // 
            this.atendcBtn.BackColor = System.Drawing.Color.Transparent;
            this.atendcBtn.FlatAppearance.BorderSize = 0;
            this.atendcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atendcBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atendcBtn.ForeColor = System.Drawing.Color.White;
            this.atendcBtn.Image = ((System.Drawing.Image)(resources.GetObject("atendcBtn.Image")));
            this.atendcBtn.Location = new System.Drawing.Point(1, 1);
            this.atendcBtn.Name = "atendcBtn";
            this.atendcBtn.Size = new System.Drawing.Size(108, 108);
            this.atendcBtn.TabIndex = 4;
            this.atendcBtn.Text = "ATTENDANCE";
            this.atendcBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.atendcBtn.UseVisualStyleBackColor = false;
            // 
            // FDeskMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.patGenRegBtn);
            this.Controls.Add(this.newPatBtn);
            this.Controls.Add(this.appntmentBtn);
            this.Controls.Add(this.atendcBtn);
            this.MaximumSize = new System.Drawing.Size(217, 615);
            this.Name = "FDeskMenu";
            this.Size = new System.Drawing.Size(217, 615);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button patGenRegBtn;
        private System.Windows.Forms.Button newPatBtn;
        private System.Windows.Forms.Button appntmentBtn;
        private System.Windows.Forms.Button atendcBtn;
    }
}
