using System;

namespace AbstractFactoryDesignPattern
{
    public interface RideFactory
    {
        Bike GetBike(string Bike);
        Scooter GetScooter(string Scooter);
    }

    public class HondaFactory : RideFactory
    {
        public Bike GetBike(string Bike)
        {
            switch (Bike.ToLower())
            {
                case "sport":
                    return new SportBike();
                case "regular":
                    return new RegularBike();
                default:
                    throw new ApplicationException("Error");
            }
        }

        public Scooter GetScooter(string Scooter)
        {
            switch (Scooter.ToLower())
            {
                case "sport":
                    return new Scooty();
                case "regular":
                    return new RegularScooter();
                default:
                    throw new ApplicationException("Error");
            }
        }
    }

    public class SuzukiFactory : RideFactory
    {
        public Bike GetBike(string Bike)
        {
            switch (Bike.ToLower())
            {
                case "sport":
                    return new SportBike();
                case "regular":
                    return new RegularBike();
                default:
                    throw new ApplicationException("Error");
            }
        }

        public Scooter GetScooter(string Scooter)
        {
            switch (Scooter.ToLower())
            {
                case "sport":
                    return new Scooty();
                case "regular":
                    return new RegularScooter();
                default:
                    throw new ApplicationException("Error");
            }
        }
    }

    public interface Scooter
    {
        string Name();
    }

    public class Scooty: Scooter
    {
        public string Name()
        {
            return "Scooter - Sports";
        }
    }

    public class RegularScooter: Scooter
    {
        public string Name()
        {
            return "Scooter - Regular";
        }
    }

    public interface Bike
    {
        string Name();
    }

    public class SportBike: Bike
    {
        public string Name()
        {
            return "Bike - Sport";
        }
    }

    public class RegularBike: Bike
    {
        public string Name()
        {
            return "Bike - Regular";
        }
    }

    public class RideClient
    {
        Scooter scooter;
        Bike bike;

        public RideClient(RideFactory factory, string model)
        {
            scooter = factory.GetScooter(model);
            bike = factory.GetBike(model);
        }

        public string GetScooterName()
        {
            return scooter.Name();
        }

        public string GetBikeName()
        {
            return bike.Name();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory Design Pattern");
            RideClient client = new RideClient(new HondaFactory(), "Sport");
            Console.WriteLine(client.GetBikeName());
        }
    }
}
