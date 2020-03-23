using System;

namespace DEV_1._3
{
    class Scooter : Vehicle
    {
        private byte _maxSpeed;

        public byte MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
            set
            {
                if(value < 40)
                {
                    throw new ArgumentException();
                }

                _maxSpeed = value;
            }
        }

        public Scooter(byte maxSpeed, Engine engine, Chassis chassis, Transmission transmission, string model) : base(engine, chassis, transmission, model)
        {
            MaxSpeed = maxSpeed;
        }

        public new string GetInfo()
        {
            return $"Scooter:\nMax speed: {MaxSpeed}\n{base.GetInfo()}";
        }
    }
}
