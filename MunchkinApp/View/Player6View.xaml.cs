using System.Windows;
using System.Windows.Controls;
using MunchkinApp.Phone.Core;


namespace MunchkinApp.View
{
    public partial class Player6View : UserControl
    {
        public Player6View()
        {
            InitializeComponent();
            this.DataContext = AppState.Player6Model;
        }

        private void uLevelup_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player6Model.PlayerLevel < 10)
            {
                AppState.Player6Model.PlayerLevel++;
            }
        }

        private void uLevelDown_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player6Model.PlayerLevel > 1)
            {
                AppState.Player6Model.PlayerLevel--;
            }
        }

        private void uArmorUp_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player6Model.EquipmentBonus < 50)
            {
                AppState.Player6Model.EquipmentBonus++;
            }
        }

        private void uArmorDown_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player6Model.EquipmentBonus > 0)
            {
                AppState.Player6Model.EquipmentBonus--;
            }
        }

        private void uTempDown_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player6Model.TempBonus > -50)
            {
                AppState.Player6Model.TempBonus--;
            }
        }

        private void uTempUp_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player6Model.TempBonus < 50)
            {
                AppState.Player6Model.TempBonus++;
            }
        }

        private void uTempUp_Hold(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (AppState.Player6Model.TempBonus <= 40)
            {
                AppState.Player6Model.TempBonus += 9;
            }
        }

        private void uTempDown_Hold(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (AppState.Player6Model.TempBonus >= -40)
            {
                AppState.Player6Model.TempBonus -= 9;
            }
        }

    }
}
