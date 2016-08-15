using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Robot2.cs
{
    class WashBot : Robot , IIntroduce
    {
        //member variable(s)
        public int cleaningSolution;
        public WashBot(string name, int powerLevel ,int cleaningSolution) : base(name, powerLevel)//constructor
        {
            this.cleaningSolution = cleaningSolution;
        }

        public void SayHello()
        {
            Thread.Sleep(750);
            Console.WriteLine($"\nHi, I'm {name}.  I'll wash your floors or windows");
        }
        public override void Move()
        {
            Console.WriteLine("\nTime to get cleaning...");
        }

        public void WashFloors()
        {
            cleaningSolution -= 10;
            UsePower(10);
            Console.WriteLine("Mop, Mop, Mop the floor");
        }
        public void WashWindows()
        {
            cleaningSolution -= 5;
            UsePower(5);
            Console.WriteLine("Make those windows shine");


        }
    }//class
}//namespace
