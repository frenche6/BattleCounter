using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using System;
using MunchkinApp.Phone.Core;


namespace MunchkinApp
{
    public partial class MunchkinPanoramaPage : PhoneApplicationPage
    {
        
        public MunchkinPanoramaPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            uPlayer2Pivot.Header = AppState.Player2Model.PlayerName;
            uPlayer3Pivot.Header = AppState.Player3Model.PlayerName;
            uPlayer4Pivot.Header = AppState.Player4Model.PlayerName;
            uPlayer5Pivot.Header = AppState.Player5Model.PlayerName;
            uPlayer6Pivot.Header = AppState.Player6Model.PlayerName;
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void ResetAll()
        {
            AppState.MonsterModel.ResetValues();
            AppState.Player1Model.ResetValues();
            AppState.Player2Model.ResetValues();
            AppState.Player3Model.ResetValues();
            AppState.Player4Model.ResetValues();
            AppState.Player5Model.ResetValues();
            AppState.Player6Model.ResetValues();
        }

        private void RateApp_Click(object sender, EventArgs e)
        {
            MarketplaceReviewTask lMarketPlaceReviewTask = new MarketplaceReviewTask();
            lMarketPlaceReviewTask.Show();
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/EditNamesPage.xaml", UriKind.Relative));
        }

        private void Fight_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/VersusMonster.xaml", UriKind.Relative));
        }

        private void RollDice_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/RollDicePage.xaml", UriKind.Relative));
        }

        private void NavigateToSpecificPivot(object sender, EventArgs e)
        {

        }
    }
}