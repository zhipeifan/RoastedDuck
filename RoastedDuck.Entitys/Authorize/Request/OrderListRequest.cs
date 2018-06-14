using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoastedDuck.Entitys.Authorize.Request
{
    public class OrderListRequest:BasicAutohorizeModel
    {
       public int PageIndex { get; set; }

        public int PageSize { get; set; }
    }
}
