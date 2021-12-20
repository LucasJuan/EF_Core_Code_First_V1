using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Code_First_V1.Model
{
    class UserOrder
    {
        public int UserOrderID { get; set; }
        public virtual int OrderID { get; set; }
        public virtual int UserID { get; set; }
        public virtual User User { get; set; }
        public virtual Order Order { get; set; }
        public string Detail { get; set; }


    }
}
