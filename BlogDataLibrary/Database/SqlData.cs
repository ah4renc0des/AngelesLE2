using BlogDataLibrary.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDataLibrary.Database
{
    public class SqlData
    {
        private IsqlDataAccess _db;
        private const string connectionStringName = "SqlDb";

        public SqlData(IsqlDataAccess db)
        {
            _db = db;
        }
    }
}
