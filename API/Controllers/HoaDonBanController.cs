using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoaDonBanController : ControllerBase
    {
        private IHoaDonBanBLL IHoaDonBan;
        public HoaDonBanController(IHoaDonBanBLL Ihoadonban)
        {
            IHoaDonBan = Ihoadonban;
        }
        // GET: api/<HoaDonBanController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<HoaDonBanController>/5
        [Route("gethdb")]
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HoaDonBanController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HoaDonBanController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HoaDonBanController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
