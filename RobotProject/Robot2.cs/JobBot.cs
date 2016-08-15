using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot2.cs
{
    class JobBot : Robot, IIntroduce, ICall
    {
        public JobBot(string name, int powerLevel) : base(name, powerLevel)
        {
        }
        public override void Move()
        {
            Console.WriteLine("Let's get Wash and Dusty and get going.");
        }
        public void CallBot()
        {
            Console.WriteLine("Dusty... \nWash...  \nIntroduce yourselves");
         
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello.  I'm {name}.  I help the other Bots know what needs to be done.  I'm here to help.");
        }
    }
}
