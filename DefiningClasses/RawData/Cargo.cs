﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {
        private int weight;
        private string type;
        
        public Cargo(int weigth, string type)
        {
            this.Weight = weight;
            this.Type = type; 
        }
        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.Weight = weight;
            }
        }
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.Type = type;
            }
        }

    }
}
