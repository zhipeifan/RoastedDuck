using RoastedDuck.Entitys.Authorize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace RoastedDuck.Extends
{
    public  static  class AuthorizeValid
    {
        public static bool AuthorizeAutograph<T>(this T obj) where T : new()
        {
            if (obj == null||!(typeof(BasicAutohorizeModel).IsAssignableFrom(obj.GetType())))
                throw new Exception("reqeuest is invalid");
            var validItem = obj as BasicAutohorizeModel ;

            List<string> cstr = new List<string>();
            cstr.Add(validItem.Usid.ToString());
            cstr.Add(validItem.OpenId.Replace("-","").Trim());
            cstr.Add(new string(validItem.UserPhone.Trim().Reverse().ToArray()));
            cstr.Add(RDConfig.AuthorizeKEY);
            var _str=string.Join("", cstr.OrderBy(c=>c).ToList());
            var _authorizeStr= MD5Encrypt(_str);
            return _authorizeStr== validItem.Secret;
        }

        /// <summary>
        /// 用MD5加密字符串
        /// </summary>
        /// <param name="password">待加密的字符串</param>
        /// <returns></returns>
        private static string MD5Encrypt(string password)
        {
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] hashedDataBytes;
            hashedDataBytes = md5Hasher.ComputeHash(Encoding.GetEncoding("gb2312").GetBytes(password));
            StringBuilder tmp = new StringBuilder();
            foreach (byte i in hashedDataBytes)
            {
                tmp.Append(i.ToString("x2"));
            }
            return tmp.ToString();
        }

       
    }

    //hashCode = function(str)
    //{
    //    var hash = 0;
    //    if (str.length == 0) return hash;
    //    for (i = 0; i < str.length; i++)
    //    {
    //        char = str.charCodeAt(i);
    //        hash = ((hash << 5) - hash) + char;
    //        hash = hash & hash; // Convert to 32bit integer
    //    }
    //    return hash;
    //}
}