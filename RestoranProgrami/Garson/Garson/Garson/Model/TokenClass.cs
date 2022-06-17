using System;
using System.Collections.Generic;
using System.Text;

namespace Garson.Model
{
    public class TokenClass
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int waiter_Id { get; set; }
        public string waiter_Name { get; set; }
        public int expires_in { get; set; }
        public int creation_Time { get; set; }
        public int expiration_Time { get; set; }
    }
}
