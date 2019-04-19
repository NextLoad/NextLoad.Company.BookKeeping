using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using BookKeeping.Common;
using BookKeeping.Model;

namespace BookKeeping.DAL
{
    public class ExpenseIncomeDetailInfoDAL
    {
        public ExpenseIncomeDetailInfoDAL() { }
        /// <summary>
        /// 获取记账明细表
        /// </summary>
        /// <param name="dicWhere"></param>
        /// <returns></returns>
        public List<ExpenseIncomeDetailInfo> GetExpenseIncomeDetailInfos(Dictionary<string, string> dicWhere)
        {
            List<ExpenseIncomeDetailInfo> list = new List<ExpenseIncomeDetailInfo>();
            string sqlText =
                "select edid,eduid,edtid,eddatetime,edmoney,edisdelete,edtype,etitle,EItitle from ExpenseIncomeDetailInfo as ed,ExpenseIncomeTypeInfo as eit,EITypeInfo as ei where ed.edtid = eit.EId and ed.edtype = ei.EIId and edisdelete = 0";
            string sqlWhere = String.Empty;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            foreach (KeyValuePair<string, string> keyValuePair in dicWhere)
            {
                sqlWhere += " and " + keyValuePair.Key + " like @" + keyValuePair.Key;
                parameters.Add(new SQLiteParameter("@" + keyValuePair.Key, "%" + keyValuePair.Value + "%"));
            }

            sqlText += sqlWhere;
            DataTable dt = SQLiteHelper.ExecuteDataTable(sqlText, parameters.ToArray());
            foreach (DataRow dataRow in dt.Rows)
            {
                list.Add(new ExpenseIncomeDetailInfo()
                {
                    edid = Convert.ToInt32(dataRow[0]),
                    eduid = Convert.ToInt32(dataRow[1]),
                    edtid = Convert.ToInt32(dataRow[2]),
                    eddatetime = Convert.ToDateTime(dataRow[3]),
                    edmoney = Convert.ToDecimal(dataRow[4]),
                    edisdelete = Convert.ToBoolean(dataRow[5]),
                    edtype = Convert.ToInt32(dataRow[6]),
                    etitle = dataRow[7].ToString(),
                    EItitle = dataRow[8].ToString()
                });
            }

            return list;
        }

        public List<ExpenseIncomeDetailInfo> GetExpenseIncomeDetailInfos(Dictionary<string, string> dicWhere, DateTime start,DateTime end)
        {
            List<ExpenseIncomeDetailInfo> list = new List<ExpenseIncomeDetailInfo>();
            string sqlText =
                "select edid,eduid,edtid,eddatetime,edmoney,edisdelete,edtype,etitle,EItitle from ExpenseIncomeDetailInfo as ed,ExpenseIncomeTypeInfo as eit,EITypeInfo as ei where ed.edtid = eit.EId and ed.edtype = ei.EIId and edisdelete = 0 and eddatetime > @start and eddatetime < @end";
            string sqlWhere = String.Empty;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            parameters.Add(new SQLiteParameter("@start", start.ToString("yyyy-MM-dd")));
            parameters.Add(new SQLiteParameter("@end", end.ToString("yyyy-MM-dd")));
            foreach (KeyValuePair<string, string> keyValuePair in dicWhere)
            {
                sqlWhere += " and " + keyValuePair.Key + " like @" + keyValuePair.Key;
                parameters.Add(new SQLiteParameter("@" + keyValuePair.Key, "%" + keyValuePair.Value + "%"));
            }

            sqlText += sqlWhere;
            DataTable dt = SQLiteHelper.ExecuteDataTable(sqlText, parameters.ToArray());
            foreach (DataRow dataRow in dt.Rows)
            {
                list.Add(new ExpenseIncomeDetailInfo()
                {
                    edid = Convert.ToInt32(dataRow[0]),
                    eduid = Convert.ToInt32(dataRow[1]),
                    edtid = Convert.ToInt32(dataRow[2]),
                    eddatetime = Convert.ToDateTime(dataRow[3]),
                    edmoney = Convert.ToDecimal(dataRow[4]),
                    edisdelete = Convert.ToBoolean(dataRow[5]),
                    edtype = Convert.ToInt32(dataRow[6]),
                    etitle = dataRow[7].ToString(),
                    EItitle = dataRow[8].ToString()
                });
            }

            return list;
        }

        public int Insert(ExpenseIncomeDetailInfo eidi)
        {
            string sqlText =
                "Insert into ExpenseIncomeDetailInfo(eduid,edtid,eddatetime,edmoney,edisdelete,edtype) values(@uid,@tid,@datetime,@money,0,@type)";
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@uid", eidi.eduid),
                new SQLiteParameter("@tid", eidi.edtid),
                new SQLiteParameter("@datetime", eidi.eddatetime),
                new SQLiteParameter("@money", eidi.edmoney),
                new SQLiteParameter("@type", eidi.edtype),
            };
            return SQLiteHelper.ExecuteNonQuery(sqlText, parameters);
        }

        public int Update(ExpenseIncomeDetailInfo eidi)
        {
            string sqlText =
                "update ExpenseIncomeDetailInfo set edtid = @uid,eddatetime = @datetime,edmoney = @money,edtype = @type";
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@tid", eidi.edtid),
                new SQLiteParameter("@datetime", eidi.eddatetime),
                new SQLiteParameter("@money", eidi.edmoney),
                new SQLiteParameter("@type", eidi.edtype),
            };
            return SQLiteHelper.ExecuteNonQuery(sqlText, parameters);
        }

        public int Delete(int id)
        {
            string sqlText = "update ExpenseIncomeDetailInfo set edisdelete=1 where edid = @id";
            SQLiteParameter parameter = new SQLiteParameter("@id", id);
            return SQLiteHelper.ExecuteNonQuery(sqlText, parameter);
        }
    }
}
