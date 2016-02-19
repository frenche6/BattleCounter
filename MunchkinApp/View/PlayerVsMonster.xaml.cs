using System.Windows.Controls;
using MunchkinApp.Phone.Core;

namespace MunchkinApp.View
{
    public partial class PlayerVsMonster : UserControl
    {
        public PlayerVsMonster()
        {
            InitializeComponent();

            uPlayerTotal.DataContext = AppState.Player1Model;
            uMonsterTotal.DataContext = AppState.MonsterModel;
        }

        
    }
}
