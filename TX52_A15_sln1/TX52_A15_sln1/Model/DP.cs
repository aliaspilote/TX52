using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
namespace TX52_A15_sln1.Model
{
    public class DP
    {
        private int id;
        private string label;

        private Values values;

        public event PropertyChangedEventHandler PropertyChanged;


        public DP()
        {
            id = 0;
            label = "";
            this.values = new Values();
        }

        public DP(int i, string lab)
        {
            id = i;
            label = lab;
            this.values = new Values();
        }

        public DP(Values v)
        {
            id = 0;
            label = "";
            this.values = new Values(v);
        }

        public DP(int i, string lab,Values v)
        {
            id = i;
            label = lab;
            this.values = new Values(v);
        }

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }



        public Values Values
        {
            get
            {
                return values;
            }

            set
            {
                values = value;
                OnPropertyChanged("Values");
            }
        }

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Label
        {
            get
            {
                return label;
            }

            set
            {
                label = value;
            }
        }
    }
}
