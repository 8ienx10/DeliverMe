namespace deliverMe
{
    partial class signIn
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtboxID = new System.Windows.Forms.TextBox();
            this.txtboxPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblSignin = new System.Windows.Forms.Label();
            this.lblor = new System.Windows.Forms.Label();
            this.linklblCreate = new System.Windows.Forms.LinkLabel();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.picboxTitle = new System.Windows.Forms.PictureBox();
            this.btnTheme = new System.Windows.Forms.Button();
            this.btnSignin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(197, 438);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(141, 25);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ادخل رقمك الجامعي";
            // 
            // txtboxID
            // 
            this.txtboxID.Location = new System.Drawing.Point(12, 466);
            this.txtboxID.Multiline = true;
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.Size = new System.Drawing.Size(320, 30);
            this.txtboxID.TabIndex = 6;
            this.txtboxID.TabStop = false;
            // 
            // txtboxPass
            // 
            this.txtboxPass.Location = new System.Drawing.Point(12, 552);
            this.txtboxPass.Multiline = true;
            this.txtboxPass.Name = "txtboxPass";
            this.txtboxPass.Size = new System.Drawing.Size(320, 30);
            this.txtboxPass.TabIndex = 8;
            this.txtboxPass.TabStop = false;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(227, 524);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(111, 25);
            this.lblPass.TabIndex = 11;
            this.lblPass.Text = "ادخل كلمة السر";
            // 
            // lblSignin
            // 
            this.lblSignin.AutoSize = true;
            this.lblSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignin.Location = new System.Drawing.Point(133, 338);
            this.lblSignin.Name = "lblSignin";
            this.lblSignin.Size = new System.Drawing.Size(208, 46);
            this.lblSignin.TabIndex = 12;
            this.lblSignin.Text = "تسجيل الدخول";
            // 
            // lblor
            // 
            this.lblor.AutoSize = true;
            this.lblor.Location = new System.Drawing.Point(316, 388);
            this.lblor.Name = "lblor";
            this.lblor.Size = new System.Drawing.Size(16, 13);
            this.lblor.TabIndex = 13;
            this.lblor.Text = "او";
            // 
            // linklblCreate
            // 
            this.linklblCreate.AutoSize = true;
            this.linklblCreate.Location = new System.Drawing.Point(231, 388);
            this.linklblCreate.Name = "linklblCreate";
            this.linklblCreate.Size = new System.Drawing.Size(88, 13);
            this.linklblCreate.TabIndex = 14;
            this.linklblCreate.TabStop = true;
            this.linklblCreate.Text = "انشاء حساب جديد";
            this.linklblCreate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblCreate_LinkClicked_1);
            // 
            // btnLanguage
            // 
            this.btnLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.Location = new System.Drawing.Point(67, 1);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(60, 60);
            this.btnLanguage.TabIndex = 2;
            this.btnLanguage.Text = "ع";
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // picboxTitle
            // 
            this.picboxTitle.Image = global::deliverMe.Properties.Resources.titleDarkMode;
            this.picboxTitle.Location = new System.Drawing.Point(12, 78);
            this.picboxTitle.Name = "picboxTitle";
            this.picboxTitle.Size = new System.Drawing.Size(320, 220);
            this.picboxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxTitle.TabIndex = 9;
            this.picboxTitle.TabStop = false;
            // 
            // btnTheme
            // 
            this.btnTheme.Image = global::deliverMe.Properties.Resources.sun;
            this.btnTheme.Location = new System.Drawing.Point(1, 1);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(60, 60);
            this.btnTheme.TabIndex = 1;
            this.btnTheme.UseVisualStyleBackColor = true;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // btnSignin
            // 
            this.btnSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.Location = new System.Drawing.Point(12, 627);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(320, 30);
            this.btnSignin.TabIndex = 15;
            this.btnSignin.Text = "Sign in";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // signIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 761);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.linklblCreate);
            this.Controls.Add(this.lblor);
            this.Controls.Add(this.lblSignin);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.picboxTitle);
            this.Controls.Add(this.txtboxPass);
            this.Controls.Add(this.txtboxID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnTheme);
            this.Name = "signIn";
            this.Text = "وصلني";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeApp);
            this.Load += new System.EventHandler(this.signIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtboxID;
        private System.Windows.Forms.TextBox txtboxPass;
        private System.Windows.Forms.PictureBox picboxTitle;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblSignin;
        private System.Windows.Forms.Label lblor;
        private System.Windows.Forms.LinkLabel linklblCreate;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.Button btnSignin;
    }
}

