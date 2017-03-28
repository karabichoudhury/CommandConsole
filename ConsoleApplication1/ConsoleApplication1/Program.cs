using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var availableCommands = GetAvailableCommands();

            if (args.Length == 0)
            {
                PrintUsage(availableCommands);
                return;
            }

            var parser= new CommandParser(availableCommands);
            var command = parser.ParseCommand(args);

            if (null != command)
                command.Execute();
        }

        static IEnumerable<ICommandFactory> GetAvailableCommands()
        {
            return new ICommandFactory[]
            {
                //new CreateOrderCommand(),
                new UpdateQuantityCommand(),
               // new ShipOrderCommand()
            };
        }

        private static void PrintUsage(IEnumerable<ICommandFactory> availableCommands)
        {
            Console.WriteLine("Usage:LoggingDemo CommandName Arguements");
            Console.WriteLine("Commands:");

            foreach (var command in availableCommands)
            {
                Console.WriteLine("{0}",command.Description);
            }

        }
    }
}
