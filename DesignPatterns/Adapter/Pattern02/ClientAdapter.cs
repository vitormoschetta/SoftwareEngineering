namespace Pattern02
{
    public class ClientAdapter : MySqlCommands, IDb
    {    
        public void Insert()
        {
            InsertMySql();
        }

        public void Update()
        {
            UpdateMySql();
        }

        public void Delete()
        {
            DeleteMySql();
        }
    }
}