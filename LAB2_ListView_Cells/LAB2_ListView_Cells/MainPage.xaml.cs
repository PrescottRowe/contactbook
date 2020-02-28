using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LAB2_ListView_Cells
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public List<Meme> AllMemes { get; set; }
        public MainPage()
        {
            InitializeComponent();
        }
        public class Meme
        {
            public string MemeId { get; set; }
            public string MemeName { get; set; }
            public string Url { get; set; }
        }
        public class Memes
        {
            public static IEnumerable<Meme> Get()
            {
                return new List<Meme>
                {
                  new Meme() {MemeId="1", MemeName="Bart", Url="bart.png"},
                  new Meme() {MemeId="2", MemeName="Bob", Url="bob.png" },
                  new Meme() {MemeId="3", MemeName="Jerry", Url="jerry.png" },
                  new Meme() {MemeId="4", MemeName="Puff", Url="puff.jpg" },
                  new Meme() {MemeId="5", MemeName="Quinn", Url="quinn.jpg" },
                  new Meme() {MemeId="6", MemeName="Reggie", Url="reggie.png"}
                };
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            AllMemes = new List<Meme>(Memes.Get());
            ListViewList.ItemsSource = AllMemes;
        }
    }
}

