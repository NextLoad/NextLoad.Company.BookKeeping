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

        public bool Add(ExpenseIncomeTypeInfo eiti)
        {
            return eidiDal.Insert(eiti) > 0;
        }
        public bool Edit(ExpenseIncomeTypeInfo eiti)
        {
            return eidiDal.Update(eiti) > 0;
        }
        public bool Remove(int eid)
        {
            return eidiDal.Delete(eid) > 0;
        }
    }
}
