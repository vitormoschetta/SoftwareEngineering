namespace Pattern
{
    class Program
    {
        /*
            Alteramos o nome da classe 'Client' para 'ClientAdapter'.

            Implementamos uma composição entre 'ClientAdapter' e 'MySqlCommands' 
            para poder acessar os métodos da classe 'MySqlCommands' mesmo usando 
            a interface 'IDb'.

            A adaptação aqui ocorre na classe 'ClientAdapter'.
        */

        static void Main(string[] args)
        {
            var client = new ClientAdapter(new MySqlCommands());
            client.Insert();
        }
    }
}
