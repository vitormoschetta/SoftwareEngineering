namespace Pattern
{
    public class ClientAdapter : IDb
    {
        private MySqlCommands _mysql;
        public ClientAdapter(MySqlCommands mysql)
        {
            _mysql = mysql;
        }

        public void Insert()
        {
            _mysql.InsertMySql();
        }

        public void Update()
        {
            _mysql.UpdateMySql();
        }

        public void Delete()
        {
            _mysql.DeleteMySql();
        }
    }
}