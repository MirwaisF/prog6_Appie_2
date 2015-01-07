using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppieDomain.Afdelingen
{
    public class Afdelingen : INotifyPropertyChanged
    {
        public Afdelingen()
        {
            //Producten = new HashSet<Producten>();
        }

        private string _Naam;
        private string _Omschrijving;

        [Key]
        public int AfdelingId
        {
            get;
            set;
        }

        public string Naam
        {
            get
            {
                return _Naam;
            }
            set
            {
                _Naam = value;
                OnPropertyChanged("Naam");
            }
        }

        public string Omschrijving
        {
            get
            {
                return _Omschrijving;
            }
            set
            {
                _Omschrijving = value;
                OnPropertyChanged("Omschrijving");
            }
        }

        // public virtual ICollection<Producten> Producten { get; set; }



        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
