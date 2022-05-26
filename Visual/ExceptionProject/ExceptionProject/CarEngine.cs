using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProject
{
    public class CarEngine
    {
        public string Name { get; set; }
        public bool Working { get; private set; }

        public CarEngine(string name)
        {
            Working = false;
            Name = name;
        }

        public void StartEngine()
        {
            if (Working)
                throw new EngineException(this, "The engine is already working");

            Working = true;
        }

        public void StopEngine()
        {
            Working = false;
        }
    }

    public class EngineException : ApplicationException
    {
        CarEngine engine;

        public EngineException(CarEngine engine, string message) : base(message)
        {
            this.engine = engine;
        }
        public CarEngine Engine
        {
            get { return engine; }
        }
    }
}
