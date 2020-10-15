using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class HoaDonNhapBLL: IHoaDonNhapBLL
    {
        private IHoaDonNhapDAL _res;
        public HoaDonNhapBLL(IHoaDonNhapDAL ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public List<HoaDonNhapModel> getallhoadonnhap()
        {
            return _res.GetData();

        }
    }
}
