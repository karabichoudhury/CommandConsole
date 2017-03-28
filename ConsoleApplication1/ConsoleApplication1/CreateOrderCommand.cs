using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class CreateOrderCommand : ICommand
    {
        public int NewQuantity { get; set; }
        public void Execute()
        {
            const int oldQuantity = 5;
            Console.WriteLine("DATABASE:Created");

            Console.WriteLine("LOG:Created order quantity from {0} to {1}", oldQuantity, NewQuantity);
        }
    }
}
