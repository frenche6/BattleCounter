using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MunchkinApp.Phone.Core;


namespace MunchkinApp
{
    public partial class VersusMonster : PhoneApplicationPage
    {
        private bool mGettingHelp = false;
        private Random mRandom = new Random();
        public VersusMonster()
        {
            InitializeComponent();
            SetDataContexts();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ((ApplicationBarMenuItem)((ApplicationBar)Application.Current.Resources["AppBar1"]).MenuItems[0]).Click += ResetMonster_Click;
            ((ApplicationBarIconButton)((ApplicationBar)Application.Current.Resources["AppBar2"]).Buttons[0]).Click += GetHelp_Click;
            ((ApplicationBarIconButton)((ApplicationBar)Application.Current.Resources["AppBar2"]).Buttons[2]).Click += Chance_Click;
            ((ApplicationBarMenuItem)((ApplicationBar)Application.Current.Resources["AppBar2"]).MenuItems[0]).Click += ResetTemporaryValues_Click;

            uHelperPivot.Visibility = Visibility.Collapsed;
            uTotalCalculatedPower.Text = AppState.Player1Model.TotalPower.ToString();

            DetermineWinner();
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            ((ApplicationBarIconButton)((ApplicationBar)Application.Current.Resources["AppBar2"]).Buttons[0]).Click -= GetHelp_Click;
            ((ApplicationBarIconButton)((ApplicationBar)Application.Current.Resources["AppBar2"]).Buttons[2]).Click -= Chance_Click;

            ApplicationBarIconButton lButton = ((ApplicationBarIconButton)((ApplicationBar)Application.Current.Resources["AppBar2"]).Buttons[0]);



            //ApplicationBarIconButton lButton = (ApplicationBarIconButton)ApplicationBar.Buttons[0];
            lButton.IconUri = new Uri("Assets/Icons/User-Add.png", UriKind.Relative);
        }

        private void SetDataContexts()
        {
            uPlayerNameText.DataContext = AppState.Player1Model;
            uPlayerTotalText.DataContext = AppState.Player1Model;
            uMonsterTotalText.DataContext = AppState.MonsterModel;

            uHelper2Name.DataContext = AppState.Player2Model;
            uHelper3Name.DataContext = AppState.Player3Model;
            uHelper4Name.DataContext = AppState.Player4Model;
            uHelper5Name.DataContext = AppState.Player5Model;
            uHelper6Name.DataContext = AppState.Player6Model;

            uPlayer2Level.DataContext = AppState.Player2Model;
            uPlayer3Level.DataContext = AppState.Player3Model;
            uPlayer4Level.DataContext = AppState.Player4Model;
            uPlayer5Level.DataContext = AppState.Player5Model;
            uPlayer6Level.DataContext = AppState.Player6Model;

            uPlayer2Total.DataContext = AppState.Player2Model;
            uPlayer3Total.DataContext = AppState.Player3Model;
            uPlayer4Total.DataContext = AppState.Player4Model;
            uPlayer5Total.DataContext = AppState.Player5Model;
            uPlayer6Total.DataContext = AppState.Player6Model;
        }

        private void GetHelp_Click(object sender, EventArgs e)
        {
            mGettingHelp = !mGettingHelp;

            ApplicationBarIconButton lButton = (ApplicationBarIconButton)ApplicationBar.Buttons[0];

            if (mGettingHelp)
            {
                int selectedPlayer;
                selectedPlayer = uHelperPivot.SelectedIndex + 2;
                uHelperPivot.Visibility = Visibility.Visible;
                //uHelperNameText.Visibility = Visibility.Visible;
                lButton.IconUri = new Uri("Assets/Icons/User-Delete.png", UriKind.Relative);

                int lCombinedTotal = 0;
                lCombinedTotal += AppState.Player1Model.TotalPower + HelperLevelValue();
                uTotalCalculatedPower.Text = lCombinedTotal.ToString();
            }
            else
            {
                //uHelperNameText.Visibility = Visibility.Collapsed;
                uHelperPivot.Visibility = Visibility.Collapsed;
                lButton.IconUri = new Uri("Assets/Icons/User-Add.png", UriKind.Relative);
                uTotalCalculatedPower.Text = AppState.Player1Model.TotalPower.ToString();
            }
            DetermineWinner();
        }

        private int HelperLevelValue()
        {
            int lReturn = 0;

            if (uHelperPivot.SelectedIndex == 0)
            {
                lReturn += int.Parse(uPlayer2Total.Text);
            }
            else if (uHelperPivot.SelectedIndex == 1)
            {
                lReturn += int.Parse(uPlayer3Total.Text);
            }
            else if (uHelperPivot.SelectedIndex == 2)
            {
                lReturn += int.Parse(uPlayer4Total.Text);
            }
            else if (uHelperPivot.SelectedIndex == 3)
            {
                lReturn += int.Parse(uPlayer5Total.Text);
            }
            else if (uHelperPivot.SelectedIndex == 4)
            {
                lReturn += int.Parse(uPlayer6Total.Text);
            }

            return lReturn;
        }

