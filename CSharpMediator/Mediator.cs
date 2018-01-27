using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMediator
{
    public class Mediator
    {
        public ClientAbstract client;
        public DevTeamAbstract devteam;

        public void ReceiveMessageFromClient(string msg)
        {
            Console.WriteLine("Receive Message from Client: " + msg);
            devteam.ReceiveMessageFromMediator(msg);
        }

        public void ReceiveMessageFromDevTeam(string msg)
        {
            Console.WriteLine("Receive Message from Dev Team: " + msg);
            devteam.ReceiveMessageFromMediator(msg);
        }
    }
}
