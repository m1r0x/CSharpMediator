using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            //mediator erstellen
            Mediator mediator = new Mediator();

            //client und devteam erstellen
            ClientA client = new ClientA(mediator);
            DevTeamA devteam = new DevTeamA(mediator);

            //referenzen setzen
            mediator.devteam = devteam;
            mediator.client = client;

            //nachricht auslösen
            client.SendMessageToMediator("Hello DevTeam!");

            //antwort auslösen
            devteam.SendMessageToMediator("Hello Client!");

            Console.ReadKey();
        }
    }
}
