using System;

namespace ComValidacaoDeObjetoObservado
{
    public class Assinante
    {
        Editora editoraObservada;
        public Assinante(Editora editora)
        {
            editoraObservada = editora;
            editoraObservada.AddAssinante(this);
        }

        public void Notificar(Editora editora)
        {
            if (editora == editoraObservada)
                Console.WriteLine("Nova Publicação: " + editora.GetEdicao());
        }
    }
}