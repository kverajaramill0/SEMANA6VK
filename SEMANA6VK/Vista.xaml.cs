using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SEMANA6VK
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vista : ContentPage
    {
        private const string Url = "http://130.1.23.131/moviles/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<SEMANA6VK.Datos> _post;


        public Vista()
        {
            InitializeComponent();
        }

        private async void btnGet_Clicked(object sender, EventArgs e)
        {
            var content = await client.GetStringAsync(Url);
            List<SEMANA6VK.Datos> posts = JsonConvert.DeserializeObject<List<SEMANA6VK.Datos>>(content);
            _post = new ObservableCollection<SEMANA6VK.Datos>(posts);

            MyListView.ItemsSource= _post;

        }

        private async void btnInsertar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}