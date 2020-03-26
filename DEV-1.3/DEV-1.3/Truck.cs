using System;

namespace DEV_1._3
{
    public class Truck : Vehicle
    {
        private const ushort MIN_LOAD_CAPACITY = 500;

        private ushort _loadCapacity;

        

        public Truck(ushort loadCapacity, Engine engine, Chassis chassis, Transmission transmission, string model) : base(engine, chassis, transmission, model)
        {
            LoadCapacity = loadCapacity;
        }

        public ushort LoadCapacity
        {
            get => _loadCapacity;
            set
            {
                if (value < MIN_LOAD_CAPACITY)
                {
                    throw new ArgumentException("The value for truck load capacity is too low");
                }

                _loadCapacity = value;
            }
        }

        public new string GetInfo()
        {
            return $"Truck:\nCarrying capacity: {LoadCapacity}\n{base.GetInfo()}";
        }
    }
}