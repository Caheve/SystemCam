using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SystemCam
{
    class Connectionbd
    {
        public static SqlConnection ConectarDB()
        {
            SqlConnection con = new SqlConnection("Server = CAHEVEDESKTOP;Database=SystemCam;integrated security=True");
            con.Open();
            return con;
        }
       
    }
}
