using Pattern.Interfaces;

namespace Pattern.Models
{
    public class MySqlAdapter : IDbAdapter
    {
        private MySqlCommands _mysql;
        public MySqlAdapter(MySqlCommands mysql)
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