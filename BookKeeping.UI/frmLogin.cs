using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookKeeping.BLL;
using BookKeeping.Common;
using BookKeeping.Model;

namespace BookKeeping.UI
{
    public partial class frmLogin : Form
    {
        private UserInfoBLL uiBll;
        public frmLogin()
        {
            InitializeComponent();
            uiBll = new UserInfoBLL();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginMethod();
        }

        private void LoginMethod()
        {
            string name = txtName.Text;
            string pwd = txtPwd.Text;
            if (uiBll.Login(name, pwd, out UserInfoStatic.userInfo))
            {
                FrmExpenseIncomeDetailInfo frm = new FrmExpenseIncomeDetailInfo();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPwd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginMethod();
            }
        }
    }
}
