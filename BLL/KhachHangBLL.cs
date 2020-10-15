using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class KhachHangBLL
    {
        private IKhachHangDAL _res;
        public KhachHangBLL(IKhachHangDAL ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public List<KhachHangModel> getallkhachhang()
        {
            return _res.GetData();

        }
    }
}
