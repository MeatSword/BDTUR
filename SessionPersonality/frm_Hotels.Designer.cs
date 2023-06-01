namespace SessionPersonality
{
    partial class frm_Hotels
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
            this.tbPanel_Hotels = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tbPanel_Hotels
            // 
            this.tbPanel_Hotels.ColumnCount = 5;
            this.tbPanel_Hotels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPanel_Hotels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPanel_Hotels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPanel_Hotels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPanel_Hotels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPanel_Hotels.Location = new System.Drawing.Point(6, 3);
            this.tbPanel_Hotels.Name = "tbPanel_Hotels";
            this.tbPanel_Hotels.RowCount = 3;
            this.tbPanel_Hotels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbPanel_Hotels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbPanel_Hotels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbPanel_Hotels.Size = new System.Drawing.Size(787, 440);
            this.tbPanel_Hotels.TabIndex = 0;
            // 
            // frm_Hotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPanel_Hotels);
            this.Name = "frm_Hotels";
            this.Text = "frm_Hotels";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbPanel_Hotels;
    }
}