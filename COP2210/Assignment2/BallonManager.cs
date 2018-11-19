using System;
namespace COP2210.Assignment2
{
    internal class BallonManager : IManager
    {
        internal BallonManager()
        {
        }


        void IManager.Assignment()
        {
            var balloon = new Balloon("ben balloon", 150);
            var balloon2 = new Balloon("second balloon", -50);

            Console.WriteLine($"Balloon name: {balloon.getName()}  Height: {balloon.getAltitude()}");
            Console.WriteLine($"Balloon name: {balloon2.getName()}  Height: {balloon2.getAltitude()}");


            balloon.ascendTo(200);
            balloon2.adjustAltitude(100);

            Console.WriteLine($"Balloon name: {balloon.getName()}  Height: {balloon.getAltitude()}");
            Console.WriteLine($"Balloon name: {balloon2.getName()}  Height: {balloon2.getAltitude()}");

            balloon.adjustAltitude(-50);
            balloon2.ascendTo(balloon.getAltitude());


            Console.WriteLine($"Balloon name: {balloon.getName()}  Height: {balloon.getAltitude()}");
            Console.WriteLine($"Balloon name: {balloon2.getName()}  Height: {balloon2.getAltitude()}");

            balloon.ascendTo(balloon.getAltitude() * 3);
            balloon2.ascendTo(balloon2.getAltitude() - 200);

            Console.WriteLine($"Balloon name: {balloon.getName()}  Height: {balloon.getAltitude()}");
            Console.WriteLine($"Balloon name: {balloon2.getName()}  Height: {balloon2.getAltitude()}");
        }
    }
}
