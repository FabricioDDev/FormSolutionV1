using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DB
{
    public class DataAccess
    {
        public DataAccess()
        {
            connection = new SqlConnection("server=BRENDA-PC; database=UserForm_DB; integrated security=true");
            command = new SqlCommand();
        }
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public SqlDataReader PropReader
        {
            get { return reader; }
        }
        public void Query(string query)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;
        }
        public void Sp(string sp)
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = sp;
        }
        public void Read()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Parameters(string Parameter, object Value)
        {
            command.Parameters.AddWithValue(Parameter, Value);
        }
        public void Execute()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Close()
        {
            if (reader != null)
                reader.Close();
            connection.Close();
        }
    }
}
