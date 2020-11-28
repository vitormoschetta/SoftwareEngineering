using System;

namespace Adapter
{
    public class ClasseExistente    // <-- a ser adaptada
    {
        public void MetodoUtil(string texto) {
            Console.WriteLine(texto);
        }
    }


    // Usando herança
    public class AdaptadorHeranca : ClasseExistente
    {
        public void Operacao() {
            MetodoUtil("Texto aqui");
        }
    }


    // Usando composição
    public class AdaptadorComposicao 
    {
        private ClasseExistente _existente;
        public AdaptadorComposicao(ClasseExistente existente)
        {
            _existente = existente;
        }

        public void Operacao() {
            _existente.MetodoUtil("Texto aqui");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // usando herança
            AdaptadorHeranca adaptadorHeranca = new AdaptadorHeranca();
            adaptadorHeranca.Operacao();


            // usando composição
            ClasseExistente existente = new ClasseExistente();
            AdaptadorComposicao adaptadorComposicao = new AdaptadorComposicao(existente);
            adaptadorComposicao.Operacao();
        }
    }    

    
   
}
