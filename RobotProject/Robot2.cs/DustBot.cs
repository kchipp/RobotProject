using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Robot2.cs
{
    class DustBot : Robot, IIntroduce
    {
        public string duster;
        
        public DustBot(string name, int powerLevel, string duster) : base(name, powerLevel)
        {
            this.duster = duster;
        }
        public void SayHello()
        {
            Thread.Sleep(800);
            Console.WriteLine($"Hey there, I'm {name}.  I dust stuff!");
        }

        public void WipeCounters()
        {
            duster = "sponge";
            Thread.Sleep(750);
            UsePower(10);
            Console.WriteLine("Getting all the grime of the counters.");
        }
        public void DustFurniture()
        {
            duster = "swiffer";
            UsePower(10);
            Console.WriteLine("Phew! That furniture needed a cleaning.");


        }

        public override void Move()
        {
            Console.WriteLine("Get my wheels spinning...I love dusting...");

        }
    }//class
}//namespace
