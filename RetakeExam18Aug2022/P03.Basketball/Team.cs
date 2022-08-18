using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        private ICollection<Player> players;

        public Team(string name, int openPosition, char group)
        {
            this.Name = name;
            this.OpenPosition = openPosition;
            this.Group = group;

            this.players = new List<Player>();
        }

        public string Name { get; set; }
        public int OpenPosition { get; set; }
        public char Group { get; set; }

       public int Count
            => this.players.Count;
       public string AddPlayer(Player player)
        {
            if (!string.IsNullOrEmpty(player.Name) &&
               !string.IsNullOrEmpty(player.Position))
            {
                if (this.OpenPosition == 0)
                {
                    return "There are no more open positions.";
                }
                else if (player.Rating < 80)
                {
                    return "Invalid player's rating.";
                }
                this.players.Add(player);
                this.OpenPosition--;
                return $"Successfully added {player.Name} to the team. Remaining open positions: {this.OpenPosition}.";
            }
            return "Invalid player's information.";
        }
       public bool RemovePlayer(string name)
        {
            bool isThere = false;
            Player playerToRemove = this.players.FirstOrDefault(p => p.Name == name);
            if (playerToRemove != null)
            {
                this.players.Remove(playerToRemove);
                this.OpenPosition++;
                isThere = true;
            }
            return isThere;
        }
       public int RemovePlayerByPosition(string position)
        {
            var playersToRemove = this.players.Where(p => p.Position == position).ToList();
            this.OpenPosition -= playersToRemove.Count;
            return playersToRemove.Count;
        }
       public Player RetirePlayer(string name)
        {
            Player playerToRetire = this.players.FirstOrDefault(p => p.Name == name);
            if (playerToRetire != null)
            {
                playerToRetire.Retired = true;
            }
            return playerToRetire;
        }
       public List<Player> AwardPlayer(int games)
        {
            var playersToAward = this.players.Where(p => p.Games > games).ToList();
            return playersToAward;
        }
       public string Report()
        {
            var sb = new StringBuilder();

            HashSet<Player> notRetiredPlayers = this.players
                .Where(p => p.Retired == false)
                .ToHashSet();
            foreach (var player in this.players)
            {
                if (player.Retired == false)
                {
                    notRetiredPlayers.Add(player);
                }
            }
            sb
                .AppendLine($"Active players competing for Team {this.Name} from Group {this.Group}:")
                .Append(string.Join(Environment.NewLine, notRetiredPlayers));

            return sb.ToString();
        }
    }
}
