using Ozturk_Batuhan_PE2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Ozturk_Batuhan_PE2.Models;

namespace Ozturk_Batuhan_PE2.ViewModels
{
    public class MainViewModel: INotifyPropertyChanged
    {
        public ObservableCollection<Product> Producten { get; } = new ObservableCollection<Product>
       {
           new Product("Salpeterzuur", 1000),
           new Product("Aceton", 1500),
           new Product("Zwavelzuur", 500),
           new Product("Ammoniak", 700)
       };

        
        private Product? _geselecteerdProduct;

        public Product? GeselecteerdProduct
        {
            get { return _geselecteerdProduct; }
            set
            {
                _geselecteerdProduct = value;
                _opslagvat.SetProduct(value);
                OnPropertyChanged(nameof(GeselecteerdProduct));
                OnPropertyChanged(nameof(HuidigeInhoud));
                OnPropertyChanged(nameof(MaxCapaciteit));
                OnPropertyChanged(nameof(ProductNaam));

            }
        }

        private Opslagvat _opslagvat = new Opslagvat();

        public string ProductNaam => _opslagvat.HuidigProduct?.Naam ?? "Geen product";

        public int HuidigeInhoud => _opslagvat.HuidigeInhoud;
        public int MaxCapaciteit => _opslagvat.MaxCapaciteit;

        public void Vul()
        {
           if (GeselecteerdProduct == null)
            {
                return;
            }

            _opslagvat.Vul();
            OnPropertyChanged(nameof(HuidigeInhoud));
        }

        public void Openen()
        {
            if (GeselecteerdProduct == null)
            {
                return;
            }
            _opslagvat.Openen();
            OnPropertyChanged(nameof(HuidigeInhoud));

        }

        public void Schoonmaken()
        {
            _opslagvat.Schoonmaken();
            OnPropertyChanged(nameof(GeselecteerdProduct));
            OnPropertyChanged(nameof(HuidigeInhoud));
            OnPropertyChanged(nameof(MaxCapaciteit));
            OnPropertyChanged(nameof(ProductNaam));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
