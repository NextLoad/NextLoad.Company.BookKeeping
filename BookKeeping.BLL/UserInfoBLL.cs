using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookKeeping.DAL;
using BookKeeping.Model;

namespace BookKeeping.BLL
{
    public class UserInfoBLL
    {
        private UserInfoDAL uiDal;

        public UserInfoBLL()
        {
            this.uiDal = new UserInfoDAL();
        }
        /// <summary>
        /// 判断登录是否成功
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="pwd"></param>
        /// <param name="ui"></param>
        /// <returns></returns>
        public bool Login(string uid, string pwd, out UserInfo ui)
        {
            ui = uiDal.GetUserInfo(uid);
            if (ui == null)
            {
                return false;
            }

            return true;

        }

    }
}
