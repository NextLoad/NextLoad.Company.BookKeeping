using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookKeeping.Common;
using BookKeeping.Model;

namespace BookKeeping.DAL
{
    public class EITypeInfoDAL
    {
        public List<EITypeInfo> GEiTypeInfos()
        {
            List<EITypeInfo> list = new List<EITypeInfo>();
            string sqlText = "select EIId,EItitle from EITypeInfo";
            DataTable dt = SQLiteHelper.ExecuteDataTable(sqlText);
            foreach (DataRow dataRow in dt.Rows)
            {
                list.Add(new EITypeInfo()
                {
                    EIId = Convert.ToInt32(dataRow[0]),
                    EItitle = dataRow[1].ToString()
                });
            }

            return list;
        }

    }
}

