using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_Svc.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int portNumber = 0;
            string name = "";
            string input = "";
            string serverUrl = "";

            // get name
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();

            // get port number
            Console.WriteLine("Enter port number: ");
            input = Console.ReadLine();

            if (!int.TryParse(input,out portNumber))
            {
                Console.WriteLine("Unable to parse portnumber");
            }

            // get server name
            Console.WriteLine("Enter url for one of the servers in the cluster (leave blank if this is the first server): ");
            serverUrl = Console.ReadLine();


            //Start the server and the client

            Console.WriteLine("Running... press any key to stop.");

            // wait for input to stop the server
            while (true)
            {
                Console.ReadKey();

                Console.WriteLine("Do you wish to stop the server (y/n)?");
                input = Console.ReadLine();

                if (input.ToUpper() == "Y")
                {
                    break;
                }
            }
        }
    }
}
