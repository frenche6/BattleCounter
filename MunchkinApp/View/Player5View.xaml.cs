using System.Windows;
using System.Windows.Controls;
using MunchkinApp.Phone.Core;

namespace MunchkinApp.View
{
    public partial class Player5View : UserControl
    {
        public Player5View()
        {
            InitializeComponent();
            this.DataContext = AppState.Player5Model;
        }

        private void uLevelup_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player5Model.PlayerLevel < 10)
            {
                AppState.Player5Model.PlayerLevel++;
            }
        }

        private void uLevelDown_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player5Model.PlayerLevel > 1)
            {
                AppState.Player5Model.PlayerLevel--;
            }
        }

        private void uArmorUp_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player5Model.EquipmentBonus < 50)
            {
                AppState.Player5Model.EquipmentBonus++;
            }
        }

        private void uArmorDown_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player5Model.EquipmentBonus > 0)
            {
                AppState.Player5Model.EquipmentBonus--;
            }
        }

        private void uTempDown_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player5Model.TempBonus > -50)
            {
                AppState.Player5Model.TempBonus--;
            }
        }

        private void uTempUp_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player5Model.TempBonus < 50)
            {
                AppState.Player5Model.TempBonus++;
            }
        }

        private void uTempUp_Hold(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (AppState.Player5Model.TempBonus <= 40)
            {
                AppState.Player5Model.TempBonus += 9;
            }
        }

        private void uTempDown_Hold(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (AppState.Player5Model.TempBonus >= -40)
            {
                AppState.Player5Model.TempBonus -= 9;
            }
        }

    }
}
