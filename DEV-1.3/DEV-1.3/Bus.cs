using System;

namespace DEV_1._3
{
    public class Bus : Vehicle
    {
        private const byte MIN_SEATS_NUMBER = 10;

        private byte _seatsNumber;

        public Bus(byte seatsNumber, Engine engine, Chassis chassis, Transmission transmission, string model) : base(engine, chassis, transmission, model)
        {
            SeatsNumber = seatsNumber;
        }

        public byte SeatsNumber
        {
            get => _seatsNumber;
            set
            {
                if (value < MIN_SEATS_NUMBER)
                {
                    throw new ArgumentException($"The bus can't have less than {MIN_SEATS_NUMBER} seats");
                }

                _seatsNumber = value;
            }
        }

        public new string GetInfo()
        {
            return $"Bus:\nNumber of seats: {SeatsNumber}\n{base.GetInfo()}";
        }
    }
}