using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sumo.Serialization.Core.Portable;
using System.IO.IsolatedStorage;

namespace Munchkin.Phone.Core
{
    class MunchkinPhoneStorageManager
    {
        //IsolatedStorageFile mStorageFile;
        XmlSerializer XMLSerializer;

        public void GetPlayerNames()
        {
            //string lResult = Sumo.Serialization.Xml.Portable.XmlSerializer.Write(lPlayerNameList);
            IsolatedStorageFileStream lFile = mStorageFile.OpenFile("SavedNames.txt", FileMode.Create);
            StreamWriter lWriter = new StreamWriter(lFile);
            // lWriter.Write(lResult);
            lWriter.Dispose();
            lWriter.Close();
        }

        private void DefaultPlayerNames()
        {
            //App.Player1Model.PlayerName = "Player 1";
            //App.Player2Model.PlayerName = "Player 2";
            //App.Player3Model.PlayerName = "Player 3";
            //App.Player4Model.PlayerName = "Player 4";
            //App.Player5Model.PlayerName = "Player 5";
            //App.Player6Model.PlayerName = "Player 6";


        }

        private void GetSavedPlayerNames()
        {

        }
    }
}
