using System.Windows;
using System.Windows.Controls;
using MunchkinApp.Phone.Core;

namespace MunchkinApp.View
{
    public partial class Monster : UserControl
    {
        public Monster()
        {
            InitializeComponent();
            this.DataContext = AppState.MonsterModel;
        }

        private void uLevelUp_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.MonsterModel.MonsterLevel < 20)
            {
                AppState.MonsterModel.MonsterLevel++;
            }
        }

        private void uLevelDown_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.MonsterModel.MonsterLevel > 1)
            {
                AppState.MonsterModel.MonsterLevel--;
            }
        }

        private void uTemporaryUp_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.MonsterModel.TemporaryBonus < 50)
            {
                AppState.MonsterModel.TemporaryBonus++;
            }
        }

        private void uTemporaryDown_Click(object sender, RoutedEventArgs e)
        {
            if (AppState.MonsterModel.TemporaryBonus > -50)
            {
                AppState.MonsterModel.TemporaryBonus--;
            }
        }

        private void uTemporaryUp_Hold(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (AppState.MonsterModel.TemporaryBonus < 40)
            {
                AppState.MonsterModel.TemporaryBonus += 10;
            }
        }

        private void uTemporaryDown_Hold(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (AppState.MonsterModel.TemporaryBonus > -40)
            {
                AppState.MonsterModel.TemporaryBonus -= 10;
            }
        }
    }
}
