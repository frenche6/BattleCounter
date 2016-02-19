using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using System;
using System.Windows.Navigation;
using MunchkinApp.Phone.Core;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Marketplace;
using System.Windows;

namespace MunchkinApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        //private MunchkinApp.Model.PlayerModel mModel;
        // Constructor
        StorageManager mStorageManager = new StorageManager();
        MarketplaceDetailTask mMarketPlaceDetailTask = new MarketplaceDetailTask();
        MessageBoxResult mResult;
        public MainPage()
        {
            InitializeComponent();
            this.DataContext = AppState.Player1Model;
            mStorageManager.GetSavedNames("SavedNames.txt");

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            //PhoneApplicationService.Current.ApplicationIdleDetectionMode = IdleDetectionMode.Disabled;
        }

        private void RateApp_Click(object sender, EventArgs e)
        {
            MarketplaceReviewTask lMarketPlaceReviewTask = new MarketplaceReviewTask();
            lMarketPlaceReviewTask.Show();
        }

        private void Players_Click(object sender, EventArgs e)
        {
            if ((Application.Current as App).IsTrial)
            {
                mResult = MessageBox.Show("Purchase the application?", "Currently in trial mode", MessageBoxButton.OKCancel);
                if (mResult == MessageBoxResult.OK)
                {
                    mMarketPlaceDetailTask.Show();
                }
            }
            else
            {
                NavigationService.Navigate(new Uri("/MunchkinPanoramaPage.xaml", UriKind.Relative));

            }
        }

        private void Fight_Click(object sender, EventArgs e)
        {
            if ((Application.Current as App).IsTrial)
            {
                mResult = MessageBox.Show("Purchase the application?", "Currently in trial mode", MessageBoxButton.OKCancel);
                if (mResult == MessageBoxResult.OK)
                {
                    mMarketPlaceDetailTask.Show();
                }
            }
            else
            {
                NavigationService.Navigate(new Uri("/VersusMonster.xaml", UriKind.Relative));
            }
        }

        private void RollDice_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/RollDicePage.xaml", UriKind.Relative));
        }

        private void uEditNameButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if ((Application.Current as App).IsTrial)
            {
                mResult = MessageBox.Show("Purchase the application?", "Currently in trial mode", MessageBoxButton.OKCancel);
                if (mResult == MessageBoxResult.OK)
                {
                    mMarketPlaceDetailTask.Show();
                }
            }
            else
            {
                NavigationService.Navigate(new Uri("/EditNamesPage.xaml", UriKind.Relative));
            }
        }

        private void ResetPlayer1_Click(object sender, EventArgs e)
        {
            if ((Application.Current as App).IsTrial)
            {
                mResult = MessageBox.Show("Purchase the application?", "Currently in trial mode", MessageBoxButton.OKCancel);
                if (mResult == MessageBoxResult.OK)
                {
                    mMarketPlaceDetailTask.Show();
                }
            }
            else
            {
                AppState.Player1Model.PlayerLevel = 1;
                AppState.Player1Model.EquipmentBonus = 0;
                AppState.Player1Model.TempBonus = 0;
                AppState.Player1Model.TotalPower = 1;
                AppState.Player1Model.IsWarrior = false;
            }
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}