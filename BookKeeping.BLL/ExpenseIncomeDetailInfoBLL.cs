using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookKeeping.DAL;
using BookKeeping.Model;

namespace BookKeeping.BLL
{
    public class ExpenseIncomeDetailInfoBLL
    {
        private ExpenseIncomeDetailInfoDAL eidiDal;

        public ExpenseIncomeDetailInfoBLL()
        {
            this.eidiDal = new ExpenseIncomeDetailInfoDAL();
        }

        public List<ExpenseIncomeDetailInfo> GetList(Dictionary<string, string> dic)
        {
            return eidiDal.GetExpenseIncomeDetailInfos(dic);
        }

        public bool Add(ExpenseIncomeDetailInfo eidi)
        {
            return eidiDal.Insert(eidi) > 0;
        }

        public bool Edit(ExpenseIncomeDetailInfo eidi)
        {
            return eidiDal.Update(eidi) > 0;
        }

        public bool Remove(int id)
        {
            return eidiDal.Delete(id) > 0;
        }
    }
}
