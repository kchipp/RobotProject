using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Robot2.cs
{
    class Clean
    {
        public Clean()//constructor
        {
        }
        public void CleanThings()
        {
            JobBot jobs = new JobBot("Dot", 100);
            WashBot wash = new WashBot("Wash", 100, 100);
            DustBot dust = new DustBot("Dusty", 100, "sponge" + "swiffer");
            jobs.SayHello();
            jobs.CallBot();        
            wash.SayHello();
            dust.SayHello();
            Thread.Sleep(1000);           
            wash.Move();
            wash.DoJob();
            wash.WashFloors();
            wash.WashWindows();
            wash.Recharge();
            Thread.Sleep(2000);
            dust.WipeCounters();
            dust.DustFurniture();
            dust.Recharge();

            Console.ReadKey();
        }


    }//class
}//namespace
