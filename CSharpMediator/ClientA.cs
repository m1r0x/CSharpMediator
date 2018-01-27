using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMediator
{
    public class ClientA : ClientAbstract
    {
        public ClientA(Mediator _m) : base(_m) { }
    }
}
