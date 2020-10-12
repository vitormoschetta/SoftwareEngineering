using App.Private;
using App.Protected;
using App.Public;

namespace App.Heranca
{
    public class ProductHeranca : PublicProductC
    {

    }

    public class ProductHerancaB : PrivateProductB
    {

    }
    public class ProductHerancaC : ProtectedProductB
    {
        public string GetNameDerivado()
        {
            return GetName();
        }

        public void SetNameDerivado(string name)
        {
            SetName(name);
        }
    }
}