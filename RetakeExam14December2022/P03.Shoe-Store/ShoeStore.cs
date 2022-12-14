using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        public ShoeStore(string name, int storageCapacity)
        {
            this.Name = name;
            this.StorageCapacity = storageCapacity;
            this.Shoes = new List<Shoe>();
        }
        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public List<Shoe> Shoes;

        public int Count 
            => this.Shoes.Count;

        public string AddShoe(Shoe shoe)
        {
            if (Count + 1 > StorageCapacity)
            {
                return "No more space in the storage room.";
            }

            this.Shoes.Add(shoe);
            return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
        }

        public int RemoveShoes(string material)
        {
            var shoesToRemove = this.Shoes
                .Where(s => s.Material == material)
                .ToList();

            this.Shoes.RemoveAll(s => s.Material == material);
            return shoesToRemove.Count;
        }

        public List<Shoe> GetShoesByType(string type)
             => this.Shoes
                .Where(s => s.Type.ToLower() == type.ToLower())
                .ToList();

        public Shoe GetShoeBySize(double size)
            => this.Shoes
            .FirstOrDefault(s => s.Size == size);

        public string StockList(double size, string type)
        {
            var shoesToReturn = this.Shoes
                                    .Where(s => s.Size == size && s.Type == type)
                                    .ToList();
            StringBuilder sb = new StringBuilder();
            if (shoesToReturn.Count > 0)
            {
                sb
                    .AppendLine($"Stock list for size {size} - {type} shoes:");
                foreach (var shoe in shoesToReturn)
                {
                    sb
                        .AppendLine(shoe.ToString());
                }
            }
            else
            {
                sb
                    .AppendLine("No matches found!");
            }
            return sb
                .ToString()
                .TrimEnd();
        }
    }
}
