using System;

using Xamarin.Forms.XamlPack.Sample.Models;

namespace Xamarin.Forms.XamlPack.Sample.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
