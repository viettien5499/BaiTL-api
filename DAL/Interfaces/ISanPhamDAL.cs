using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface ISanPhamDAL
    {
        List<SanPhamModel> GetDataAll();
        bool Create(SanPhamModel model);
        SanPhamModel GetDatabyID(string id);
        List<SanPhamModel> Search(int pageIndex, int pageSize, out long total, string item_group_id);
        List<SanPhamModel> GetSpKM();
    }
}
