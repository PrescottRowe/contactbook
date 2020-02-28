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
        public List<contact> Allcontacts { get; set; }
        public MainPage()
        {
            InitializeComponent();
        }
        public class contact
        {
            public string contactId { get; set; }
            public string contactName { get; set; }
            public string Url { get; set; }
        }
        public class contacts
        {
            public static IEnumerable<contact> Get()
            {
                return new List<contact>
                {
                  new contact() {contactId="1", contactName="Bart", Url="bart.png"},
                  new contact() {contactId="2", contactName="Bob", Url="bob.png" },
                  new contact() {contactId="3", contactName="Jerry", Url="jerry.png" },
                  new contact() {contactId="4", contactName="Puff", Url="puff.jpg" },
                  new contact() {contactId="5", contactName="Quinn", Url="quinn.jpg" },
                  new contact() {contactId="6", contactName="Reggie", Url="reggie.png"}
                };
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Allcontacts = new List<contact>(contacts.Get());
            ListViewList.ItemsSource = Allcontacts;
        }
    }
}

