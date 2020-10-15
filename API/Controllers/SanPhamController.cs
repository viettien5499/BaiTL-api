using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        private ISanPhamBLL ISanPham;
        public SanPhamController(ISanPhamBLL Isanpham)
        {
            ISanPham = Isanpham;
        }

        [Route("get-sp")]
        [HttpPost]
        public SanPhamModel CreateItem([FromBody] SanPhamModel model)
        {
            ISanPham.Create(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public SanPhamModel GetDatabyID(string id)
        {
            return ISanPham.GetDatabyID(id);
        }
        [Route("get-allsp")]
        [HttpGet]
        public IEnumerable<SanPhamModel> GetDatabAll()
        {
            return ISanPham.GetDataAll();
        }
        [Route("get-spkm")]
        [HttpGet]
        public IEnumerable<SanPhamModel> GetSpKm()
        {
            return ISanPham.GetSpKm();
        }
    }
}
