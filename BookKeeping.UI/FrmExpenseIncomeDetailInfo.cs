using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookKeeping.BLL;
using BookKeeping.Common;
using BookKeeping.Model;

namespace BookKeeping.UI
{
    public partial class FrmExpenseIncomeDetailInfo : Form
    {
        private ExpenseIncomeDetailInfoBLL exdiBll;
        private ExpenseIncomeTypeInfoBLL eiTiBll;
        private EITypeInfoBLL eiBll;
        public FrmExpenseIncomeDetailInfo()
        {
            InitializeComponent();
            this.exdiBll = new ExpenseIncomeDetailInfoBLL();
            this.eiTiBll = new ExpenseIncomeTypeInfoBLL();
            this.eiBll = new EITypeInfoBLL();
        }

        private void FrmExpenseIncomeDetailInfo_Load(object sender, EventArgs e)
        {
            LoadList();
            LoadcbType();
            LoadcbEiType();
        }

        private void LoadcbEiType()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            if (cbType.SelectedIndex > -1)
            {
                dic.Add("EIId", cbType.SelectedValue.ToString());
            }

            cbEiType.DataSource = eiTiBll.GetList(dic);
            cbEiType.ValueMember = "EId";
            cbEiType.DisplayMember = "etitle";
        }

        private void LoadcbType()
        {
            cbType.DataSource = eiBll.GetList();
            cbType.ValueMember = "EIId";
            cbType.DisplayMember = "EItitle";
            cbType.SelectedIndex = 1;
        }

        private void LoadList()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("eduid", UserInfoStatic.userInfo.UId.ToString());
            dgvList.AutoGenerateColumns = false;
            //dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.DataSource = exdiBll.GetList(dic);
        }

        private void txtMoney_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$|^[0-9]+[.][0-9]+$");
            if (!regex.IsMatch(txtMoney.Text))
            {
                MessageBox.Show("只能输入数字!");
                txtMoney.Focus();
                txtMoney.SelectAll();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ExpenseIncomeDetailInfo eidi = new ExpenseIncomeDetailInfo();
            eidi.eddatetime = dtpTime.Value;
            eidi.edmoney = Convert.ToDecimal(txtMoney.Text);
            eidi.edtype = Convert.ToInt32(cbType.SelectedValue);
            eidi.edtid = Convert.ToInt32(cbEiType.SelectedValue);
            eidi.eduid = UserInfoStatic.userInfo.UId;
            if (txtId.Text == "添加时无编号")
            {
                if (exdiBll.Add(eidi))
                {
                    LoadList();
                    ClearText();
                }
                else
                {
                    MessageBox.Show("添加失败，请稍后再试！");
                }
            }
            else
            {
                eidi.edid = Convert.ToInt32(txtId.Text);
                if (exdiBll.Edit(eidi))
                {
                    LoadList();
                    ClearText();
                }
                else
                {
                    MessageBox.Show("修改失败，请稍后再试！");
                }
            }
        }

        private void ClearText()
        {
            txtId.Text = "添加时无编号";
            txtMoney.Text = "0";
            cbType.SelectedIndex = 1;
            dtpTime.Value = DateTime.Now;
            btnSave.Text = "添加";
        }

        private void FrmExpenseIncomeDetailInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadcbEiType();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnEditEiType_Click(object sender, EventArgs e)
        {
            MessageBox.Show("正在开发中...");
        }

        private void btnEditType_Click(object sender, EventArgs e)
        {
            MessageBox.Show("正在开发中...");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择一行数据！");
                return;
            }

            if (MessageBox.Show("确认删除？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (exdiBll.Remove(Convert.ToInt32(dgvList.SelectedRows[0].Cells[0].Value)))
                {
                    MessageBox.Show("删除成功！");
                    LoadList();
                }
                else
                {
                    MessageBox.Show("删除失败，请稍后再试！");
                }
            }
        }
    }
}
