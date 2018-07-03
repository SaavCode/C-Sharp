using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIfElse
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch(season)
            {

                case Season.Autumn:
                    Console.WriteLine("Weve got a promotion");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's perfect to go to the beach");
                    break;
                default:
                    Console.WriteLine("What is this season");
                    break;

            }

        }
    }
}
