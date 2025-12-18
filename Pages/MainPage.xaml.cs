using Buyzen.Pages;
using System.Threading.Tasks;

namespace Buyzen.Pages
{
    public partial class MainPage : ContentPage
    { 
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnStartClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductDiscoveryPage());
        }
    }

}
