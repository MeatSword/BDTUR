using System.ComponentModel;

namespace SessionPersonality
{
    partial class frm_Bron
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lb_Log = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_BirthDay = new System.Windows.Forms.TextBox();
            this.txt_FIO = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_Cab = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Log
            // 
            this.lb_Log.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Log.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Log.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lb_Log.Location = new System.Drawing.Point(91, 9);
            this.lb_Log.Name = "lb_Log";
            this.lb_Log.Size = new System.Drawing.Size(349, 24);
            this.lb_Log.TabIndex = 4;
            this.lb_Log.Text = "Заполнение личной информации";
            this.lb_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.txt_Phone);
            this.panel1.Controls.Add(this.txt_BirthDay);
            this.panel1.Controls.Add(this.txt_FIO);
            this.panel1.Location = new System.Drawing.Point(52, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 145);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(14, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(14, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Phone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "BirthDay";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "FIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(156, 115);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(252, 20);
            this.txt_Email.TabIndex = 11;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(156, 79);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(252, 20);
            this.txt_Phone.TabIndex = 9;
            // 
            // txt_BirthDay
            // 
            this.txt_BirthDay.Location = new System.Drawing.Point(156, 44);
            this.txt_BirthDay.Name = "txt_BirthDay";
            this.txt_BirthDay.Size = new System.Drawing.Size(252, 20);
            this.txt_BirthDay.TabIndex = 7;
            // 
            // txt_FIO
            // 
            this.txt_FIO.Location = new System.Drawing.Point(156, 9);
            this.txt_FIO.Name = "txt_FIO";
            this.txt_FIO.Size = new System.Drawing.Size(252, 20);
            this.txt_FIO.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(52, 196);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(191, 22);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Tag = "Add";
            this.checkBox1.Text = "Добавить путешествующего";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_Cab
            // 
            this.btn_Cab.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Cab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Cab.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Cab.Location = new System.Drawing.Point(52, 224);
            this.btn_Cab.Name = "btn_Cab";
            this.btn_Cab.Size = new System.Drawing.Size(248, 35);
            this.btn_Cab.TabIndex = 15;
            this.btn_Cab.Text = "Перейти к подтверждениию";
            this.btn_Cab.UseVisualStyleBackColor = false;
            // 
            // frm_Bron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.btn_Cab);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_Log);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "frm_Bron";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txt_BirthDay;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_Email;

        private System.Windows.Forms.TextBox txt_FIO;

        private System.Windows.Forms.Button btn_Cab;

        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label lb_Log;

        #endregion
    }
}