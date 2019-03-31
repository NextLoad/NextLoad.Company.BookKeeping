using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookKeeping.DAL;
using BookKeeping.Model;

namespace BookKeeping.BLL
{
    public class ExpenseIncomeTypeInfoBLL
    {
        private ExpenseIncomeTypeInfoDAL eidiDal;

        public ExpenseIncomeTypeInfoBLL()
        {
            this.eidiDal = new ExpenseIncomeTypeInfoDAL();
        }

        public List<ExpenseIncomeTypeInfo> GetList(Dictionary<string, string> dic)
        {
            return eidiDal.GExpenseIncomeTypeInfos(dic);
        }
    }
}
