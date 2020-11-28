using System.Collections.Generic;
using ComRepositorioFake.Mock;

namespace ComRepositorioFake.Contrato
{
    public interface IRepositorio
    {
        void Add(Edicao Edicao);
        List<Edicao> GetAll();
        Edicao RetornaUltimo();
    }
}