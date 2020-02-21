namespace SpaceStationRecruitment
{
    public class Astronaut
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public Astronaut(int age, string name, string country)
        {
            this.Age = age;
            this.Name = name;
            this.Country = country;
        }
        public override string ToString()
        {
            return $"Astronaut: {this.Name} {this.Country} {this.Age}";
        }
    }
}
