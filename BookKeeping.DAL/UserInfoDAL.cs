using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookKeeping.Common;
using BookKeeping.Model;

namespace BookKeeping.DAL
{
    public class UserInfoDAL
    {
        public UserInfoDAL() { }

        /// <summary>
        /// 获取用户列表信息
        /// </summary>
        /// <param name="dicWhere"></param>
        /// <returns></returns>
        public List<UserInfo> GetInfos(Dictionary<string, string> dicWhere)
        {
            List<UserInfo> list = new List<UserInfo>();
            string sqltext = "select UId,username,upassword,uisdelete,uisadmin from UserInfo where uisdelete = 0";
            string sqlWhere = String.Empty;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            foreach (KeyValuePair<string, string> keyValuePair in dicWhere)
            {
                sqlWhere += " and " + keyValuePair.Key + " = @" + keyValuePair.Key;
                parameters.Add(new SQLiteParameter("@" + keyValuePair.Key, keyValuePair.Value));
            }

            DataTable dt = SQLiteHelper.ExecuteDataTable(sqltext, parameters.ToArray());
            foreach (DataRow dataRow in dt.Rows)
            {
                list.Add(new UserInfo()
                {
                    UId = Convert.ToInt32(dataRow[0]),
                    username = dataRow[1].ToString(),
                    upassword = dataRow[2].ToString(),
                    uisdelete = Convert.ToBoolean(dataRow[3]),
                    uisadmin = Convert.ToBoolean(dataRow[4])
                });
            }

            return list;
        }

        public UserInfo GetUserInfo(string uid)
        {
            UserInfo userInfo = null;
            string sqlText = "select UId,username,upassword,uisdelete,uisadmin from UserInfo where username = @Uid";
            SQLiteParameter parameter = new SQLiteParameter("@Uid", uid);
            DataTable dt = SQLiteHelper.ExecuteDataTable(sqlText, parameter);
            if (dt == null || dt.Rows.Count <= 0)
            {
                return userInfo;
            }
            userInfo = new UserInfo();
            userInfo.UId = Convert.ToInt32(dt.Rows[0][0]);
            userInfo.username = dt.Rows[0][1].ToString();
            userInfo.upassword = dt.Rows[0][2].ToString();
            userInfo.uisdelete = Convert.ToBoolean(dt.Rows[0][3]);
            userInfo.uisadmin = Convert.ToBoolean(dt.Rows[0][4]);
            return userInfo;
        }
    }
}
