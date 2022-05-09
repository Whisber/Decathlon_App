using Decathlon_App.Models;
using Decathlon_App.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Decathlon_App.ViewModels
{
    internal class Urunler : BindableObject
    {
        private Page Page;

        public Urunler(Page mainPage)
        {
            this.Page = mainPage;
            AddItems();
        }

        private void AddItems()
        {
            for (int i = 0; i < 20; i++)
            {
                UrunItem urunitem = new UrunItem()
                {
                    ImageSource = "https://www.decathlon.com.tr/p/2-kisilik-cadir-2-seconds-xl-fresh-black/_/R-p-172536?mc=8492483&c=BEYAZ",
                    UrunIsim = string.Format("UrunIsim {0}", i),
                   UrunDetay = string.Format("UrunDetay {0}", i),
                   UrunFiyat = string.Format("UrunFiyat {0}", i)
                };
                Items.Add(urunitem);
            }
            
        }
           
        private ObservableCollection<UrunItem> _items = new ObservableCollection<UrunItem>();
        public ObservableCollection<UrunItem> Items
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
                    Page.DisplayAlert("FlowListView", data + "", "Ok");
                });
            }
        }

        public string ImageSource { get; private set; }
        public string UrunIsim { get; private set; }
        public string UrunFiyat { get; private set; }

       
    }
}
