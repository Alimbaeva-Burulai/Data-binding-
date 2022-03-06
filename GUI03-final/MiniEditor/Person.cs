using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MiniEditor
{
    public class Person : INotifyPropertyChanged
    {
        private string name;

        private int age;

        private string haveGlasses;

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }


        public string HaveGlasses
        {
            get { return haveGlasses; }
            set 
            { 
                haveGlasses = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        public int Age
        {
            get { return age; }
            set { age = value; OnPropertyChanged(); }
        }

    }
}
