using Simulacao.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacao.Data.UsuarioData
{
  public class UsuarioDataRepository : IBaseDataRepository<UsuarioDomain>, IUsuarioDataRepository
  {

    private IDbConnection _db;

    public UsuarioDataRepository(string connectionString)
    {
      //this._db = new SqlConnection(connectionString);
    }

    public UsuarioDomain Altualizar(UsuarioDomain entidade)
    {
      throw new NotImplementedException();
    }

    public UsuarioDomain Busca(int id)
    {
      throw new NotImplementedException();
    }

    public List<UsuarioDomain> BuscaCompleta()
    {
      var user1 = new UsuarioDomain { Id = 1, Email = "a", Nome = "a" };
      var user2 = new UsuarioDomain { Id = 1, Email = "a", Nome = "a" };
      var user3 = new UsuarioDomain { Id = 1, Email = "a", Nome = "a" };

      var users = new List<UsuarioDomain>() { user1, user2, user3 };

      return users;
    }

    public UsuarioDomain Cadastrar(UsuarioDomain entidade)
    {
      throw new NotImplementedException();
    }

    public void Exluir(int id)
    {
      throw new NotImplementedException();
    }

    public List<UsuarioDomain> PegarTodos()
    {
      throw new NotImplementedException();
    }
  }
}
