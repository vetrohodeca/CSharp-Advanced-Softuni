using System;
using System.Collections.Generic;
using System.Text;

namespace Salesman
{
    class Engine
    {
        private string model;
        private int power;
        private int? displacement;
        private string efficiency;
        public int Power { get; set; }
        public string Model{ get; set; }
        public int? Displacement { get; set; }
        public string Efficiency { get; set; }
        public Engine (string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }
        public Engine(string model, int power, int displacement):this(model,power)
        {
            this.Displacement = displacement;
        }
        public Engine(string model, int power, int? displacement, string efficiency):this(model,power, displacement)
        {

        }
    }
}
