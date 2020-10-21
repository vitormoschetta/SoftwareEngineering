using System;

namespace ComDoisObservadores
{
    class Program
    {
        static void Main(string[] args)
        {
            var editora = new Editora();
            var assinanteA = new AssinanteA(editora);
            var assinanteB = new AssinanteB(editora);
            editora.PublicarEdicao("Ed 25");
        }
    }
}
