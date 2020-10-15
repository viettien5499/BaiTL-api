using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class HoaDonBanBLL
    {
        private IHoaDonBanDAL _res;
        public HoaDonBanBLL(IHoaDonBanDAL ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public List<HoaDonBanModel> getallhoadonban()
        {
            return _res.GetData();

        }
    }
}
