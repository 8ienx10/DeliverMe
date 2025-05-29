namespace deliverMe
{
    partial class SupdateForm
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
            this.lblSignup = new System.Windows.Forms.Label();
            this.picboxTitle = new System.Windows.Forms.PictureBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtboxPass = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSignup
            // 
            this.lblSignup.AutoSize = true;
            this.lblSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignup.Location = new System.Drawing.Point(112, 235);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(233, 46);
            this.lblSignup.TabIndex = 14;
            this.lblSignup.Text = "تحديث معلوماتي";
            // 
            // picboxTitle
            // 
            this.picboxTitle.Image = global::deliverMe.Properties.Resources.titleDarkMode;
            this.picboxTitle.Location = new System.Drawing.Point(12, 12);
            this.picboxTitle.Name = "picboxTitle";
            this.picboxTitle.Size = new System.Drawing.Size(320, 220);
            this.picboxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxTitle.TabIndex = 15;
            this.picboxTitle.TabStop = false;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(209, 356);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(123, 25);
            this.lblPass.TabIndex = 19;
            this.lblPass.Text = "كلمة السر الجديدة";
            // 
            // txtboxPass
            // 
            this.txtboxPass.Location = new System.Drawing.Point(12, 384);
            this.txtboxPass.Multiline = true;
            this.txtboxPass.Name = "txtboxPass";
            this.txtboxPass.Size = new System.Drawing.Size(317, 30);
            this.txtboxPass.TabIndex = 20;
            this.txtboxPass.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(241, 442);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 25);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "الاسم الجديد";
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(12, 470);
            this.txtboxName.Multiline = true;
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(317, 30);
            this.txtboxName.TabIndex = 23;
            this.txtboxName.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(9, 556);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(320, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(12, 683);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(323, 30);
            this.btnCreate.TabIndex = 25;
            this.btnCreate.Text = "Cencel";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "الجنس الجديد";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 647);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 30);
            this.button1.TabIndex = 27;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 719);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(323, 30);
            this.button2.TabIndex = 28;
            this.button2.Text = "Delete account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SupdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 761);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtboxPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.picboxTitle);
            this.Controls.Add(this.lblSignup);
            this.Name = "SupdateForm";
            this.Text = "وصلني";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SupdateForm_FormClosing);
            this.Load += new System.EventHandler(this.SupdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignup;
        private System.Windows.Forms.PictureBox picboxTitle;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtboxPass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}