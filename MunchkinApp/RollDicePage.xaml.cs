using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Navigation;

namespace MunchkinApp
{
    public partial class RollDicePage : PhoneApplicationPage
    {
        Random mRandomNumber = new Random();
        public RollDicePage()
        {
            InitializeComponent();            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            uDiceValueTextBlock.Text = "";
        }

        private void uRollButton_Click(object sender, RoutedEventArgs e)
        {
            int lRandom =  mRandomNumber.Next(1, 7);
            uDiceValueTextBlock.Text = lRandom.ToString();
        }
    }
}