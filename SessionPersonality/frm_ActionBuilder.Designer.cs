using System.ComponentModel;

namespace SessionPersonality
{
    partial class frm_ActionBuilder
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
            this.tbc_Actions = new System.Windows.Forms.TabControl();
            this.ListActions = new System.Windows.Forms.TabPage();
            this.btn_View = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.dtGr_Act = new System.Windows.Forms.DataGridView();
            this.NameAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueDiscont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchWay = new System.Windows.Forms.TabPage();
            this.cb_User = new System.Windows.Forms.ComboBox();
            this.dtGr_Search = new System.Windows.Forms.DataGridView();
            this.Way = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SummFull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SummWithDiscont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbc_Actions.SuspendLayout();
            this.ListActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGr_Act)).BeginInit();
            this.searchWay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGr_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_Actions
            // 
            this.tbc_Actions.Controls.Add(this.ListActions);
            this.tbc_Actions.Controls.Add(this.searchWay);
            this.tbc_Actions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbc_Actions.Location = new System.Drawing.Point(0, 1);
            this.tbc_Actions.Multiline = true;
            this.tbc_Actions.Name = "tbc_Actions";
            this.tbc_Actions.SelectedIndex = 0;
            this.tbc_Actions.Size = new System.Drawing.Size(800, 450);
            this.tbc_Actions.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tbc_Actions.TabIndex = 0;
            // 
            // ListActions
            // 
            this.ListActions.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ListActions.Controls.Add(this.btn_View);
            this.ListActions.Controls.Add(this.btn_Remove);
            this.ListActions.Controls.Add(this.btn_Open);
            this.ListActions.Controls.Add(this.dtGr_Act);
            this.ListActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListActions.Location = new System.Drawing.Point(4, 25);
            this.ListActions.Name = "ListActions";
            this.ListActions.Padding = new System.Windows.Forms.Padding(3);
            this.ListActions.Size = new System.Drawing.Size(792, 421);
            this.ListActions.TabIndex = 2;
            this.ListActions.Text = "ListActions";
            // 
            // btn_View
            // 
            this.btn_View.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_View.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_View.Location = new System.Drawing.Point(667, 386);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(110, 29);
            this.btn_View.TabIndex = 3;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = false;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Remove.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Remove.Location = new System.Drawing.Point(551, 386);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(110, 29);
            this.btn_Remove.TabIndex = 2;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Open.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Open.Location = new System.Drawing.Point(435, 386);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(110, 29);
            this.btn_Open.TabIndex = 1;
            this.btn_Open.Text = "Add";
            this.btn_Open.UseVisualStyleBackColor = false;
            this.btn_Open.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtGr_Act
            // 
            this.dtGr_Act.AllowUserToAddRows = false;
            this.dtGr_Act.AllowUserToDeleteRows = false;
            this.dtGr_Act.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGr_Act.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtGr_Act.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGr_Act.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtGr_Act.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGr_Act.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.NameAct, this.ValueDiscont, this.DateAdd });
            this.dtGr_Act.Location = new System.Drawing.Point(0, 0);
            this.dtGr_Act.MultiSelect = false;
            this.dtGr_Act.Name = "dtGr_Act";
            this.dtGr_Act.ReadOnly = true;
            this.dtGr_Act.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGr_Act.Size = new System.Drawing.Size(788, 380);
            this.dtGr_Act.TabIndex = 0;
            // 
            // NameAct
            // 
            this.NameAct.HeaderText = "Название акции";
            this.NameAct.Name = "NameAct";
            this.NameAct.ReadOnly = true;
            this.NameAct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ValueDiscont
            // 
            this.ValueDiscont.FillWeight = 50F;
            this.ValueDiscont.HeaderText = "Размер скидки";
            this.ValueDiscont.Name = "ValueDiscont";
            this.ValueDiscont.ReadOnly = true;
            this.ValueDiscont.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DateAdd
            // 
            this.DateAdd.HeaderText = "Дата";
            this.DateAdd.Name = "DateAdd";
            this.DateAdd.ReadOnly = true;
            this.DateAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // searchWay
            // 
            this.searchWay.Controls.Add(this.cb_User);
            this.searchWay.Controls.Add(this.dtGr_Search);
            this.searchWay.Controls.Add(this.label1);
            this.searchWay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchWay.Location = new System.Drawing.Point(4, 25);
            this.searchWay.Name = "searchWay";
            this.searchWay.Padding = new System.Windows.Forms.Padding(3);
            this.searchWay.Size = new System.Drawing.Size(792, 421);
            this.searchWay.TabIndex = 1;
            this.searchWay.Text = "Search";
            this.searchWay.UseVisualStyleBackColor = true;
            // 
            // cb_User
            // 
            this.cb_User.FormattingEnabled = true;
            this.cb_User.Items.AddRange(new object[] { "<Не выбрано>" });
            this.cb_User.Location = new System.Drawing.Point(172, 13);
            this.cb_User.Name = "cb_User";
            this.cb_User.Size = new System.Drawing.Size(278, 28);
            this.cb_User.TabIndex = 3;
            this.cb_User.SelectedIndexChanged += new System.EventHandler(this.cb_User_SelectedIndexChanged);
            // 
            // dtGr_Search
            // 
            this.dtGr_Search.AllowUserToAddRows = false;
            this.dtGr_Search.AllowUserToDeleteRows = false;
            this.dtGr_Search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGr_Search.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtGr_Search.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGr_Search.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtGr_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGr_Search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Way, this.Date, this.SummFull, this.SummWithDiscont, this.Desc });
            this.dtGr_Search.Location = new System.Drawing.Point(-4, 52);
            this.dtGr_Search.MultiSelect = false;
            this.dtGr_Search.Name = "dtGr_Search";
            this.dtGr_Search.ReadOnly = true;
            this.dtGr_Search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGr_Search.Size = new System.Drawing.Size(792, 360);
            this.dtGr_Search.TabIndex = 2;
            // 
            // Way
            // 
            this.Way.HeaderText = "Маршрут";
            this.Way.Name = "Way";
            this.Way.ReadOnly = true;
            this.Way.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата тура";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SummFull
            // 
            this.SummFull.HeaderText = "Полная сумма";
            this.SummFull.Name = "SummFull";
            this.SummFull.ReadOnly = true;
            this.SummFull.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SummWithDiscont
            // 
            this.SummWithDiscont.HeaderText = "Сумма с учетом";
            this.SummWithDiscont.Name = "SummWithDiscont";
            this.SummWithDiscont.ReadOnly = true;
            this.SummWithDiscont.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Desc
            // 
            this.Desc.FillWeight = 150F;
            this.Desc.HeaderText = "Описание";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            this.Desc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Клиент";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_ActionBuilder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbc_Actions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "frm_ActionBuilder";
            this.Text = "ActionsList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_ActionBuilder_FormClosed);
            this.tbc_Actions.ResumeLayout(false);
            this.ListActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGr_Act)).EndInit();
            this.searchWay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGr_Search)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn Way;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn SummFull;
        private System.Windows.Forms.DataGridViewTextBoxColumn SummWithDiscont;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;

        private System.Windows.Forms.ComboBox cb_User;

        private System.Windows.Forms.DataGridView dtGr_Search;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridViewTextBoxColumn NameAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueDiscont;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAdd;

        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_View;

        private System.Windows.Forms.DataGridView dtGr_Act;

        private System.Windows.Forms.TabPage ListActions;

        private System.Windows.Forms.TabControl tbc_Actions;
        private System.Windows.Forms.TabPage searchWay;

        #endregion
    }
}