namespace App.Ineternal
{
    internal class InternalProduct
    {
        internal string Name;    // <-- só acessível dentro do assembly/namespace
    }

    public class InternalProductB
    {
        private string Name;
        internal void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name.Trim()))
                Name = name;
        }
        internal string GetName()
        {
            return Name;
        }
    }

    public class InternalProductC
    {
        internal InternalProductC(string name)
        {
            Name = name;
        }
        private string Name;

        internal string GetName()
        {
            return Name;
        }
    }


}