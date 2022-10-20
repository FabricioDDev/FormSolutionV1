using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using DB;

namespace DataModel
{
    public class UserData
    {
        public UserData()
        {
            data = new DataAccess();
        }
        private DataAccess data;

        public List<User>Listing()
        {
            List<User> List = new List<User>();
            try
            {
                data.Sp("ProcedureUserList");
                data.Read();
                while (data.PropReader.Read())
                {
                    User aux = new User();
                    aux.Id = (int)data.PropReader["IdUser"];
                    aux.UserName = (string)data.PropReader["UserName"];
                    aux.UserSubName = (string)data.PropReader["UserSubName"];
                    aux.UserMail = (string)data.PropReader["UserMail"];
                    aux.UserPass = (string)data.PropReader["UserPass"];
                    aux.BornDate = (DateTime)data.PropReader["BornDate"];
                    aux.Country = (string)data.PropReader["Country"];
                    aux.sex = new Sex();
                    aux.sex.Id = (int)data.PropReader["Id"];
                    aux.sex.Description = (string)data.PropReader["Sex"];
                }
                return List;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { data.Close(); }
        }
    }
}
