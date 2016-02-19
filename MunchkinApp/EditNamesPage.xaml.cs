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
using System.Windows.Input;


namespace MunchkinApp
{
    public partial class EditNamesPage : PhoneApplicationPage
    {
        StorageManager mStorageManager = new StorageManager();
        public EditNamesPage()
        {
            InitializeComponent();
            SetDataContexts();
        }

        private void SetDataContexts()
        {
            uPlayer1Name.DataContext = AppState.Player1Model;
            //uPlayer1Name.DataContext = AppState.Player1Model;
            uPlayer2Name.DataContext = AppState.Player2Model;
            uPlayer3Name.DataContext = AppState.Player3Model;
            uPlayer4Name.DataContext = AppState.Player4Model;
            uPlayer5Name.DataContext = AppState.Player5Model;
            uPlayer6Name.DataContext = AppState.Player6Model;

        }       

        private void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {
            AppState.Player1Model.PlayerName = "Player1";
            AppState.Player2Model.PlayerName = "Player2";
            AppState.Player3Model.PlayerName = "Player3";
            AppState.Player4Model.PlayerName = "Player4";
            AppState.Player5Model.PlayerName = "Player5";
            AppState.Player6Model.PlayerName = "Player6";

            mStorageManager.SavePlayerNames("SavedNames.txt");
        }

        private void uPlayer1ChangeNameBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (uPlayer1ChangeNameBox.Text == string.Empty)
                {
                    AppState.Player1Model.PlayerName = "Player1";
                }
                else
                {
                    AppState.Player1Model.PlayerName = uPlayer1ChangeNameBox.Text;
                    uPlayer1ChangeNameBox.Text = string.Empty;
                }
                mStorageManager.SavePlayerNames("SavedNames.txt");
                this.Focus();
            }
        }

        private void uPlayer2ChangeNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (uPlayer2ChangeNameBox.Text == string.Empty)
                {
                    AppState.Player2Model.PlayerName = "Player2";
                }
                else
                {
                    AppState.Player2Model.PlayerName = uPlayer2ChangeNameBox.Text;
                    uPlayer2ChangeNameBox.Text = string.Empty;
                }
                mStorageManager.SavePlayerNames("SavedNames.txt");
                this.Focus();
            }
        }

        private void uPlayer3ChangeNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (uPlayer3ChangeNameBox.Text == string.Empty)
                {
                    AppState.Player3Model.PlayerName = "Player3";
                }
                else
                {
                    AppState.Player3Model.PlayerName = uPlayer3ChangeNameBox.Text;
                    uPlayer3ChangeNameBox.Text = string.Empty;
                }
                mStorageManager.SavePlayerNames("SavedNames.txt");
                this.Focus();
            }
        }

        private void uPlayer4ChangeNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (uPlayer4ChangeNameBox.Text == string.Empty)
                {
                    AppState.Player4Model.PlayerName = "Player4";
                }
                else
                {
                    AppState.Player4Model.PlayerName = uPlayer4ChangeNameBox.Text;
                    uPlayer4ChangeNameBox.Text = string.Empty;
                }
                mStorageManager.SavePlayerNames("SavedNames.txt");
                this.Focus();
            }
        }

        private void uPlayer5ChangeNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (uPlayer5ChangeNameBox.Text == string.Empty)
                {
                    AppState.Player5Model.PlayerName = "Player5";
                }
                else
                {
                    AppState.Player5Model.PlayerName = uPlayer5ChangeNameBox.Text;
                    uPlayer5ChangeNameBox.Text = string.Empty;
                }
                mStorageManager.SavePlayerNames("SavedNames.txt");
                this.Focus();
            }
        }

        private void uPlayer6ChangeNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (uPlayer6ChangeNameBox.Text == string.Empty)
                {
                    AppState.Player6Model.PlayerName = "Player6";
                }
                else
                {
                    AppState.Player6Model.PlayerName = uPlayer6ChangeNameBox.Text;
                    uPlayer6ChangeNameBox.Text = string.Empty;
                }
                mStorageManager.SavePlayerNames("SavedNames.txt");
                this.Focus();
            }
        }

    }
}