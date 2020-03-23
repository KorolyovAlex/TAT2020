using System;

namespace DEV_1._3
{
    abstract class Vehicle
    {
        private Engine _engine;
        private Chassis _chassis;
        private Transmission _transmission;
        private string _model;

        public Engine Engine
        {
            get
            {
                return _engine;
            }
            set
            {
                _engine = value ?? throw new ArgumentNullException("");
            }
        }

        public Chassis Chassis
        {
            get
            {
                return _chassis;
            }
            set
            {
                _chassis = value ?? throw new ArgumentNullException("");
            }
        }

        public Transmission Transmission
        {
            get
            {
                return _transmission;
            }
            set
            {
                _transmission = value ?? throw new ArgumentNullException("");
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            protected set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("");
                }

                _model = value;
            }
        }

        protected Vehicle(Engine engine, Chassis chassis, Transmission transmission, string model)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            Model = model;
        }

        protected string GetInfo()
        {
            return $"Model: {Model}\n\n{Engine.GetInfo()}\n{Transmission.GetInfo()}\n{Chassis.GetInfo()}";
        }
    }
}
