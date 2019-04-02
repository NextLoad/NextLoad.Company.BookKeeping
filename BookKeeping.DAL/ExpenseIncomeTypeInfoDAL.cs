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
            string sqlText = "select EId,etitle,eisdelete,eiti.EIId,eititle from ExpenseIncomeTypeInfo as eiti,EITypeInfo as et where eiti.EIId = et.EIId and eisdelete = 0";
            string sqlWhere = String.Empty;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            foreach (KeyValuePair<string, string> keyValuePair in dicWhere)
            {
                sqlWhere += " and eiti." + keyValuePair.Key + " = @" + keyValuePair.Key;
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
                    EIId = Convert.ToInt32(dataRow[3]),
                    Eititle = dataRow[4].ToString()
                });
            }

            return list;
        }

        public int Insert(ExpenseIncomeTypeInfo eiti)
        {
            string sqltext = "insert into ExpenseIncomeTypeInfo(etitle,eisdelete,EIId) values(@title,0,@eiid)";
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@title", eiti.etitle),
                new SQLiteParameter("@eiid", eiti.EIId),
            };
            return SQLiteHelper.ExecuteNonQuery(sqltext, parameters);
        }


        public int Update(ExpenseIncomeTypeInfo eiti)
        {
            string sqltext = "update ExpenseIncomeTypeInfo set etitle=@title,EIId=@eiid where Eid=@eid";
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@title", eiti.etitle),
                new SQLiteParameter("@eiid", eiti.EIId),
                new SQLiteParameter("@eid",eiti.EId),
            };
            return SQLiteHelper.ExecuteNonQuery(sqltext, parameters);
        }

        public int Delete(int eid)
        {
            string sqltext = "update ExpenseIncomeTypeInfo set eisdelete=1 where Eid=@eid";
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@eid",eid),
            };
            return SQLiteHelper.ExecuteNonQuery(sqltext, parameters);
        }
    }
}
