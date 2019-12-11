using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Lab15.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Lab15
{
    public partial class MainPage : ContentPage
    {
        private const string Url = "https://api-products-tecsup.herokuapp.com/api/productos";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<Models_Post> _post;
        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            string content = await client.GetStringAsync(Url);
            List<Models_Post> posts = JsonConvert.DeserializeObject<List<Models_Post>>(content);
            _post = new ObservableCollection<Models_Post>(posts);
            MyListView.ItemsSource = _post;
            base.OnAppearing();
        }

    }
}
