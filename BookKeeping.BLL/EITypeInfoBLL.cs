using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookKeeping.DAL;
using BookKeeping.Model;

namespace BookKeeping.BLL
{
    public class EITypeInfoBLL
    {
        private EITypeInfoDAL eiDal;

        public EITypeInfoBLL()
        {
            this.eiDal = new EITypeInfoDAL();
        }

        public List<EITypeInfo> GetList()
        {
            return eiDal.GEiTypeInfos();
        }
    }
}
