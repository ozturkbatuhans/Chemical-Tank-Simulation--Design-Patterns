using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozturk_Batuhan_PE2.Models
{
    public class Opslagvat
    {
        public Product? HuidigProduct { get; private set; }
        public int HuidigeInhoud { get; private set; }
        public int MaxCapaciteit => HuidigProduct?.MaxCapaciteit ?? 0;

        private const int InloopDebiet = 200;
        private const int UitloopDebiet = 100;

        public Opslagvat() { }

        public void Vul()
        {
            if (HuidigProduct != null && HuidigeInhoud + InloopDebiet <= MaxCapaciteit)
            {
                HuidigeInhoud += InloopDebiet;
            }
        }

        public void Openen()
        {
            if (HuidigProduct != null && HuidigeInhoud - UitloopDebiet >= 0)
            {
                HuidigeInhoud -= UitloopDebiet;
            }
        }

        public void Schoonmaken()
        {
            HuidigeInhoud = 0;
            HuidigProduct = null;
        }

        public void SetProduct(Product product)
        {
            if (HuidigeInhoud == 0)
            {
                HuidigProduct = product;
            }
        }
    }
}
