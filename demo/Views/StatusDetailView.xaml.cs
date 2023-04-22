using demo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatusDetailView : ContentPage
    {
        private List<Status> statuses;


        public StatusDetailView(Status status )
        {
          
            InitializeComponent();
            this.BindingContext = this;

            statuses = new List<Status>
        {
            new Status {StatusID = 1, Images = new List<string> { "Flora.jpg", "hmo.jpg", "hmo.jpg" } },
            new Status {StatusID = 2, Images = new List<string> { "Flora.jpg", "Flora.jpg", "Flora.jpg" } },
            new Status {StatusID = 3, Images = new List<string> { "hmo.jpg", "hmo.jpg", "hmo.jpg" } }
        };
            crs.ItemsSource = statuses;
          
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new StatusView());
        }
    }
}