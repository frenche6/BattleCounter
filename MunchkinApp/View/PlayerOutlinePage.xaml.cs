using System;
using System.Windows.Controls;
using System.Windows.Navigation;
using MunchkinApp.Phone.Core;


namespace MunchkinApp.View
{
    public partial class PlayerOutlinePage : UserControl
    {
        public PlayerOutlinePage()
        {
            InitializeComponent();
            SetDataContext();
        }

        private void SetDataContext()
        {
            //this.DataContext = AppState.PlayerModel;
            //uPlayer1Text.DataContext = AppState.PlayerModel.Player1Model;

            uPlayer1Text.DataContext = AppState.Player1Model;
            uPlayer2Text.DataContext = AppState.Player2Model;
            uPlayer3Text.DataContext = AppState.Player3Model;
            uPlayer4Text.DataContext = AppState.Player4Model;
            uPlayer5Text.DataContext = AppState.Player5Model;
            uPlayer6Text.DataContext = AppState.Player6Model;

            uPlayer1LevelText.DataContext = AppState.Player1Model;
            uPlayer2LevelText.DataContext = AppState.Player2Model;
            uPlayer3LevelText.DataContext = AppState.Player3Model;
            uPlayer4LevelText.DataContext = AppState.Player4Model;
            uPlayer5LevelText.DataContext = AppState.Player5Model;
            uPlayer6LevelText.DataContext = AppState.Player6Model;

            uPlayer1TotalText.DataContext = AppState.Player1Model;
            uPlayer2TotalText.DataContext = AppState.Player2Model;
            uPlayer3TotalText.DataContext = AppState.Player3Model;
            uPlayer4TotalText.DataContext = AppState.Player4Model;
            uPlayer5TotalText.DataContext = AppState.Player5Model;
            uPlayer6TotalText.DataContext = AppState.Player6Model;

        }

        
        private void uPlayer1Text_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
                        
        }
    }
}
