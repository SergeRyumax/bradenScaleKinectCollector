using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Microsoft.Samples.Kinect.ControlsBasics
{
    class DataHelper : DependencyObject
    {

        public DataHelper()
        {
            List<String> enfermeiros = new List<String>();
            enfermeiros.Add("Nome 1");

            this.Enfermeiros = enfermeiros;
        }

        public static readonly DependencyProperty EnfermeirosProperty = DependencyProperty.Register(
            "Enfermeiros", typeof(List<String>), typeof(DataHelper), new PropertyMetadata(new List<String>()));

        public List<String> Enfermeiros
        {
            get
            {
                return (List<String>)GetValue(EnfermeirosProperty);
            }

            set
            {
                this.SetValue(EnfermeirosProperty, value);
            }
        }

    }
}
