using System.Collections.Generic;
using System.Linq;
using ComRepositorioFake.Contrato;

namespace ComRepositorioFake.Mock
{
    public class EdicaoRepositorio : IRepositorio
    {
        private List<Edicao> list;

        public EdicaoRepositorio()
        {
            list = new List<Edicao>();
        }
        public void Add(Edicao Edicao)
        {
            list.Add(Edicao);
        }

        public List<Edicao> GetAll()
        {
            return list;
        }

        public Edicao RetornaUltimo()
        {
            return list.Last();
        }
    }
}