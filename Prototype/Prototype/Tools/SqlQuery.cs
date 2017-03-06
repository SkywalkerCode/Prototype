using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Tools
{
    /// SQL-запрос в виде строки + аргументы
    /// реализован возврат SQL-команды
    public class SqlQuery
    {
        private string StrQuery;
        private object[] Args;

        public SqlQuery(string strQuery, params object[] args)
        {
            StrQuery = strQuery;
            Args = args;
        }

        public SqlCommand GetSqlCommand(SqlConnection sConn)
        {
            var sCommand = new SqlCommand
            {
                Connection = sConn,
                CommandText = StrQuery.Replace("{", "@").Replace("}", "")
            };
            for (int i = 0; i < Args.Length; i++)
            {
                sCommand.Parameters.AddWithValue(i.ToString(), Args[i].ToString());
            }
            return sCommand;
        }

        public override string ToString()
        {
            return String.Format(StrQuery.Replace("{", "'{").Replace("}", "}'"), Args);
        }
    }
}
