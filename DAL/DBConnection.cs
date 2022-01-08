using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
   public abstract class  DBConnection
    {
        protected static SqlConnection con = new SqlConnection("server=HUYNHBAO\\SQLEXPRESS;uid=sa;pwd=18T1021011;database=QuanLyTapHoa");
    }
}