        private void RollDice_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/RollDicePage.xaml", UriKind.Relative));
        }
        private void Chance_Click(object sender, EventArgs e)
        {
            if (AppState.Player1Model.TempBonus < 100 || AppState.MonsterModel.TemporaryBonus < 100)
            {
                int lRandomValue = mRandom.Next(100) + 1;
                int lDetermineLowOrHighValue = mRandom.Next(2);

                if (lRandomValue > 0 && lRandomValue <= 30)
                {
                    if (lDetermineLowOrHighValue == 0)
                    {
                        AppState.Player1Model.TempBonus += 3;
                        uTotalCalculatedPower.Text = CalculateTotals().ToString();
                        MessageBox.Show("You gain a temporary bonus of 3!", "Congratulations!", MessageBoxButton.OK);
                    }
                    else
                    {
                        AppState.Player1Model.TempBonus += 5;
                        uTotalCalculatedPower.Text = CalculateTotals().ToString();
                        MessageBox.Show("You gain a temporary bonus of 5!", "Sweet!", MessageBoxButton.OK);
                    }
                }
                else if (lRandomValue > 20 && lRandomValue <= 60)
                {
                    if (lDetermineLowOrHighValue == 0)
                    {
                        AppState.MonsterModel.TemporaryBonus += 3;
                        MessageBox.Show("The monster gains a temporary bonus of 3!", "Bummer", MessageBoxButton.OK);
                    }
                    else
                    {
                        AppState.MonsterModel.TemporaryBonus += 5;
                        MessageBox.Show("The monster gains a temporary bonus of 5!", "Watch out!", MessageBoxButton.OK);
                    }
                }
                else if (lRandomValue > 60 && lRandomValue <= 70)
                {
                    MessageBox.Show("You get to draw two cards!", "Nice!", MessageBoxButton.OK);
                }
                else if (lRandomValue > 70 && lRandomValue <= 80)
                {
                    MessageBox.Show("You can play an equipment card from your hand, double its value and add it as a temporary bonus for your turn!", "Lucky!", MessageBoxButton.OK);
                }
                else if (lRandomValue > 80 && lRandomValue <= 90)
                {
                    if (AppState.Player1Model.PlayerLevel == 1 || AppState.Player1Model.PlayerLevel == 2 || AppState.Player1Model.PlayerLevel == 3 || AppState.Player1Model.PlayerLevel == 4)
                    {
                        AppState.Player1Model.PlayerLevel = 3;
                    }
                    else
                    {
                        AppState.Player1Model.PlayerLevel -= 2;
                    }

                    uTotalCalculatedPower.Text = CalculateTotals().ToString();
                    MessageBox.Show("You lose 4 levels, then gain 3, lose 2 more, but then gain 1 more.", "Feeling lucky, punk?", MessageBoxButton.OK);
                }
                else if (lRandomValue > 90 && lRandomValue <= 95)
                {
                    MessageBox.Show("You have to fight monster without your three best equipments!", "Sucks to be you!", MessageBoxButton.OK);
                }
                else if (lRandomValue > 95 && lRandomValue <= 100)
                {
                    AppState.MonsterModel.ResetValues();
                    MessageBox.Show("The monster dies and you gain an additional two treasures!", "WooHoo!", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show("Temporary bonuses are getting a little out of hand..", "Slow Down..", MessageBoxButton.OK);
            }

            DetermineWinner();
        }

        private void ResetMonster_Click(object sender, EventArgs e)
        {
            AppState.MonsterModel.ResetValues();
        }

        private void uVersusMonsterPivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (((Pivot)sender).SelectedIndex)
            {
                case 0:
                    ApplicationBar = ((ApplicationBar)Application.Current.Resources["AppBar1"]);
                    break;

                case 1:
                    ApplicationBar = ((ApplicationBar)Application.Current.Resources["AppBar2"]);
                    break;
            }
            DetermineWinner();
        }

        private void uHelperPivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int lCombinedTotal = 0;
            lCombinedTotal += int.Parse(uPlayerTotalText.Text);

            if (mGettingHelp)
            {
                if (uHelperPivot.SelectedIndex == 0)
                {
                    lCombinedTotal += int.Parse(uPlayer2Total.Text);
                }
                else if (uHelperPivot.SelectedIndex == 1)
                {
                    lCombinedTotal += int.Parse(uPlayer3Total.Text);
                }
                else if (uHelperPivot.SelectedIndex == 2)
                {
                    lCombinedTotal += int.Parse(uPlayer4Total.Text);
                }
                else if (uHelperPivot.SelectedIndex == 3)
                {
                    lCombinedTotal += int.Parse(uPlayer5Total.Text);
                }
                else if (uHelperPivot.SelectedIndex == 4)
                {
                    lCombinedTotal += int.Parse(uPlayer6Total.Text);
                }
            }

            uTotalCalculatedPower.Text = lCombinedTotal.ToString();
            DetermineWinner();
        }

        private void DetermineWinner()
        {
            if (int.Parse(uTotalCalculatedPower.Text) > AppState.MonsterModel.TotalPower)
            {
                uTotalCalculatedPower.FontSize = 50;
                uMonsterTotalText.FontSize = 34;
            }
            else if (int.Parse(uTotalCalculatedPower.Text) < AppState.MonsterModel.TotalPower)
            {
                uTotalCalculatedPower.FontSize = 34;
                uMonsterTotalText.FontSize = 50;
            }
            else
            {
                uTotalCalculatedPower.FontSize = 34;
                uMonsterTotalText.FontSize = 34;
            }
        }

        private void ResetTemporaryValues_Click(object sender, EventArgs e)
        {          
            AppState.Player1Model.TempBonus = 0;
            AppState.MonsterModel.TemporaryBonus = 0;

            uTotalCalculatedPower.Text = CalculateTotals().ToString();
            DetermineWinner();
        }

        private int CalculateTotals() 
        {
            int lCombinedTotal = 0; 

            if (!mGettingHelp)
            {
                lCombinedTotal += AppState.Player1Model.TotalPower;
            }
            else
            {
                lCombinedTotal += AppState.Player1Model.TotalPower + HelperLevelValue();
            }

            return lCombinedTotal;
        }
    }
}
