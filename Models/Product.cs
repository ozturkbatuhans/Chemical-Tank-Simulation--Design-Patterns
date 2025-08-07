using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozturk_Batuhan_PE2.Models
{
    public class Product
    {
        public string Naam { get; set; }
        public int MaxCapaciteit { get; set; }

        public Product(string naam, int maxCapaciteit)
        {
            Naam = naam;
            MaxCapaciteit = maxCapaciteit;
        }
    }

}
