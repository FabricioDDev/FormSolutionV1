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

        public List<User> ListingSP()
        {
            List<User> List = new List<User>();
            try
            {
                data.Sp("StoredUserList");
                data.Read();
                while (data.PropReader.Read())
                {
                    User aux = new User();
                    aux.Id = (int)data.PropReader["IdUser"];
                    aux.UserName = (string)data.PropReader["UserName"];
                    aux.UserSubName = (string)data.PropReader["UserSubName"];
                    aux.UserMail = (string)data.PropReader["UserMail"];
                    aux.UserPass = (string)data.PropReader["UserPass"];
                    aux.Country = (string)data.PropReader["Country"];
                    aux.SexType.Id = (int)data.PropReader["Id"];
                    aux.SexType.Description = (string)data.PropReader["Sex"];
                    aux.BornDate = (DateTime)data.PropReader["BornDate"];
                    List.Add(aux);
                }
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { data.Close(); }
        }
    
        public void InsertSP(User newUser)
        {
            try
            {
                data.Sp("UserInsert");
                data.Parameters("@UserName", newUser.UserName);
                data.Parameters("@UserSubName", newUser.UserSubName);
                data.Parameters("@UserMail", newUser.UserMail);
                data.Parameters("@UserPass", newUser.UserPass);
                data.Parameters("@BornDate", newUser.BornDate);
                data.Parameters("@IdSex", newUser.SexType.Id);
                data.Parameters("@Country", newUser.Country);
                data.Execute();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { data.Close(); }
        }   
    }
}
