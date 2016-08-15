using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Robot2.cs
{
    public abstract class Robot
    {
        protected string name;
        protected int powerLevel;

        public Robot(string name, int powerLevel)
        {
            this.name = name;
            this.powerLevel = powerLevel;
        }
        public abstract void Move();
        
        public void DoJob()
        {
            Console.WriteLine("Let's get the job done.");
        }
        public void UsePower(int amount)
        {
            powerLevel -= amount;
        }
        public void Recharge()
        {
            if (powerLevel <= 100)
            {
                while (powerLevel < 101)
                {
                    Thread.Sleep(500);
                    Console.WriteLine($"Power level at: {powerLevel}  Charging...");
                    powerLevel += 10;
                }
                Console.WriteLine($"That's better.");
            }
            else
            {
                Console.WriteLine($"The power level is {powerLevel}, charging is not required");

            }

        }

    }
}



