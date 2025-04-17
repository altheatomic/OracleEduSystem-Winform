using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ATBM_07.Services
{
    public static class ObjectService
    {
        public static List<string> GetTables() => LoadObjectsFromProcedure("get_user_tables");
        public static List<string> GetViews() => LoadObjectsFromProcedure("get_user_views");
        public static List<string> GetProcedures() => LoadObjectsFromProcedure("get_user_procedures");
        public static List<string> GetFunctions() => LoadObjectsFromProcedure("get_user_functions");

        private static List<string> LoadObjectsFromProcedure(string procName)
        {
            var list = new List<string>();
            using (var conn = new OracleConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new OracleCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            list.Add(reader.GetString(0));
                }
            }
            return list;
        }

        public static List<string> GetCompatibleObjects(string privilege)
        {
            var list = new List<string>();
            using (var conn = new OracleConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new OracleCommand("get_compatible_objects", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_privilege", OracleDbType.Varchar2).Value = privilege;
                    cmd.Parameters.Add("p_result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            list.Add(reader.GetString(0));
                }
            }
            return list;
        }

        public static List<string> GetTableColumns(string tableName)
        {
            var columns = new List<string>();
            using (var conn = new OracleConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new OracleCommand(
                    "SELECT COLUMN_NAME FROM ALL_TAB_COLUMNS WHERE TABLE_NAME = :tbl AND OWNER = USER ORDER BY COLUMN_ID", conn))
                {
                    cmd.Parameters.Add(new OracleParameter("tbl", tableName.ToUpper()));
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            columns.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return columns;
        }


    }
}
