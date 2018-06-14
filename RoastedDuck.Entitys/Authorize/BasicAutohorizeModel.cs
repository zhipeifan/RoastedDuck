using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoastedDuck.Entitys.Authorize
{
    /// <summary>
    /// 基础验证信息
    /// </summary>
    public class BasicAutohorizeModel
    {
        public int Usid { get; set; }

        public string OpenId { get; set; }

        public string UserPhone { get; set; }

        public string Secret { get; set; }
    }
}
