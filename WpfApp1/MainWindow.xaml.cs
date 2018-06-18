using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using week12classLib;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {
            InitializeComponent();

           
            


        }

        private async void Btn1_Click(object sender, RoutedEventArgs e)
        {
            lblNum.Content = (await Class1.FindPrime(Int32.Parse(Number.Text))).ToString();
        }

        private async void BtnJson_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage Response = new HttpResponseMessage();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/posts/1/comments/");
            Response = await client.GetAsync("?id=1");
            var content = await Response.Content.ReadAsStringAsync();
            var x = JsonConvert.DeserializeObject<List<Post>>(content);
            lblJson.Content = x[0].Username + x[0].Id + x[0].Title + x[0].Body;
        }
    }

    class Post
    {
        public int Username { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

}
