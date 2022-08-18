using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        private List<Player> players;

        public Team(string name, int openPositions, char group)
        {
            this.Name = name;
            this.OpenPositions = openPositions;
            this.Group = group;

            this.players = new List<Player>();
        }

        public string Name { get; set; }
        public int OpenPositions { get; set; }
        public char Group { get; set; }

        public int Count
             => this.players.Count;
        public string AddPlayer(Player player)
        {
            if (this.OpenPositions <= 0)
            {
                return "There are no more open positions.";
            }
            if (string.IsNullOrEmpty(player.Name) ||
                     string.IsNullOrEmpty(player.Position))
            {
                return "Invalid player's information.";
            }
            if (player.Rating < 80)
            {
                return "Invalid player's rating.";
            }

            this.players.Add(player);
            this.OpenPositions--;
            return $"Successfully added {player.Name} to the team. Remaining open positions: {this.OpenPositions}.";


        }
        public bool RemovePlayer(string name)
        {
            bool isThere = false;
            Player playerToRemove = this.players.FirstOrDefault(p => p.Name == name);
            if (playerToRemove != null)
            {
                this.players.Remove(playerToRemove);
                this.OpenPositions++;
                isThere = true;
            }
            return isThere;
        }
        public int RemovePlayerByPosition(string position)
        {
            var playersToRemove = this.players.Where(p => p.Position == position).ToList();
            foreach (var player in playersToRemove)
            {
                this.players.Remove(player);
                this.OpenPositions++;
            }
            return playersToRemove.Count;
        }
        public Player RetirePlayer(string name)
        {
            Player playerToRetire = this.players.Where(p => p.Name == name).FirstOrDefault();
            if (playerToRetire == null)
            {
                return null;
            }

            playerToRetire.Retired = true;
            return playerToRetire;
        }
        public List<Player> AwardPlayer(int games)
            => this.players.FindAll(p => p.Games >= games).ToList();

        public string Report()
        {
            var sb = new StringBuilder();

            HashSet<Player> notRetiredPlayers = new HashSet<Player>();
            foreach (var player in this.players)
            {
                if (player.Retired == false)
                {
                    notRetiredPlayers.Add(player);
                }
            }
            sb
                .AppendLine($"Active players competing for Team {this.Name} from Group {this.Group}:")
                .AppendLine(string.Join(Environment.NewLine, notRetiredPlayers));

            return sb.ToString().TrimEnd();
        }
    }
}
