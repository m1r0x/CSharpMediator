using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMediator
{
    public abstract class ClientAbstract
    {
        public Mediator mediator;

        //ctor
        public ClientAbstract(Mediator _m)
        {
            mediator = _m;
        }

    public void SendMessageToMediator(string msg)
        {
            Console.WriteLine("Client Sending Message to Mediator: " + msg);
            mediator.ReceiveMessageFromClient(msg);
        }

        public void ReceiveMessageFromMediator(string msg)
        {
            Console.WriteLine("Client receiving a message from mediator: " + msg);
        }
    }

}
