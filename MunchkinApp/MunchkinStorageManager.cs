using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.IsolatedStorage;
using Munchkin.Portable.Core;
using System.IO;
using MunchkinApp.Phone.Core;


namespace MunchkinApp
{
    class MunchkinStorageManager
    {
        IsolatedStorageFile mStorageFile = IsolatedStorageFile.GetUserStoreForApplication();

        public void GetPlayerNames()
        {

        }

        private void DefaultPlayerNames()
        {
            List<PlayerModel> lPlayerNameList = new List<PlayerModel>();

            AppState.Player1Model.PlayerName = "Player 1";
            AppState.Player2Model.PlayerName = "Player 2";
            AppState.Player3Model.PlayerName = "Player 3";
            AppState.Player4Model.PlayerName = "Player 4";
            AppState.Player5Model.PlayerName = "Player 5";
            AppState.Player6Model.PlayerName = "Player 6";

            lPlayerNameList.Add(AppState.Player1Model);
            lPlayerNameList.Add(AppState.Player2Model);
            lPlayerNameList.Add(AppState.Player3Model);
            lPlayerNameList.Add(AppState.Player4Model);
            lPlayerNameList.Add(AppState.Player5Model);
            lPlayerNameList.Add(AppState.Player6Model);

            //string lResult = Sumo.Serialization.Xml.Portable.XmlSerializer.Write(lPlayerNameList);
            IsolatedStorageFileStream lFile = mStorageFile.OpenFile("SavedNames.txt", FileMode.Create);
            StreamWriter lWriter = new StreamWriter(lFile);
            // lWriter.Write(lResult);
            lWriter.Dispose();
            lWriter.Close();
        }

        public void SavePlayerNames()
        {
            StreamWriter lWriter = new StreamWriter(new IsolatedStorageFileStream("SavedNames.txt", FileMode.OpenOrCreate, mStorageFile));
            lWriter.WriteLine(AppState.Player1Model.PlayerName);
            lWriter.WriteLine(AppState.Player2Model.PlayerName);
            lWriter.Close();
        }

        private void GetSavedPlayerNames()
        {
            StreamReader lReader = new StreamReader(new IsolatedStorageFileStream("SavedNames.txt", FileMode.Open, mStorageFile));
            string lTextFile = lReader.ReadToEnd();
        }
    }
}
