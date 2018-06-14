using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoastedDuck.Extends
{
    public class RDConfig
    {
        public static string AuthorizeKEY
        {
            get
            {
                string key = System.Configuration.ConfigurationManager.AppSettings["AuthorizeKEY"];//加密KEY
                if (string.IsNullOrEmpty(key))
                    throw new Exception("验证关键key未配置");
                return key;
            }
        }
        
    }
}