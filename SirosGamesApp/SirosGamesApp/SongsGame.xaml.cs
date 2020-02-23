using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SirosGamesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SongsGame : ContentPage
    {
        public SongsGame()
        {
            InitializeComponent();
        }
        public void AddCarlos_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblCarlos.Text = String.Format("{0}", e.NewValue);
        }

        public void AddJuanCarlos_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblJuanCarlos.Text = String.Format("{0}", e.NewValue);
        }

        public void AddNacho_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblNacho.Text = String.Format("{0}", e.NewValue);
        }

        public void AddJose_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblJose.Text = String.Format("{0}", e.NewValue);
        }


    }


}