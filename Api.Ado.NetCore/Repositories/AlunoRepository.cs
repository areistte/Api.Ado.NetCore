using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Api.Ado.NetCore.Models;
using Dapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Api.Ado.NetCore.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private string config;
        private IHostingEnvironment _env;

        public AlunoRepository(IConfiguration _config, IHostingEnvironment env)
        {
            config = _config["ConnectionStrings"];
            _env = env;
        }

        public async Task<IEnumerable<AlunoViewModel>> GetAlunos(Aluno aluno)
        {
            var parameters = new
            { };

            using (var connection = new SqlConnection(config))
            {
                var result = await connection.QueryMultipleAsync(
                    sql: "Dte_Spr_Sel_Marcas_Lista",
                    param: parameters,
                    commandType: CommandType.StoredProcedure);

                return result.Read<AlunoViewModel>();
            }
        }
    }
}
