using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class UpdateQuantityCommand : ICommand,ICommandFactory
    {
        public string CommandName
        {
            get { return "UpdateQuantity"; }
        }

        public string Description
        {
            get { return "UpdateQuatity number";}
        }

        public  int NewQuantity { get; set; }
        public void Execute()
        {
            const int oldQuantity = 5;
            Console.WriteLine("DATABASE:Updated");

            Console.WriteLine("LOG:Updated order quantity from {0} to {1}",oldQuantity,NewQuantity);
        }

        public ICommand MakeCommand(string[] arguements)
        {
            return new UpdateQuantityCommand {NewQuantity = int.Parse(arguements[1])} ;
        }
    }
}
