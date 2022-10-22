using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        private List<CPU> multiprocessor;

        public Computer(string model, int capacity)
        {
            this.Model = model;
            this.Capacity = capacity;
            this.multiprocessor = new List<CPU>();
        }

        public string Model { get; set; }
        public int Capacity  { get; set; }

        public int Count
             => this.multiprocessor.Count;

        public void Add(CPU cpu)
        {
            if(this.Capacity + 1 >= this.Capacity)
            {
                this.Capacity--;
                multiprocessor.Add(cpu);
            }
        }

        public bool Remove(string brand)
            {
                bool isThere = multiprocessor.Any(cpu => cpu.Brand == brand);

                if(isThere == true)
                {
                   CPU cpu = multiprocessor.FirstOrDefault(cpu => cpu.Brand == brand);
                    multiprocessor.Remove(cpu);
                    this.Capacity++;
                }

                return isThere;
            }

        public CPU MostPowerful()
        {
            double biggestCpuFrequency = multiprocessor.Max(cpu => cpu.Frequency);
            return multiprocessor.FirstOrDefault(cpu => cpu.Frequency == biggestCpuFrequency);
        }

        public CPU GetCPU(string brand)
            => multiprocessor.FirstOrDefault(cpu => cpu.Brand == brand);

        public string Report()
            => $"CPUs in the Computer {this.Model}:" +
                Environment.NewLine +
                string.Join(Environment.NewLine, multiprocessor);
    }
}
