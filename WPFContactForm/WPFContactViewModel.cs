using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPFContactForm
{
    public class WPFContactViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string _Name;
        public ICommand Show { get; set; }
        public ICommand Open { get; set; }

        public WPFContactViewModel()
        {
            this.Show = new RelayCommand(mymethod);
            this.Open= new RelayCommand(myopenmethod);
        }
        public void mymethod()
        {
            MessageBox.Show("India is great");
        }
        public void myopenmethod()
        {
           OpenFileDialog o=new OpenFileDialog();
            o.ShowDialog();
        }

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _FirstName;

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value;
                //OnPropertyChanged("FirstName");
                OnPropertyChanged("FullName");
            }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value;
                //OnPropertyChanged("LastName");
                OnPropertyChanged("FullName");
            }
        }

        private string _FullName;

        public string FullName
        {
            get { return _FirstName+_lastName; }
            set { _FullName = value; OnPropertyChanged("FullName"); }
        }



        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

    }
}

