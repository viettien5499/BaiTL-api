﻿using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IHoaDonNhapDAL
    {
        List<HoaDonNhapModel> GetData();
    }
}
