using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private List<Astronaut> data;
        private SpaceStation()
        {
            this.data = new List<Astronaut>();
        }
        public int Capacity { get; set; }
        public void Add(Astronaut astronaut)
        {
            data.Add(astronaut);
        }
        public bool Remove(string name)
        {

        }
    }
}

