namespace App.Public
{
    public class PublicProduct
    {
        public string Name;     // <-- acessível em qualquer lugar
    }

    public class PublicProductB
    {
        public string Name { get; private set; } = "Product B";    // <-- acessível para recuperar, mas não para modificar
    }

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

    }
}