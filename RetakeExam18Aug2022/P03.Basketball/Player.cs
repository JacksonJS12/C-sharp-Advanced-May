using System;
using System.Text;

namespace Basketball
{
    public class Player
    {
        public Player(string name, string position, double rating, int games)
        {
            this.Name = name;
            this.Position = position;
            this.Rating = rating;
            this.Games = games;
        }

        public string Name { get; set; }
        public string Position { get; set; }
        public double Rating { get; set; }
        public int Games { get; set; }
        public bool Retired { get; set; } = false;

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb
                .AppendLine($"-Player: {this.Name}")
                .AppendLine($"--Position: {this.Position}")
                .AppendLine($"--Rating: {this.Rating}")
                .Append($"--Games played: {this.Games}");

            return sb.ToString();
        }
    }
}
