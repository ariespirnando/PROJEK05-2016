using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_Aries
{
    class Koneksi
    {
        public System.Data.SqlClient.SqlConnection isikoneksi()
        {
            System.Data.SqlClient.SqlConnection kon = new System.Data.SqlClient.SqlConnection();
            kon.ConnectionString = "Data Source = ARIESUI-PC;Initial Catalog = TA_lampost2016; Integrated Security = True";
            return kon;
        }
    }
}
