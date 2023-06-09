namespace SessionPersonality
{
    partial class frm_Reg
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
            this.txt_SurnameN = new System.Windows.Forms.TextBox();
            this.txt_NameN = new System.Windows.Forms.TextBox();
            this.txt_PhoneN = new System.Windows.Forms.TextBox();
            this.txt_PassN = new System.Windows.Forms.TextBox();
            this.cmb_Cnt = new System.Windows.Forms.ComboBox();
            this.btn_Reg = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_LogN = new System.Windows.Forms.TextBox();
            this.pct_Avatar = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_SurnameN
            // 
            this.txt_SurnameN.Location = new System.Drawing.Point(184, 116);
            this.txt_SurnameN.Name = "txt_SurnameN";
            this.txt_SurnameN.Size = new System.Drawing.Size(146, 20);
            this.txt_SurnameN.TabIndex = 38;
            this.txt_SurnameN.UseWaitCursor = true;
            // 
            // txt_NameN
            // 
            this.txt_NameN.Location = new System.Drawing.Point(16, 116);
            this.txt_NameN.Name = "txt_NameN";
            this.txt_NameN.Size = new System.Drawing.Size(146, 20);
            this.txt_NameN.TabIndex = 37;
            this.txt_NameN.UseWaitCursor = true;
            // 
            // txt_PhoneN
            // 
            this.txt_PhoneN.Location = new System.Drawing.Point(16, 188);
            this.txt_PhoneN.Name = "txt_PhoneN";
            this.txt_PhoneN.Size = new System.Drawing.Size(146, 20);
            this.txt_PhoneN.TabIndex = 36;
            this.txt_PhoneN.UseWaitCursor = true;
            // 
            // txt_PassN
            // 
            this.txt_PassN.Location = new System.Drawing.Point(184, 45);
            this.txt_PassN.Name = "txt_PassN";
            this.txt_PassN.Size = new System.Drawing.Size(146, 20);
            this.txt_PassN.TabIndex = 35;
            this.txt_PassN.UseSystemPasswordChar = true;
            this.txt_PassN.UseWaitCursor = true;
            // 
            // cmb_Cnt
            // 
            this.cmb_Cnt.FormattingEnabled = true;
            this.cmb_Cnt.Location = new System.Drawing.Point(184, 186);
            this.cmb_Cnt.Name = "cmb_Cnt";
            this.cmb_Cnt.Size = new System.Drawing.Size(142, 21);
            this.cmb_Cnt.TabIndex = 34;
            // 
            // btn_Reg
            // 
            this.btn_Reg.Location = new System.Drawing.Point(101, 230);
            this.btn_Reg.Name = "btn_Reg";
            this.btn_Reg.Size = new System.Drawing.Size(144, 31);
            this.btn_Reg.TabIndex = 33;
            this.btn_Reg.Text = "Reg";
            this.btn_Reg.UseVisualStyleBackColor = true;
            this.btn_Reg.Click += new System.EventHandler(this.btn_Reg_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(369, 152);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(144, 31);
            this.btn_Open.TabIndex = 32;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Phone";
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(180, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Country";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(180, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Surname";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Name";
            this.label3.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(180, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Password";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Login";
            this.label2.UseWaitCursor = true;
            // 
            // txt_LogN
            // 
            this.txt_LogN.Location = new System.Drawing.Point(16, 45);
            this.txt_LogN.Name = "txt_LogN";
            this.txt_LogN.Size = new System.Drawing.Size(146, 20);
            this.txt_LogN.TabIndex = 25;
            this.txt_LogN.UseWaitCursor = true;
            // 
            // pct_Avatar
            // 
            this.pct_Avatar.Location = new System.Drawing.Point(336, 18);
            this.pct_Avatar.Name = "pct_Avatar";
            this.pct_Avatar.Size = new System.Drawing.Size(212, 124);
            this.pct_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_Avatar.TabIndex = 24;
            this.pct_Avatar.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frm_Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 278);
            this.Controls.Add(this.txt_SurnameN);
            this.Controls.Add(this.txt_NameN);
            this.Controls.Add(this.txt_PhoneN);
            this.Controls.Add(this.txt_PassN);
            this.Controls.Add(this.cmb_Cnt);
            this.Controls.Add(this.btn_Reg);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.pct_Avatar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_LogN);
            this.Name = "frm_Reg";
            this.Text = "frm_Reg";
            ((System.ComponentModel.ISupportInitialize)(this.pct_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SurnameN;
        private System.Windows.Forms.TextBox txt_NameN;
        private System.Windows.Forms.TextBox txt_PhoneN;
        private System.Windows.Forms.TextBox txt_PassN;
        private System.Windows.Forms.ComboBox cmb_Cnt;
        private System.Windows.Forms.Button btn_Reg;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.PictureBox pct_Avatar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_LogN;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}