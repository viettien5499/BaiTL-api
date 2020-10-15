using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    class NhaCungCapBLL: INhaCungCapBLL
    {
        private INhaCungCapDAL _res;
        public NhaCungCapBLL(INhaCungCapDAL ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public List<NhaCungCapModel> getallnhacungcap()
        {
            return _res.GetData();

        }
    }
}
