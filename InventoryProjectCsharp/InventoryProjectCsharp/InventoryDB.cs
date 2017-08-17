using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;

namespace InventoryProjectCsharp
{
    public class InventoryDB
    {
        public InventoryDB()
        {
            var conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ECRConsultant\Source\Repos\InventoryProject\InventoryProjectCsharp\InventoryProjectCsharp\InventoryDB.mdf;Integrated Security=True");
            conn.Open();
            Debug.WriteLine("Connection open");
            

            conn.Close();
            Debug.WriteLine("Connection closed");

        }

        public void ListProduct()
        {

        }
    }
}
