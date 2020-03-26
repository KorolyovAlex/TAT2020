using System;

namespace DEV_1._3
{
    public class Scooter : Vehicle
    {
        private const byte MIN_SPEED = 40;

        private byte _maxSpeed;

        public Scooter(byte maxSpeed, Engine engine, Chassis chassis, Transmission transmission, string model) : base(engine, chassis, transmission, model)
        {
            MaxSpeed = maxSpeed;
        }

        public byte MaxSpeed
        {
            get => _maxSpeed;
            set
            {
                if (value < MIN_SPEED)
                {
                    throw new ArgumentException("Invalid value for scooter max speed");
                }

                _maxSpeed = value;
            }
        }

        public new string GetInfo()
        {
            return $"Scooter:\nMax speed: {MaxSpeed}\n{base.GetInfo()}";
        }
    }
}