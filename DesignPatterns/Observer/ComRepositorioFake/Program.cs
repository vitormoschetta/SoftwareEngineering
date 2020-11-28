using System;
using ComRepositorioFake.Mock;

namespace ComRepositorioFake
{
    class Program
    {
        static void Main(string[] args)
        {
            var edicaoRepositorio = new EdicaoRepositorio();
            var editora = new Editora(edicaoRepositorio);
            var assinanteA = new AssinanteA(editora);
            var assinanteB = new AssinanteB(editora);
            var edicao = new Edicao("Titulo", "Ed 99");
            editora.PublicarEdicao(edicao);
        }
    }
}
