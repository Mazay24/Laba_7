using System;

namespace Laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            Tesla tesla = new Tesla("Tesla", 350, 2, 500);
            Cy28 cy28 = new Cy28("Cy - 28", 9999, 10, 1000);
            Popeda popeda = new Popeda("Popeda", 5000, 50, 250);

            tesla.NameInfo();
            tesla.DistanceInfo();
            tesla.TonnageInfo();
            tesla.SpeedInfo();
            Console.WriteLine();
            cy28.NameInfo();
            cy28.DistanceInfo();
            cy28.TonnageInfo();
            cy28.SpeedInfo();
            Console.WriteLine();
            popeda.NameInfo();
            popeda.DistanceInfo();
            popeda.TonnageInfo();
            popeda.SpeedInfo();
        }
    }
    abstract class Transport
    {
        public Transport(string name, int speed, double tonnage, int distance)
        {
            Name = name;
            Speed = speed;
            Tonnage = tonnage;
            Distance = distance;
        }
        public abstract string Name { get; set; }
        public abstract int Speed { get; set; }
        public abstract double Tonnage { get; set; }
        public abstract int Distance { get; set; }
    }

    abstract class Auto : Transport
    {
        public Auto(string name, int speed, double tonnage, int distance) : base(name, speed, tonnage, distance) { }
        public abstract void NameInfo();
        public abstract void SpeedInfo();
        public abstract void TonnageInfo();
        public abstract void DistanceInfo();
    }

    abstract class Airplane : Transport
    {
        public Airplane(string name, int speed, double tonnage, int distance) : base(name, speed, tonnage, distance) { }
        public abstract void NameInfo();
        public abstract void SpeedInfo();
        public abstract void TonnageInfo();
        public abstract void DistanceInfo();
    }

    abstract class Ship : Transport
    {
        public Ship(string name, int speed, double tonnage, int distance) : base(name, speed, tonnage, distance) { }
        public abstract void NameInfo();
        public abstract void SpeedInfo();
        public abstract void TonnageInfo();
        public abstract void DistanceInfo();
    }

    class Tesla : Auto
    {
        public Tesla(string name, int speed, double tonnage, int distance) : base(name, speed, tonnage, distance) { }
        public override string Name { get; set; }
        public override int Speed { get; set; }
        public override double Tonnage { get; set; }
        public override int Distance { get; set; }

        public override void NameInfo()
        {
            Console.WriteLine("Наименование авто: " + Name);
        }

        public override void DistanceInfo()
        {
            Console.WriteLine("Дистанция, проезжаемая автомобилем: " + Distance + "км.");
        }

        public override void TonnageInfo()
        {
            Console.WriteLine("Грузоподъемность автомобиля: " + Tonnage + "тонн.");
        }

        public override void SpeedInfo()
        {
            Console.WriteLine("Скорость автомобиля: " + Speed);
        }
    }

    class Cy28 : Airplane
    {
        public Cy28(string name, int speed, double tonnage, int distance) : base(name, speed, tonnage, distance) { }
        public override string Name { get; set; }
        public override int Speed { get; set; }
        public override double Tonnage { get; set; }
        public override int Distance { get; set; }

        public override void NameInfo()
        {
            Console.WriteLine("Наименование самолёта: " + Name);
        }

        public override void DistanceInfo()
        {
            Console.WriteLine("Дистанция, пролетаемая самолетом: " + Distance + "км.");
        }

        public override void TonnageInfo()
        {
            Console.WriteLine("Грузоподъемность самолёта: " + Tonnage + "тонн.");
        }

        public override void SpeedInfo()
        {
            Console.WriteLine("Скорость самолёта: " + Speed);
        }
    }

    class Popeda : Ship
    {
        public Popeda(string name, int speed, double tonnage, int distance) : base(name, speed, tonnage, distance) { }
        public override string Name { get; set; }
        public override int Speed { get; set; }
        public override double Tonnage { get; set; }
        public override int Distance { get; set; }

        public override void NameInfo()
        {
            Console.WriteLine("Наименование корабля: " + Name);
        }

        public override void DistanceInfo()
        {
            Console.WriteLine("Дистанция, проходимая короблём: " + Distance + "км.");
        }

        public override void TonnageInfo()
        {
            Console.WriteLine("Грузоподъемность коробля: " + Tonnage + "тонн.");
        }

        public override void SpeedInfo()
        {
            Console.WriteLine("Скорость коробля: " + Speed);
        }
    }

}
