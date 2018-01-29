using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace forms_master_detail_page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public ListView ListView { get { return this.listView; } }

        public MenuPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "First",
                TargetType = typeof(FirstPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Second",
                TargetType = typeof(SecondPage)
            });

            listView.ItemsSource = masterPageItems;
        }
    }
}
