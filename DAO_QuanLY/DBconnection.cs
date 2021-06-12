using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO_QuanLY
{
    public class DBconnection
    {
        protected static SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-LCECD2C;Initial Catalog=QuanLiKhachSan;Integrated Security=True");
    }

}
