using System;
using System.Collections.Generic;
using System.Text;

namespace blackboarApp
{
    public class Token
    {
        public string redirect_uri { get; set; }
        public string response_type { get; set; }
        public string client_id { get; set; }
        public string scope { get; set; }
        public string state { get; set; }
    }
    public class resultToken
    {
        public Token result { get; set; }
    }
}
