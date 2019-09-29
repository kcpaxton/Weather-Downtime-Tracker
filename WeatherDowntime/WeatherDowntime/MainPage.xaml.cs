using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherDowntime.MenuItems;
using WeatherDowntime.Views;
using Xamarin.Forms;
namespace WeatherDowntime
{
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> menuList
        {
            get;
            set;
        }
        public MainPage()
        {
            InitializeComponent();
            menuList = new List<MasterPageItem>();
            // Adding menu items to menuList and you can define title ,page and icon  
            menuList.Add(new MasterPageItem()
            {
                Title = "Home",
                Icon = "homeicon.png",
                TargetType = typeof(HomePage)
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "Help",
                Icon = "contacticon.png",
                TargetType = typeof(HelpPage)
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "Settings",
                Icon = "abouticon.png",
                TargetType = typeof(SettingsPage)
            });

            // Setting our list to be ItemSource for ListView in MainPage.xaml  
            navigationDrawerList.ItemsSource = menuList;
            // Initial navigation, this can be used for our home page  
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
        }
        // Event for Menu Item selection, here we are going to handle navigation based  
        // on user selection in menu ListView  
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
