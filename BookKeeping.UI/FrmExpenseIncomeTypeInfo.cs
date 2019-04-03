using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookKeeping.BLL;
using BookKeeping.Model;

namespace BookKeeping.UI
{
    public partial class FrmExpenseIncomeTypeInfo : Form
    {
        private ExpenseIncomeTypeInfoBLL eitiBll;
        private EITypeInfoBLL eiBll;
        public event Action AccurdWhenChange;
        public FrmExpenseIncomeTypeInfo()
        {
            InitializeComponent();
            this.eitiBll = new ExpenseIncomeTypeInfoBLL();
            this.eiBll = new EITypeInfoBLL();
        }

        private void FrmExpenseIncomeTypeInfo_Load(object sender, EventArgs e)
        {
            LoadList();
            LoadType();
        }

        private void LoadType()
        {
            cbType.DataSource = eiBll.GetList();
            cbType.ValueMember = "EIId";
            cbType.DisplayMember = "EItitle";
        }

        private void LoadList()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dgvList.AutoGenerateColumns = false;
            dgvList.DataSource = eitiBll.GetList(dic);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("请输入类型名称！");
                txtTitle.Focus();
                return;
            }
            ExpenseIncomeTypeInfo eiti = new ExpenseIncomeTypeInfo();
            eiti.etitle = txtTitle.Text;
            eiti.EIId = Convert.ToInt32(cbType.SelectedValue);
            if (txtId.Text == "添加时无编号")//增加
            {
                if (eitiBll.Add(eiti))
                {
                    LoadList();
                    ClearText();
                }
                else
                {
                    MessageBox.Show("添加失败，请稍后再试");
                }
            }
            else
            {
                eiti.EId = Convert.ToInt32(txtId.Text);
                if (eitiBll.Edit(eiti))
                {
                    LoadList();
                    ClearText();
                }
                else
                {
                    MessageBox.Show("修改失败，请稍后再试");
                }
            }
        }

        private void ClearText()
        {
            txtId.Text = "添加时无编号";
            txtTitle.Text = "";
            cbType.SelectedIndex = 0;
            btnSave.Text = "添加";
        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择一行数据！");
                return;
            }

            if (MessageBox.Show("是否删除？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (eitiBll.Remove(Convert.ToInt32(dgvList.SelectedRows[0].Cells[0].Value)))
                {
                    LoadList();
                    ClearText();
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
            txtTitle.Text = row.Cells[1].Value.ToString();
            cbType.Text = row.Cells[2].Value.ToString();
            btnSave.Text = "修改";
        }

        private void FrmExpenseIncomeTypeInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            AccurdWhenChange?.Invoke();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
        }
    }
}
