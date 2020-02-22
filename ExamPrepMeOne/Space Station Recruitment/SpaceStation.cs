using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SpaceStationRecruitment
{
    class SpaceStation
    {
        private List<Astronaut> data;
        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Astronaut>();
        }
        public void Add(Astronaut astronaut)
        {
            if (this.data.Count < this.Capacity)
            {
                this.data.Add(astronaut);
            }
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => this.data.Count;
        public bool Remove(string name)
        {
            foreach (var item in data)
            {
                if (item.Name == name)
                {
                    data.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public Astronaut GetOldestAstronaut()
        {
            return this.data.OrderByDescending(a => a.Age).FirstOrDefault();
        }
        public Astronaut GetAstronaut(string name)
        {
            return this.data.FirstOrDefault(a => a.Name == name);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Astronauts working at Space Station {Name}:");
            foreach (var item in data)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }

}

