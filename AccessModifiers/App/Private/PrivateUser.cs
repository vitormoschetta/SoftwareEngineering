namespace App.Private
{
    class PrivateUser  // <-- Sem declarar o 'public' na classe, elas se tornam inacessíveis fora do assembly/namespace
    {
        private string Name;
    }

    class PrivateUserB
    {
        private string Name;
        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name.Trim()))
                Name = name;
        }
        public string GetName()
        {
            return Name;
        }
    }

    class PrivateUserC
    {
        public PrivateUserC(string name)
        {
            Name = name;
        }
        private string Name;

        public string GetName()
        {
            return Name;
        }
    }
}