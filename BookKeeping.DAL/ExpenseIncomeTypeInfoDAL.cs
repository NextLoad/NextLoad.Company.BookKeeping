using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using BookKeeping.Common;
using BookKeeping.Model;

namespace BookKeeping.DAL
{
    public class ExpenseIncomeTypeInfoDAL
    {
        public ExpenseIncomeTypeInfoDAL() { }

        public List<ExpenseIncomeTypeInfo> GExpenseIncomeTypeInfos(Dictionary<string, string> dicWhere)
        {
            List<ExpenseIncomeTypeInfo> list = new List<ExpenseIncomeTypeInfo>();
            string sqlText = "select EId,etitle,eisdelete,EIId from ExpenseIncomeTypeInfo where eisdelete = 0";
            string sqlWhere = String.Empty;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            foreach (KeyValuePair<string, string> keyValuePair in dicWhere)
            {
                sqlWhere += " and " + keyValuePair.Key + " = @" + keyValuePair.Key;
                parameters.Add(new SQLiteParameter("@" + keyValuePair.Key, keyValuePair.Value));
            }

            sqlText += sqlWhere;
            DataTable dt = SQLiteHelper.ExecuteDataTable(sqlText, parameters.ToArray());
            foreach (DataRow dataRow in dt.Rows)
            {
                list.Add(new ExpenseIncomeTypeInfo()
                {
                    EId = Convert.ToInt32(dataRow[0]),
                    etitle = dataRow[1].ToString(),
                    eisdelete = Convert.ToBoolean(dataRow[2]),
                    EIId = Convert.ToInt32(dataRow[3])
                });
            }

            return list;
        }
    }
}
