using System;

namespace DEV_1._3
{
    class Bus : Vehicle
    {
        private const byte minSeatsNumber = 10;

        private byte _seatsNumber;

        public byte SeatsNumber
        {
            get
            {
                return _seatsNumber;
            }
            set
            {
                if(value < minSeatsNumber)
                {
                    throw new ArgumentException();
                }
            }
        }

        public Bus(byte seatsNumber, Engine engine, Chassis chassis, Transmission transmission, string model) : base(engine, chassis, transmission, model)
        {
            SeatsNumber = seatsNumber;
        }

        public new string GetInfo()
        {
            return $"Bus:\nNumber of seats: {SeatsNumber}\n{base.GetInfo()}";
        }
    }
}
