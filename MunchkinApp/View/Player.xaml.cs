using System.Windows;
using System.Windows.Controls;
using MunchkinApp.Phone.Core;
using Microsoft.Phone.Tasks;
using Microsoft.Phone.Marketplace;

namespace MunchkinApp.View
{
    public partial class User : UserControl
    {
        MarketplaceDetailTask mMarketPlaceDetailTask = new MarketplaceDetailTask();
        MessageBoxResult mResult;
        public User()
        {
            InitializeComponent();
            this.DataContext = AppState.Player1Model;
            //this.DataContext = AppState.PlayerViewModel.mPlayerModelList[0];
        }

        private void uLevelup_Click(object sender, RoutedEventArgs e)
        {
            
            if ((Application.Current as App).IsTrial)
            {
                if (AppState.Player1Model.PlayerLevel < 4)
                {
                    AppState.Player1Model.PlayerLevel++;
                }
                else
                {
                    mResult = MessageBox.Show("Purchase the application?", "Currently in trial mode", MessageBoxButton.OKCancel);
                    if (mResult == MessageBoxResult.OK)
                    {
                        mMarketPlaceDetailTask.Show();
                    }
                }
            }
            else
            {
                if (AppState.Player1Model.PlayerLevel < 10)
                {
                    AppState.Player1Model.PlayerLevel++;
                }
            }
        }

        private void uLevelDown_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player1Model.PlayerLevel > 1)
            {
                AppState.Player1Model.PlayerLevel--;
            }
        }

        private void uArmorUp_Click(object sender, RoutedEventArgs e)
        {
            if ((Application.Current as App).IsTrial)
            {
                if (AppState.Player1Model.EquipmentBonus < 5)
                {
                    AppState.Player1Model.EquipmentBonus++;
                }
                else
                {
                    mResult = MessageBox.Show("Purchase the application?", "Currently in trial mode", MessageBoxButton.OKCancel);
                    if (mResult == MessageBoxResult.OK)
                    {
                        mMarketPlaceDetailTask.Show();
                    }
                }
            }
            else
            {
                if (AppState.Player1Model.EquipmentBonus < 50)
                {
                    AppState.Player1Model.EquipmentBonus++;
                }
            }

            
        }

        private void uArmorDown_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player1Model.EquipmentBonus > 0)
            {
                AppState.Player1Model.EquipmentBonus--;
            }
        }

        private void uTempDown_Click(object sender, RoutedEventArgs e)
        {
            if ((Application.Current as App).IsTrial)
            {
                if (AppState.Player1Model.TempBonus > -5)
                {
                    AppState.Player1Model.TempBonus--;
                }
                else
                {
                    mResult = MessageBox.Show("Purchase the application?", "Currently in trial mode", MessageBoxButton.OKCancel);
                    if (mResult == MessageBoxResult.OK)
                    {
                        mMarketPlaceDetailTask.Show();
                    }
                }
            }
            else
            {
                if (AppState.Player1Model.TempBonus > -50)
                {
                    AppState.Player1Model.TempBonus--;
                }
            }
        }

        private void uTempUp_Click(object sender, RoutedEventArgs e)
        {
            if ((Application.Current as App).IsTrial)
            {
                if (AppState.Player1Model.TempBonus < 5)
                {
                    AppState.Player1Model.TempBonus++;
                }
                else
                {
                    mResult = MessageBox.Show("Purchase the application?", "Currently in trial mode", MessageBoxButton.OKCancel);
                    if (mResult == MessageBoxResult.OK)
                    {
                        mMarketPlaceDetailTask.Show();
                    }
                }
            }
            else
            {
                if (AppState.Player1Model.TempBonus < 50)
                {
                    AppState.Player1Model.TempBonus++;
                }
            }            
        }
    }
}
