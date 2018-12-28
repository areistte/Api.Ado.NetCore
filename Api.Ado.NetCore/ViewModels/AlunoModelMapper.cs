using Api.Ado.NetCore.Models;
using Dapper.FluentMap.Mapping;

namespace Api.Ado.NetCore.ViewModels
{
    public class AlunoModelMapper : EntityMap<AlunoViewModel>
    {
        public AlunoModelMapper()
        {
            Map(x => x.Id).ToColumn("id_aluno");
            Map(x => x.Nome).ToColumn("nome_aluno");
            Map(x => x.Idade).ToColumn("idade_aluno");
        }
    }
}
