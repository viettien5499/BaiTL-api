using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class SanPhamBLL: ISanPhamBLL
    {
        private ISanPhamDAL _res;
        public SanPhamBLL(ISanPhamDAL ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Create(SanPhamModel model)
        {
            return _res.Create(model);
        }
        public SanPhamModel GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<SanPhamModel> GetDataAll()
        {
            return _res.GetDataAll();
        }
        public List<SanPhamModel> Search(int pageIndex, int pageSize, out long total, string item_group_id)
        {
            return _res.Search(pageIndex, pageSize, out total, item_group_id);
        }
        public List<SanPhamModel> GetSpKm()
        {
            return _res.GetSpKM();
        }
    }
}
