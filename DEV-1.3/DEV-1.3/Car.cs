using System;

namespace DEV_1._3
{
    class Car : Vehicle
    {
        private string _type;

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
            }
        }
        public Car(string type, Engine engine, Chassis chassis, Transmission transmission, string model) : base(engine, chassis, transmission, model)
        {
            _type = type;
        }

        public new string GetInfo()
        {
            return $"Car:\nType: {_type}\n{base.GetInfo()}";
        }
    }
}
