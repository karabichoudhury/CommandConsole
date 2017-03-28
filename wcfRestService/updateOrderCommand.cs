using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfRestService
{
    public class updateCommand : ICommand, ICommandFactory
    {
        public string CommandName
        {
            get { return "Update"; }
        }

        public string Description
        {
            get { return "Update the Db"; }
        }

        public int NewQuantity { get; set; }
        public ICommand MakeCommand(string[] arguements)
        {
            return new updateCommand { NewQuantity = int.Parse(arguements[1]) };
        }

        public void Execute()
        {
            const int oldQuantity = 5;
            Console.WriteLine("DATABASE:Updated");

            Console.WriteLine("LOG:Updated order quantity from {0} to {1}", oldQuantity, NewQuantity);
            
        }
    }
}