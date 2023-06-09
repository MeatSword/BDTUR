using System.ComponentModel;

namespace SessionPersonality
{
    partial class frm_ActionBuilderNew
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.chList_Ways = new System.Windows.Forms.CheckedListBox();
            this.cb_IsDiscontAct = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_Plat = new System.Windows.Forms.RadioButton();
            this.rb_Gold = new System.Windows.Forms.RadioButton();
            this.rb_Silv = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ValueDisc = new System.Windows.Forms.TextBox();
            this.cb_IsSumm = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NameAct = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбор направления";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Поиск";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(84, 35);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(208, 20);
            this.txt_Search.TabIndex = 2;
            // 
            // chList_Ways
            // 
            this.chList_Ways.CheckOnClick = true;
            this.chList_Ways.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chList_Ways.FormattingEnabled = true;
            this.chList_Ways.Location = new System.Drawing.Point(13, 65);
            this.chList_Ways.Name = "chList_Ways";
            this.chList_Ways.Size = new System.Drawing.Size(278, 328);
            this.chList_Ways.TabIndex = 3;
            // 
            // cb_IsDiscontAct
            // 
            this.cb_IsDiscontAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_IsDiscontAct.Location = new System.Drawing.Point(316, 32);
            this.cb_IsDiscontAct.Name = "cb_IsDiscontAct";
            this.cb_IsDiscontAct.Size = new System.Drawing.Size(156, 23);
            this.cb_IsDiscontAct.TabIndex = 4;
            this.cb_IsDiscontAct.Text = "Cкидка на акции";
            this.cb_IsDiscontAct.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(312, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Категория";
            // 
            // rb_Plat
            // 
            this.rb_Plat.Checked = true;
            this.rb_Plat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Plat.Location = new System.Drawing.Point(475, 60);
            this.rb_Plat.Name = "rb_Plat";
            this.rb_Plat.Size = new System.Drawing.Size(90, 32);
            this.rb_Plat.TabIndex = 6;
            this.rb_Plat.TabStop = true;
            this.rb_Plat.Text = "Platinum";
            this.rb_Plat.UseVisualStyleBackColor = true;
            // 
            // rb_Gold
            // 
            this.rb_Gold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Gold.Location = new System.Drawing.Point(571, 60);
            this.rb_Gold.Name = "rb_Gold";
            this.rb_Gold.Size = new System.Drawing.Size(90, 32);
            this.rb_Gold.TabIndex = 7;
            this.rb_Gold.Text = "Gold";
            this.rb_Gold.UseVisualStyleBackColor = true;
            this.rb_Gold.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_Silv
            // 
            this.rb_Silv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Silv.Location = new System.Drawing.Point(641, 60);
            this.rb_Silv.Name = "rb_Silv";
            this.rb_Silv.Size = new System.Drawing.Size(90, 32);
            this.rb_Silv.TabIndex = 8;
            this.rb_Silv.Text = "Silver";
            this.rb_Silv.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(312, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "Тип скидки";
            // 
            // cmb_Type
            // 
            this.cmb_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Items.AddRange(new object[] { "Fixed", "Procented" });
            this.cmb_Type.Location = new System.Drawing.Point(475, 103);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(226, 28);
            this.cmb_Type.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(312, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "Размер скидки";
            // 
            // txt_ValueDisc
            // 
            this.txt_ValueDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_ValueDisc.Location = new System.Drawing.Point(475, 144);
            this.txt_ValueDisc.Name = "txt_ValueDisc";
            this.txt_ValueDisc.Size = new System.Drawing.Size(226, 26);
            this.txt_ValueDisc.TabIndex = 12;
            // 
            // cb_IsSumm
            // 
            this.cb_IsSumm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_IsSumm.Location = new System.Drawing.Point(316, 192);
            this.cb_IsSumm.Name = "cb_IsSumm";
            this.cb_IsSumm.Size = new System.Drawing.Size(357, 23);
            this.cb_IsSumm.TabIndex = 13;
            this.cb_IsSumm.Text = "Скидка может быть суммировна";
            this.cb_IsSumm.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(312, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 38);
            this.label6.TabIndex = 14;
            this.label6.Text = "Название";
            // 
            // txt_NameAct
            // 
            this.txt_NameAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_NameAct.Location = new System.Drawing.Point(475, 226);
            this.txt_NameAct.Name = "txt_NameAct";
            this.txt_NameAct.Size = new System.Drawing.Size(226, 26);
            this.txt_NameAct.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(312, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 38);
            this.label7.TabIndex = 16;
            this.label7.Text = "Описание";
            // 
            // txt_Desc
            // 
            this.txt_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Desc.Location = new System.Drawing.Point(316, 277);
            this.txt_Desc.Multiline = true;
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(389, 128);
            this.txt_Desc.TabIndex = 17;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(475, 411);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(132, 27);
            this.btn_OK.TabIndex = 18;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(613, 411);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(132, 27);
            this.btn_Cancel.TabIndex = 19;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // frm_ActionBuilderNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_Desc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_NameAct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_IsSumm);
            this.Controls.Add(this.txt_ValueDisc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_Silv);
            this.Controls.Add(this.rb_Gold);
            this.Controls.Add(this.rb_Plat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_IsDiscontAct);
            this.Controls.Add(this.chList_Ways);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_ActionBuilderNew";
            this.Text = "frm_ActionBuilderNew";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_ActionBuilderNew_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;

        private System.Windows.Forms.TextBox txt_Desc;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.TextBox txt_NameAct;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox txt_ValueDisc;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.ComboBox cmb_Type;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.RadioButton rb_Gold;
        private System.Windows.Forms.RadioButton rb_Silv;

        private System.Windows.Forms.RadioButton rb_Plat;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.CheckBox cb_IsDiscontAct;

        private System.Windows.Forms.CheckBox cb_IsSumm;

        private System.Windows.Forms.CheckedListBox chList_Ways;

        private System.Windows.Forms.TextBox txt_Search;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}