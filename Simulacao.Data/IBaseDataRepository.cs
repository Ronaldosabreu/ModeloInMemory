using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacao.Data
{
	public interface IBaseDataRepository<T>
	{
		//crud
		T Busca(int id);
		List<T> PegarTodos();
		T Cadastrar(T entidade);
		T Altualizar(T entidade);
		void Exluir(int id);
	}
}
