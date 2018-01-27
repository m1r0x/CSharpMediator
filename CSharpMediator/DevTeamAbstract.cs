using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMediator
{
    public abstract class DevTeamAbstract
    {
        public string devTeamName;

        public Mediator mediator;

        public DevTeamAbstract(Mediator _m)
        {
            mediator = _m;
        }

        public void SendMessageToMediator(string msg)
        {
            Console.WriteLine("DevTeam Sending Message to Mediator: " + msg);
            mediator.ReceiveMessageFromDevTeam(msg);
        }

        public void ReceiveMessageFromMediator(string msg)
        {
            Console.WriteLine("DevTeam receiving a message from mediator: " + msg);
        }
    }
}
