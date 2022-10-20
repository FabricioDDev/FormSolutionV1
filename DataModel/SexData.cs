using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using DB;

namespace DataModel
{
    public class SexData
    {
        public SexData()
        {
            data = new DataAccess();
        }
        private DataAccess data;
        public List<Sex> Listing()
        {
            List<Sex> List = new List<Sex>();
            try
            {
                data.Query("select Id, Sex from SexTable");
                data.Read();
                while (data.PropReader.Read())
                {
                    Sex aux = new Sex();
                    aux.Id = (int)data.PropReader["Id"];
                    aux.Description = (string)data.PropReader["Sex"];
                }
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { data.Close(); }
        }
    }
}
