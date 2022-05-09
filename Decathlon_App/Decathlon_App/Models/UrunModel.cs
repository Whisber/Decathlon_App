using Decathlon_App.Models;
using Decathlon_App.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Decathlon_App.ViewModels
{
    public class ÜrünModel : BindableObject
    {
       /* private HomePage homePage;

        public ÜrünModel(HomePage homePage)
        {
            this.homePage = homePage;
            AddItems();
        }

        private void AddItems()
        {
            UrunItemAnasayfa urunItemAnasayfa = new UrunItemAnasayfa()
            {
                ImageSource = "sporayakkabi.PNG",
                urunIsmi = string.Format(""),
                urunDetayi = string.Format(""),
                urunFiyati = string.Format("")
            };
            UrunItemAnasayfa urunItemAnasayfa_1 = new UrunItemAnasayfa()
            {
                ImageSource = "bisiklet.PNG",
                urunIsmi = string.Format(""),
                urunDetayi = string.Format(""),
                urunFiyati = string.Format("")
            };
            UrunItemAnasayfa urunItemAnasayfa_2 = new UrunItemAnasayfa()
            {
                ImageSource = "cadir1.PNG",
                urunIsmi = string.Format(""),
                urunDetayi = string.Format(""),
                urunFiyati = string.Format("")
            };
            UrunItemAnasayfa urunItemAnasayfa_3 = new UrunItemAnasayfa()
            {
                ImageSource = "sporayakkabi.PNG",
                urunIsmi = string.Format(""),
                urunDetayi = string.Format(""),
                urunFiyati = string.Format("")
            };
            Items.Add(urunItemAnasayfa);
            Items.Add(urunItemAnasayfa_1);
            Items.Add(urunItemAnasayfa_2);
            Items.Add(urunItemAnasayfa_3);
        }

        private ObservableCollection<UrunItemAnasayfa> _items = new ObservableCollection<UrunItemAnasayfa>();
        public ObservableCollection<UrunItemAnasayfa> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }

        public Command ItemTappedCommand
        {
            get
            {
                return new Command((data) =>
                {
                    // Page.Navigation.PushAsync(new HomePage()); hata veriyor yapılacak
                });
            }
        }

        public string ImageSource { get; private set; } */
    }
}
