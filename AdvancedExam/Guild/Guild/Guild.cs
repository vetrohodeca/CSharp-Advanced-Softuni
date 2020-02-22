using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Guild
{
    class Guild
    {
        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.roster = new List<Player>();
        }
        public int Count => this.roster.Count;
        private List<Player> roster;
        public string Name { get; set; }
        public int Capacity { get; set; }
        
        public void AddPlayer(Player player)
        {
            if(this.roster.Count<this.Capacity)
            {
                this.roster.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            Player player = this.roster.FirstOrDefault(p=>p.Name==name);
            if(player!=null)
            {
                this.roster.Remove(player);
                return true;
            }
            return false;
        }
        public void PromotePlayer(string name)
        {
            Player player = this.roster.FirstOrDefault(p => p.Name == name);
            if(player.Rank!="Member")
            player.Rank = "Member";
        }
        public void DemotePlayer(string name)
        {
            Player player = this.roster.FirstOrDefault(p => p.Name == name);
            if (player.Rank != "Trial")
                player.Rank = "Trial";
        }
        public Player[] KickPlayersByClass(string classs)
        {
            Player[] players = this.roster.Where(p => p.Class == ).ToArray();
            foreach (Player player in players)
            {
                this.roster.Remove(player);
            }
            return players;
        }
        public string Report()
        {
            StringBuilder sb= new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach(var elements in this.roster)
            {
               sb.AppendLine(elements.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
