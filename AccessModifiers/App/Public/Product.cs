namespace App.Public
{
    public class PublicProduct
    {
        public string Name;     // <-- acessível para recuperar e alterar
    }

    public class PublicProductB
    {
        public string Name { get; private set; } = "Product B";    // <-- acessível para recuperar, mas não para modificar
    }                                                              // modificação deve ser implementada via método publico

    public class PublicProductC
    {
        public string Name { get; private set; }    // <-- acessível para recuperar, mas não para modificar

        public void SetName(string name)    // <-- método para modificar o Name a qualquer momento.
        {                                   // Essa estratégia é utilizada para impor validações necessárias

            if (!string.IsNullOrEmpty(name.Trim()))
                Name = name;
        }
    }

    public class PublicProductD
    {
        public PublicProductD(string name)  // <-- Setar o Name apenas no momento da instancia/criação do objeto
        {                                   // Essa tbm é uma estratégia para impor validações necessárias

            if (!string.IsNullOrEmpty(name.Trim()))
                Name = name;
        }

        public string Name { get; private set; }    // <-- acessível para recuperar, mas não para modificar
                                                    // modificação deve ser implementada via método publico

    }


}