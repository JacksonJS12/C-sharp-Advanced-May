using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        public List<Renovator> Renovators { get; set; }
        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }

        public Catalog(string name, int neededRenovators, string project)
        {
            this.Name = name;
            this.NeededRenovators = neededRenovators;
            this.Project = project;
            this.Renovators = new List<Renovator>();
        }
        public int GetCount => Renovators.Count();

        public string AddRenovator(Renovator renovator)
        {
            if (this.Renovators.Count >= this.NeededRenovators)
            {
                return "Renovators are no more needed.";
            }
            if (string.IsNullOrEmpty(renovator.Name))
            {
                return $"Invalid renovator's information.";
            }
            if (string.IsNullOrEmpty(renovator.Type))
            {
                return $"Invalid renovator's information.";
            }
            if (renovator.Rate > 350)
            {
                return $"Invalid renovator's rate.";
            }
            this.Renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {
            foreach (var renovator in this.Renovators)
            {
                if (renovator.Name == name)
                {
                    this.Renovators.Remove(renovator);
                    return true;
                }
            }

            return false;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            int counter = 0;
            for (int i = 0; i < this.Renovators.Count; i++)
            {
                Renovator renovator = this.Renovators[i];
                if (renovator.Type == type)
                {
                    this.Renovators.Remove(renovator);
                    counter++;
                }
            }
            return counter;
        }
        public Renovator HireRenovator(string name)
        {
            foreach (var renovator in this.Renovators)
            {
                if (renovator.Name == name)
                {
                    renovator.Hired = true;
                    return renovator;
                }
            }
            return null;
        }
        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> renovators = this.Renovators.Where(renovator => renovator.Days == days).ToList();
            return renovators;
        }
        public string Report()
        {
            return
                $"Renovators available for Project {this.Project}:" + Environment.NewLine +
                $"{string.Join(Environment.NewLine, this.Renovators)}";
        }
    }

}
