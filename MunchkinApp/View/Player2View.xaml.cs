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
    public partial class Player2View : UserControl
    {
        public Player2View()
        {
            InitializeComponent();
            this.DataContext = AppState.Player2Model;
        }

        private void uLevelup_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player2Model.PlayerLevel < 10)
            {
                AppState.Player2Model.PlayerLevel++;
            }
        }

        private void uLevelDown_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player2Model.PlayerLevel > 1)
            {
                AppState.Player2Model.PlayerLevel--;
            }
        }

        private void uArmorUp_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player2Model.EquipmentBonus < 50)
            {
                AppState.Player2Model.EquipmentBonus++;
            }
        }

        private void uArmorDown_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player2Model.EquipmentBonus > 0)
            {
                AppState.Player2Model.EquipmentBonus--;
            }
        }

        private void uTempDown_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player2Model.TempBonus > -50)
            {
                AppState.Player2Model.TempBonus--;
            }
        }

        private void uTempUp_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.Player2Model.TempBonus < 50)
            {
                AppState.Player2Model.TempBonus++;
            }
        }

        private void uTempUp_Hold(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (AppState.Player2Model.TempBonus <= 40)
            {
                AppState.Player2Model.TempBonus += 9;
            }
        }

        private void uTempDown_Hold(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (AppState.Player2Model.TempBonus >= -40)
            {
                AppState.Player2Model.TempBonus -= 9;
            }
        }
    }
}
