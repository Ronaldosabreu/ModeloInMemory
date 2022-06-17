using Simulacao.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacao.Data.UsuarioData
{
  public interface IUsuarioDataRepository
  {
    List<UsuarioDomain> BuscaCompleta();
  }
}
