using System;

namespace Less03_task04
{
    class Program
    {
        static void Main(string[] args)
        {
            BMW auto = new BMW_X5();

            Console.WriteLine(auto.Drive(80));

            Console.ReadKey();
        }
    }

    class BMW
    {
        public virtual string Drive(ushort speed)
        {
            return "I'm a BMW auto and I run with speed " + speed + " km/h";
        }
    }

    class BMW_X5 : BMW
    {
        public override string Drive(ushort speed)
        {
            return "I'm a BMW X5 auto and I run with speed " + speed + " km/h";
        }
    }
}
