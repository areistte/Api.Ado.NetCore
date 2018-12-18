using Api.Ado.NetCore.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Api.Ado.NetCore.Repositories
{
    public class AlunoRepository
    {
        private readonly IConfiguration _config;

        public AlunoRepository(IConfiguration config)
        {
            _config = config;
        }


        //private SqlConnection _con;

        //public void Connection()
        //{
        //    IConfiguration _config;
        //    _con = new SqlConnection(_config.GetConnectionString("cnnString"));
        //}

        //public List<Aluno> BuscaTodos()
        //{
        //    var _con = new SqlConnection(Configuration.GetConnectionString("cnnString"));

        //    List<Aluno> aluno_list = new List<Aluno>();

        //    using (SqlCommand command = new SqlCommand("mhb_sp_listar_usuarios", _con))
        //    {
        //        command.CommandType = CommandType.StoredProcedure;

        //        _con.Open();

        //        SqlDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            Aluno aluno = new Aluno()
        //            {
        //                Id = Convert.ToInt32(reader["id_aluno"]),
        //                Nome = Convert.ToString(reader["nome"]),
        //                Idade = Convert.ToInt32(reader["idade"])
        //            };

        //            aluno_list.Add(aluno);
        //        }

        //        _con.Close();

        //        return aluno_list;
        //    }
        //}



        public void BuscaTodos()
        {
            _config.GetConnectionString("cnnString");

            int teste = 4;
        }

    }
}
