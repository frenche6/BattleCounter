using System.Windows;
using System.Windows.Controls;
using MunchkinApp.Phone.Core;


namespace MunchkinApp.View
{
    public partial class Player4View : UserControl
    {
        public Player4View()
        {
            InitializeComponent();
            this.DataContext = AppState.Player4Model;
        }

        private void uLevelup_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player4Model.PlayerLevel < 10)
            {
                AppState.Player4Model.PlayerLevel++;
            }
        }

        private void uLevelDown_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player4Model.PlayerLevel > 1)
            {
                AppState.Player4Model.PlayerLevel--;
            }
        }

        private void uArmorUp_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player4Model.EquipmentBonus < 50)
            {
                AppState.Player4Model.EquipmentBonus++;
            }
        }

        private void uArmorDown_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player4Model.EquipmentBonus > 0)
            {
                AppState.Player4Model.EquipmentBonus--;
            }
        }

        private void uTempDown_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player4Model.TempBonus > -50)
            {
                AppState.Player4Model.TempBonus--;
            }
        }

        private void uTempUp_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player4Model.TempBonus < 50)
            {
                AppState.Player4Model.TempBonus++;
            }
        }

        private void uTempUp_Hold(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (AppState.Player4Model.TempBonus <= 40)
            {
                AppState.Player4Model.TempBonus += 9;
            }
        }

        private void uTempDown_Hold(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (AppState.Player4Model.TempBonus >= -40)
            {
                AppState.Player4Model.TempBonus -= 9;
            }
        }

    }
}
