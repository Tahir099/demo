using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using demo.Models;
using demo.ViewModels;
using FFImageLoading.Forms;
using System;

namespace demo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatusView : ContentPage
    {
        private StatusViewModel viewModel;
        public StatusView()
        {
            InitializeComponent();
            BindingContext = viewModel = new StatusViewModel();
        }
        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var item = (Status)e.Item;
                await Navigation.PushModalAsync(new StatusDetailView(item));
            }
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var imageSender = (CachedImage)sender;
            Status s = new Status
            {
                Image = imageSender.Source.ToString().Remove(0, 6)
            };
            await Navigation.PushModalAsync(new StatusDetailView(s));

        }
    }
}