using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Renovators
{
    public class Catalog
    {
        public List<Renovator> renovators;
        public Catalog(string name, int neededRenovators, string project)
        {
            this.Name = name;
            this.NeededRenovators = neededRenovators;
            this.Project = project;
            renovators = new List<Renovator>();
        }

        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }

        public int Count
            => renovators.Count;

        public string AddRenovator(Renovator renovator)
        {
            if (renovator.Name is null ||
                renovator.Name == string.Empty ||
                renovator.Type is null ||
                renovator.Type == string.Empty)
            {
                return "Invalid renovator's information.";
            }
            else if (this.Count + 1 > this.NeededRenovators)
            {
                return "Renovators are no more needed.";
            }
            else if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }

            this.renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {
            Renovator renovator = this.renovators
                .FirstOrDefault(r => r.Name == name);
            return this.renovators.Remove(renovator);
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            var renovatorsToRemove = this.renovators
                .Where(r => r.Type == type).ToList();

            this.renovators.RemoveAll(r => r.Type == type);

            var res = renovatorsToRemove.Count == 0 ? 0 : renovatorsToRemove.Count;
            return res;
        }

        public Renovator HireRenovator(string name)
        {
            Renovator renovator = this.renovators
                .FirstOrDefault(r => r.Name == name);

            if (!(renovator is null))
            {
                renovator.Hired = true;
            }
            return renovator;
        }

        public List<Renovator> PayRenovators (int days)
                => this.renovators.Where(r => r.Days >= days)
                    .ToList();
        
        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"Renovators available for Project {this.Project}:")
                .AppendLine(string.Join(Environment.NewLine, this.renovators.Where(r => r.Hired == false)));

            return sb
                     .ToString()
                     .TrimEnd();
        }
    }
}
