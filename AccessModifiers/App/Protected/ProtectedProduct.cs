namespace App.Protected
{
    public class ProtectedProduct
    {
        protected string Name;    // <-- só acessível na própria classe ou em classes derivadas
    }

    public class ProtectedProductB
    {
        protected string Name;
        protected void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name.Trim()))
                Name = name;
        }
        protected string GetName()
        {
            return Name;
        }
    }

    public class ProtectedProductC
    {
        protected ProtectedProductC(string name)
        {
            Name = name;
        }
        protected string Name;

        protected string GetName()
        {
            return Name;
        }
    }


}