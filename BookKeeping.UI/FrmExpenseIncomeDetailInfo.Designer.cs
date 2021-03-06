﻿namespace BookKeeping.UI
{
    partial class FrmExpenseIncomeDetailInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpenseIncomeDetailInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.edid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edtid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eddatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edmoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbSearchEItype = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpStartDay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEditEiType = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbEiType = new System.Windows.Forms.ComboBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpEndDay = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 501);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "记账详细信息";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edid,
            this.edtid,
            this.eddatetime,
            this.edmoney,
            this.edtype});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 17);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(526, 481);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            // 
            // edid
            // 
            this.edid.DataPropertyName = "edid";
            this.edid.Frozen = true;
            this.edid.HeaderText = "编号";
            this.edid.Name = "edid";
            this.edid.ReadOnly = true;
            // 
            // edtid
            // 
            this.edtid.DataPropertyName = "etitle";
            this.edtid.HeaderText = "支出类型";
            this.edtid.Name = "edtid";
            this.edtid.ReadOnly = true;
            // 
            // eddatetime
            // 
            this.eddatetime.DataPropertyName = "eddatetime";
            this.eddatetime.HeaderText = "记录日期";
            this.eddatetime.Name = "eddatetime";
            this.eddatetime.ReadOnly = true;
            // 
            // edmoney
            // 
            this.edmoney.DataPropertyName = "edmoney";
            this.edmoney.HeaderText = "费用";
            this.edmoney.Name = "edmoney";
            this.edmoney.ReadOnly = true;
            // 
            // edtype
            // 
            this.edtype.DataPropertyName = "EItitle";
            this.edtype.HeaderText = "收支类型";
            this.edtype.Name = "edtype";
            this.edtype.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.cbSearchType);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbSearchEItype);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtpEndDay);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dtpStartDay);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(550, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "搜索条件";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(93, 162);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(72, 23);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(9, 162);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 23);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbSearchType
            // 
            this.cbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Location = new System.Drawing.Point(57, 125);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(109, 20);
            this.cbSearchType.TabIndex = 24;
            this.cbSearchType.SelectedIndexChanged += new System.EventHandler(this.cbSearchType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-1, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "收支类型：";
            // 
            // cbSearchEItype
            // 
            this.cbSearchEItype.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbSearchEItype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchEItype.FormattingEnabled = true;
            this.cbSearchEItype.Location = new System.Drawing.Point(57, 91);
            this.cbSearchEItype.Name = "cbSearchEItype";
            this.cbSearchEItype.Size = new System.Drawing.Size(109, 20);
            this.cbSearchEItype.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "类  型：";
            // 
            // dtpStartDay
            // 
            this.dtpStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDay.Location = new System.Drawing.Point(57, 25);
            this.dtpStartDay.Name = "dtpStartDay";
            this.dtpStartDay.Size = new System.Drawing.Size(109, 21);
            this.dtpStartDay.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "开始日期：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpTime);
            this.groupBox3.Controls.Add(this.btnRemove);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnEditEiType);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.cbType);
            this.groupBox3.Controls.Add(this.cbEiType);
            this.groupBox3.Controls.Add(this.txtMoney);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(550, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 329);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "添加\\修改";
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(56, 117);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(109, 21);
            this.dtpTime.TabIndex = 20;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(11, 288);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(153, 25);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "删除选中的行数据";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(9, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "提示：双击表格项进行修改";
            // 
            // btnEditEiType
            // 
            this.btnEditEiType.Location = new System.Drawing.Point(56, 80);
            this.btnEditEiType.Name = "btnEditEiType";
            this.btnEditEiType.Size = new System.Drawing.Size(109, 25);
            this.btnEditEiType.TabIndex = 13;
            this.btnEditEiType.Text = "类型管理";
            this.btnEditEiType.UseVisualStyleBackColor = true;
            this.btnEditEiType.Click += new System.EventHandler(this.btnEditEiType_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(95, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 25);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(11, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 25);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "添加";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(56, 192);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(109, 20);
            this.cbType.TabIndex = 10;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // cbEiType
            // 
            this.cbEiType.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbEiType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEiType.FormattingEnabled = true;
            this.cbEiType.Location = new System.Drawing.Point(56, 53);
            this.cbEiType.Name = "cbEiType";
            this.cbEiType.Size = new System.Drawing.Size(109, 20);
            this.cbEiType.TabIndex = 10;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(56, 154);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(109, 21);
            this.txtMoney.TabIndex = 8;
            this.txtMoney.Text = "0";
            this.txtMoney.Leave += new System.EventHandler(this.txtMoney_Leave);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(56, 26);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(109, 21);
            this.txtId.TabIndex = 5;
            this.txtId.Text = "添加时无编号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-2, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "收支类型：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "费  用：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "类  型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "日  期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "编  号：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblIncome);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lblPay);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(15, 520);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(526, 60);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "统计信息";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPay.ForeColor = System.Drawing.Color.Red;
            this.lblPay.Location = new System.Drawing.Point(66, 19);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(103, 29);
            this.lblPay.TabIndex = 1;
            this.lblPay.Text = "label8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "总计支出：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-3, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "结束日期：";
            // 
            // dtpEndDay
            // 
            this.dtpEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDay.Location = new System.Drawing.Point(57, 57);
            this.dtpEndDay.Name = "dtpEndDay";
            this.dtpEndDay.Size = new System.Drawing.Size(109, 21);
            this.dtpEndDay.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(242, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "总计收入：";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIncome.ForeColor = System.Drawing.Color.Red;
            this.lblIncome.Location = new System.Drawing.Point(301, 19);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(103, 29);
            this.lblIncome.TabIndex = 1;
            this.lblIncome.Text = "label8";
            // 
            // FrmExpenseIncomeDetailInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 592);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmExpenseIncomeDetailInfo";
            this.Text = "记账明细";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmExpenseIncomeDetailInfo_FormClosed);
            this.Load += new System.EventHandler(this.FrmExpenseIncomeDetailInfo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEditEiType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbEiType;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn edid;
        private System.Windows.Forms.DataGridViewTextBoxColumn edtid;
        private System.Windows.Forms.DataGridViewTextBoxColumn eddatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn edmoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn edtype;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbSearchEItype;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpStartDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEndDay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label label12;
    }
}