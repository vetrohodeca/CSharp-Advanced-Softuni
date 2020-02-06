using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Cars
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tyre> tyres;

        public Cargo(string model, int enginePseed, int enginePower, int cargoWeight, string cargoType, 
            double tyre1Pressure, int TyreAge, double tyre2Pressure,int tyre3Pressure, int inttyre3Age, int tyre4Pressure, int tyre4Age)
        {
            this.Model = model;
            this.
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = Model;
            }
        }
    }
}
