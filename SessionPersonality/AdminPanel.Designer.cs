namespace SessionPersonality
{
    partial class Form1
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
            this.txt_Log = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.btn_Log = new System.Windows.Forms.Button();
            this.lb_Log = new System.Windows.Forms.Label();
            this.lb_Pass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Log
            // 
            this.txt_Log.Location = new System.Drawing.Point(137, 113);
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Size = new System.Drawing.Size(186, 20);
            this.txt_Log.TabIndex = 0;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(137, 191);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(186, 20);
            this.txt_Pass.TabIndex = 1;
            this.txt_Pass.UseSystemPasswordChar = true;
            // 
            // btn_Log
            // 
            this.btn_Log.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Log.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Log.Location = new System.Drawing.Point(137, 232);
            this.btn_Log.Name = "btn_Log";
            this.btn_Log.Size = new System.Drawing.Size(186, 33);
            this.btn_Log.TabIndex = 2;
            this.btn_Log.Text = "Login";
            this.btn_Log.UseVisualStyleBackColor = false;
            this.btn_Log.Click += new System.EventHandler(this.btn_Log_Click);
            // 
            // lb_Log
            // 
            this.lb_Log.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Log.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Log.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lb_Log.Location = new System.Drawing.Point(162, 86);
            this.lb_Log.Name = "lb_Log";
            this.lb_Log.Size = new System.Drawing.Size(136, 24);
            this.lb_Log.TabIndex = 3;
            this.lb_Log.Text = "Login";
            this.lb_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Pass
            // 
            this.lb_Pass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Pass.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pass.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lb_Pass.Location = new System.Drawing.Point(162, 164);
            this.lb_Pass.Name = "lb_Pass";
            this.lb_Pass.Size = new System.Drawing.Size(136, 24);
            this.lb_Pass.TabIndex = 4;
            this.lb_Pass.Text = "Password";
            this.lb_Pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(151, 7);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вход";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Pass);
            this.Controls.Add(this.lb_Log);
            this.Controls.Add(this.btn_Log);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Log);
            this.Name = "Form1";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.Reg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label lb_Pass;

        private System.Windows.Forms.Label lb_Log;

        private System.Windows.Forms.TextBox txt_Log;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Button btn_Log;

        #endregion
    }
}