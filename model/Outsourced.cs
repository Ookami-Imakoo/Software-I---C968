using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewEvans___BFM1___Software_I___C968.model
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(int PartID, String Name, decimal Price, int InStock, int Min, int Max, String CompanyName)
        {
            this.PartID = PartID;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
            this.CompanyName = CompanyName;
        }
    }
}
