using EF_Core_Code_First_V1.DAL;
using System;
using System.Linq;

namespace EF_Core_Code_First_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyContext();
            Console.WriteLine("Costumer no banco: " + obj.Orders.Where(x => x.CustomerID == 1).Select( y => y.CustomerID).FirstOrDefault());
        }
    }
}
