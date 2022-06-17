using Microsoft.AspNetCore.Mvc;
using Simulacao.Data;
using Simulacao.Data.UsuarioData;
using Simulacao.Domain;
using System.Collections.Generic;

namespace SimulacaoEmprestimo.Controllers.Usuario
{
  [ApiController]
  [Route("[controller]")]
  public class UsuarioController : ControllerBase
  {

    static string conString = @"Data Source = NOTBD7C5G3; Initial Catalog = DbProjetoDapper; Integrated Security = True; 
        Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
    static readonly IBaseDataRepository<UsuarioDomain> respository = new UsuarioDataRepository(conString);
    static readonly IUsuarioDataRepository UsuarioRespository = new UsuarioDataRepository(conString);

    [HttpGet]
    public IEnumerable<UsuarioDomain> Get()
    {
      return UsuarioRespository.BuscaCompleta();
    }
  }
}
