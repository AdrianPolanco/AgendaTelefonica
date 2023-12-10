using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    public class Database: DbContext
    {
        private static Database? instance;
        private Database()
        {

        }

        public static Database GetInstance()
        {
            if(instance == null) { instance = new Database(); }
            return instance;
        }
    }
}
