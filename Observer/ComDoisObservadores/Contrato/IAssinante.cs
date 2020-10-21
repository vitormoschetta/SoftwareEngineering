namespace ComDoisObservadores.Contrato
{
    //   Contrato necessário para impor o uso do método Notificar(), pelo qual a Editora
    // irá notificar todos os assinantes.

    //   Também é necessário para que a Editora possa Add qualquer TIPO de Assinante, através
    // da segregação por interface, onde Editora não depende da implementação concreta dos 
    // assinantes, mas de uma abstração, que é esta interface. 
    public interface IAssinante
    {
        void Notificar(string numeroNovaEdicao);
    }
}