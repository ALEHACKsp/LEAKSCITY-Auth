using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAKSCITY_Auth.Model
{
    public class AuthModel
    {
        [JsonProperty("auth_status")]
        public bool AuthStatus { get; set; }
        [JsonProperty("user_level")]
        public int KeyLevel { get; set; }
        [JsonProperty("user_nick")]
        public string Username { get; set; }
        [JsonProperty("user_likes")]
        public int Likes { get; set; }
        [JsonProperty("user_posts")]
        public int Posts { get; set; }
        [JsonProperty("user_rep")]
        public int Reputation { get; set; }
        [JsonProperty("user_group")]
        public int GroupID { get; set; }
    }
}
