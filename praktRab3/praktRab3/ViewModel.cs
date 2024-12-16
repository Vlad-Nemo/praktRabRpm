using praktRab3;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace praktRab3
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Phone selectedPhone;

        public ObservableCollection<Phone> Phones { get; set; }

        public Phone SelectedPhone
        {
            get { return selectedPhone; }
            set
            {
                selectedPhone = value;
                OnPropertyChanged("SelectedPhone");
            }
        }

        public ViewModel() {
            Phones = new ObservableCollection<Phone>
            {
            new Phone { Title = "Focus", Company = "Ford", Price = 250000 },
            new Phone { Title = "AMG", Company = "Mercedes-Benz", Price = 56000000 },
            new Phone { Title = "M5 F90", Company = "BMW", Price = 10000000 },
            new Phone { Title = "Granta", Company = "Lada", Price = 500000 }
            };
        } 

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "") 
        { 
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
