﻿using System;
using System.Collections.Generic;
using System.Text;

namespace blackboarApp
{
    public class Token
    {
        public string access_token { get; set; }

        public string token_type { get; set; }

        public int expires_in { get; set; }

        public string user_id { get; set; }

        public string error { get; set; }

        public string error_description { get; set; }

        public Token()
        {

        }
    }
}
