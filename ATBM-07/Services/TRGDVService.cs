using ATBM_07.Helpers;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_07.Services
{
    internal class TRGDVService
    {
        public static DataTable Get_MoMon_TRGDV()
        {
            using (var cmd = new OracleCommand("SELECT * FROM user_admin.V_MOMON_TRGDV", DatabaseHelper.Connection))
            using (var adapter = new OracleDataAdapter(cmd))
            {
                var table = new DataTable();
                try
                {
                    adapter.Fill(table);
                    return table;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show($"Oracle Error [{ex.Number}]: {ex.Message}");
                    return null;
                }
            }
        }
    }
}
