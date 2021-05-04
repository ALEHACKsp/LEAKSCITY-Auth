using LEAKSCITY_Auth.Helpers;
using LEAKSCITY_Auth.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LEAKSCITY_Auth
{
    public class Auth
    {
        private readonly HWID _userHWID = new HWID();

        public AuthModel Login(string authkey)
        {
            var authResponse = new AuthModel  
            {
                AuthStatus = false
            };

            //Request z danymi logowania
            string checkauth = Web.CreateRequest("", "https://leakscity.cc/ui_pub/auth/?key=" + authkey + "&hwid=" + _userHWID.getHWID());
            //Deserializacja zwróconych danych
            authResponse = JsonConvert.DeserializeObject<AuthModel>(checkauth);
            return authResponse;
        }
    }
}
