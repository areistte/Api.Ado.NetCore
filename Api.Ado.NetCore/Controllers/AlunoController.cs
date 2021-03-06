﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Api.Ado.NetCore.Models;
using Api.Ado.NetCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Api.Ado.NetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private IAlunoRepository _repository;

        public AlunoController(IAlunoRepository repository)
        {
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlunoViewModel>>> GetAlunosAll()
        {
            var aluno = new Aluno();
            return Ok(await _repository.GetAlunos(aluno));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<AlunoViewModel>>> GetAlunosAll(int id)
        {
            var aluno = new Aluno();
            aluno.IdAluno = id;

            return Ok(await _repository.GetAlunos(aluno));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

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
