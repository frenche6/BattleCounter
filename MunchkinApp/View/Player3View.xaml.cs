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


namespace MunchkinApp.View
{
    public partial class Player3View : UserControl
    {
        public Player3View()
        {
            InitializeComponent();
            this.DataContext = AppState.Player3Model;
        }

        private void uLevelup_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player3Model.PlayerLevel < 10)
            {
                AppState.Player3Model.PlayerLevel++;
            }
        }

        private void uLevelDown_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player3Model.PlayerLevel > 1)
            {
                AppState.Player3Model.PlayerLevel--;
            }
        }

        private void uArmorUp_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player3Model.EquipmentBonus < 50)
            {
                AppState.Player3Model.EquipmentBonus++;
            }
        }

        private void uArmorDown_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player3Model.EquipmentBonus > 0)
            {
                AppState.Player3Model.EquipmentBonus--;
            }
        }

        private void uTempDown_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player3Model.TempBonus > -50)
            {
                AppState.Player3Model.TempBonus--;
            }
        }

        private void uTempUp_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player3Model.TempBonus < 50)
            {
                AppState.Player3Model.TempBonus++;
            }
        }

        private void uTempUp_Hold(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (AppState.Player3Model.TempBonus <= 40)
            {
                AppState.Player3Model.TempBonus += 9;
            }
        }

        private void uTempDown_Hold(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (AppState.Player3Model.TempBonus >= -40)
            {
                AppState.Player3Model.TempBonus -= 9;
            }
        }

    }
}
