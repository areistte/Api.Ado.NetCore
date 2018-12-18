using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Ado.NetCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Api.Ado.NetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IConfiguration _config;

        public AlunoController(IConfiguration config)
        {
            _config = config;
        }



        //private readonly AlunoRepository _alunoRepository;

        //public AlunoController()
        //{
        //    _alunoRepository = new AlunoRepository();
        //}

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            var _con = new SqlConnection(Configuration.GetConnectionString("cnnString"));

            //var data = _alunoRepository.BuscaTodos();
            //return Ok(data);
            string cnnstr;
            cnnstr = _config["cnnString"];
            return Ok("cnnstr");
        }





        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
