using Api.Ado.NetCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Ado.NetCore.Repositories
{
    public interface IAlunoRepository
    {
        Task<IEnumerable<AlunoViewModel>> GetAlunos(Aluno aluno);
    }
}
