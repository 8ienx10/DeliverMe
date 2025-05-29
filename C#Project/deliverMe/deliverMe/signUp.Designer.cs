namespace deliverMe
{
    partial class signUp
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
            this.btnLanguage = new System.Windows.Forms.Button();
            this.lblSignup = new System.Windows.Forms.Label();
            this.lblor = new System.Windows.Forms.Label();
            this.linklblCreate = new System.Windows.Forms.LinkLabel();
            this.lblID = new System.Windows.Forms.Label();
            this.txtboxID = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtboxPass = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.picboxTitle = new System.Windows.Forms.PictureBox();
            this.btnTheme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLanguage
            // 
            this.btnLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.Location = new System.Drawing.Point(67, 1);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(60, 60);
            this.btnLanguage.TabIndex = 3;
            this.btnLanguage.Text = "ع";
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // lblSignup
            // 
            this.lblSignup.AutoSize = true;
            this.lblSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignup.Location = new System.Drawing.Point(163, 338);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(183, 46);
            this.lblSignup.TabIndex = 13;
            this.lblSignup.Text = "انشاء حساب";
            // 
            // lblor
            // 
            this.lblor.AutoSize = true;
            this.lblor.Location = new System.Drawing.Point(12, 388);
            this.lblor.Name = "lblor";
            this.lblor.Size = new System.Drawing.Size(16, 13);
            this.lblor.TabIndex = 14;
            this.lblor.Text = "or";
            // 
            // linklblCreate
            // 
            this.linklblCreate.AutoSize = true;
            this.linklblCreate.Location = new System.Drawing.Point(25, 388);
            this.linklblCreate.Name = "linklblCreate";
            this.linklblCreate.Size = new System.Drawing.Size(37, 13);
            this.linklblCreate.TabIndex = 15;
            this.linklblCreate.TabStop = true;
            this.linklblCreate.Text = "sign in";
            this.linklblCreate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblCreate_LinkClicked);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(191, 438);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(141, 25);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "ادخل رقمك الجامعي";
            // 
            // txtboxID
            // 
            this.txtboxID.Location = new System.Drawing.Point(12, 466);
            this.txtboxID.Multiline = true;
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.Size = new System.Drawing.Size(320, 30);
            this.txtboxID.TabIndex = 17;
            this.txtboxID.TabStop = false;
            this.txtboxID.Click += new System.EventHandler(this.txtIDClick);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(221, 524);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(111, 25);
            this.lblPass.TabIndex = 18;
            this.lblPass.Text = "ادخل كلمة السر";
            // 
            // txtboxPass
            // 
            this.txtboxPass.Location = new System.Drawing.Point(15, 552);
            this.txtboxPass.Multiline = true;
            this.txtboxPass.Name = "txtboxPass";
            this.txtboxPass.Size = new System.Drawing.Size(317, 30);
            this.txtboxPass.TabIndex = 19;
            this.txtboxPass.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(127, 719);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 30);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            this.btnCreate.MouseHover += new System.EventHandler(this.btnCreateHover);
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(12, 638);
            this.txtboxName.Multiline = true;
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(208, 30);
            this.txtboxName.TabIndex = 20;
            this.txtboxName.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(156, 610);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(226, 638);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(317, 683);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(185, 684);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 13);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "الشروط والاحكام";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 683);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "اوافق على";
            // 
            // picboxTitle
            // 
            this.picboxTitle.Image = global::deliverMe.Properties.Resources.titleDarkMode;
            this.picboxTitle.Location = new System.Drawing.Point(12, 78);
            this.picboxTitle.Name = "picboxTitle";
            this.picboxTitle.Size = new System.Drawing.Size(320, 220);
            this.picboxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxTitle.TabIndex = 10;
            this.picboxTitle.TabStop = false;
            // 
            // btnTheme
            // 
            this.btnTheme.Image = global::deliverMe.Properties.Resources.sun;
            this.btnTheme.Location = new System.Drawing.Point(1, 1);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(60, 60);
            this.btnTheme.TabIndex = 4;
            this.btnTheme.UseVisualStyleBackColor = true;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // signUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtboxPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtboxID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.linklblCreate);
            this.Controls.Add(this.lblor);
            this.Controls.Add(this.lblSignup);
            this.Controls.Add(this.picboxTitle);
            this.Controls.Add(this.btnTheme);
            this.Controls.Add(this.btnLanguage);
            this.Name = "signUp";
            this.Text = "وصلني";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeApp);
            this.Load += new System.EventHandler(this.signUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.PictureBox picboxTitle;
        private System.Windows.Forms.Label lblSignup;
        private System.Windows.Forms.Label lblor;
        private System.Windows.Forms.LinkLabel linklblCreate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtboxID;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtboxPass;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;

    }
}