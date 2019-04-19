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

        private int GetDays(DateTime time)
        {
            int year = time.Year;
            bool isRun = false;
            if (year % 4 == 0 && year % 400 != 0)
            {
                isRun = true;
            }
            else
            {
                if (year % 400 == 0)
                {
                    isRun = true;
                }
            }
            int month = time.Month;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if (isRun) { return 29; }
                    else { return 28; }
                default:
                    return 30;
            }
        }
        private void FrmExpenseIncomeDetailInfo_Load(object sender, EventArgs e)
        {
            dtpStartDay.Value = DateTime.Now.AddDays(-1 * DateTime.Now.Day);
            dtpEndDay.Value = dtpStartDay.Value.AddDays(GetDays(dtpStartDay.Value));
            LoadList();
            LoadcbType();
            LoadcbEiType();
            LoadcbSearchType();
            LoadcbSearchEiType();
        }

        private void LoadcbSearchEiType()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            if (cbSearchType.SelectedIndex > 0)
            {
                dic.Add("EIId", cbSearchType.SelectedValue.ToString());
            }
            List<ExpenseIncomeTypeInfo> list = eiTiBll.GetList(dic);
            list.Insert(0, new ExpenseIncomeTypeInfo() { etitle = "全部" });
            cbSearchEItype.DataSource = list;
            cbSearchEItype.ValueMember = "EId";
            cbSearchEItype.DisplayMember = "etitle";
        }

        private void LoadcbSearchType()
        {
            List<EITypeInfo> list = eiBll.GetList();
            list.Insert(0, new EITypeInfo() { EItitle = "全部" });
            cbSearchType.DataSource = list;
            cbSearchType.ValueMember = "EIId";
            cbSearchType.DisplayMember = "EItitle";
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
            if (cbSearchType.SelectedIndex > 0)
            {
                dic.Add("edtype", cbSearchType.SelectedValue.ToString());
            }
            if (cbSearchEItype.SelectedIndex > 0)
            {
                dic.Add("edtid", cbSearchEItype.SelectedValue.ToString());
            }
            dgvList.AutoGenerateColumns = false;
            var list = exdiBll.GetListBytime(dic, dtpStartDay.Value, dtpEndDay.Value);
            dgvList.DataSource = list;
            SetlblMoneyText(list);
        }

        private void SetlblMoneyText(List<ExpenseIncomeDetailInfo> list)
        {
            decimal? sumPay = 0;
            decimal? sumIncome = 0;
            foreach (var detailInfo in list)
            {
                if (detailInfo.edtype == 2)
                {
                    sumPay += detailInfo.edmoney;
                }
                else
                {
                    sumIncome += detailInfo.edmoney;
                }
            }
            lblPay.Text = sumPay.ToString();
            lblIncome.Text = sumIncome.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            LoadList();
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
            FrmExpenseIncomeTypeInfo frmExpenseIncomeType = new FrmExpenseIncomeTypeInfo();
            frmExpenseIncomeType.AccurdWhenChange += LoadcbEiType;
            frmExpenseIncomeType.ShowDialog();
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

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvList.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            cbEiType.Text = row.Cells[1].Value.ToString();
            dtpTime.Value = Convert.ToDateTime(row.Cells[2].Value);
            txtMoney.Text = row.Cells[3].Value.ToString();
            cbType.Text = row.Cells[4].Value.ToString();
            btnSave.Text = "修改";
        }

        private void cbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadcbSearchEiType();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbSearchType.SelectedIndex = 0;
            cbSearchEItype.SelectedIndex = 0;
            dtpStartDay.Value = DateTime.Now.AddDays(-1 * DateTime.Now.Day);
            dtpEndDay.Value = dtpStartDay.Value.AddDays(GetDays(dtpStartDay.Value));
        }
    }
}
