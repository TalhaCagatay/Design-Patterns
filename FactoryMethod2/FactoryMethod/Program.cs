using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicleFactory = new VehicleFactory();

            IVehicle vehicleCar = vehicleFactory.ProduceVehicle(VehicleType.Car);
            vehicleCar.DisplayInfo();

            IVehicle vehicleMotorcycle = vehicleFactory.ProduceVehicle(VehicleType.Motorcycle);
            vehicleMotorcycle.DisplayInfo();
        }
    }

    public interface IVehicle
    {
        void DisplayInfo();
    }

    public class Car : IVehicle
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Araba üretildi");
        }
    }

    public class Truck : IVehicle
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Kamyon üretildi");
        }
    }

    public class Motorcycle : IVehicle
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Motor üretildi");
        }
    }

    public enum VehicleType
    {
        Car = 1,
        Truck = 2,
        Motorcycle = 3
    }

    public interface IVehicleFactory
    {
        IVehicle ProduceVehicle(VehicleType type);
    }

    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle ProduceVehicle(VehicleType type)
        {
            IVehicle vehicle = null;
            switch (type)
            {
                case VehicleType.Car:
                    vehicle = new Car();
                    break;
                case VehicleType.Truck:
                    vehicle = new Truck();
                    break;
                case VehicleType.Motorcycle:
                    vehicle = new Motorcycle();
                    break;
            }
            return vehicle;
        }
    }
}
