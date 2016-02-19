using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.IsolatedStorage;
using Sumo.Serialization.Core.Portable;
using System.IO;
using Munchkin.Portable.Core;
using MunchkinApp;

namespace MunchkinApp.Phone.Core
{
    public class StorageManager
    {
        IsolatedStorageFile mStorage = IsolatedStorageFile.GetUserStoreForApplication();

        //private List<string> mListOfNames = new List<string>();


        private void GetDefaultNames()
        {
            AppState.Player1Model.PlayerName = "Player1";
            AppState.Player2Model.PlayerName = "Player2";
            AppState.Player3Model.PlayerName = "Player3";
            AppState.Player4Model.PlayerName = "Player4";
            AppState.Player5Model.PlayerName = "Player5";
            AppState.Player6Model.PlayerName = "Player6";
        }

        public void GetSavedNames(string aFileName)
        {
            List<string> lResult = null;

            if (mStorage.FileExists(aFileName))
            {
                
                IsolatedStorageFileStream lFile = mStorage.OpenFile(aFileName, FileMode.Open);
                StreamReader lReader = new StreamReader(lFile);
                string lXMLContent = lReader.ReadToEnd();

                lResult = (List<string>)XmlSerializer.Read(typeof(List<string>), lXMLContent, false);
                lReader.Dispose();
                lReader.Close();

                AppState.Player1Model.PlayerName = lResult[0];
                AppState.Player2Model.PlayerName = lResult[1];
                AppState.Player3Model.PlayerName = lResult[2];
                AppState.Player4Model.PlayerName = lResult[3];
                AppState.Player5Model.PlayerName = lResult[4];
                AppState.Player6Model.PlayerName = lResult[5];
            }
            else
            {
                GetDefaultNames();
            }
        }

        public void SavePlayerNames(string aFileName)
        {
            List<string> lPlayerNameList = new List<string>();

            
            lPlayerNameList.Add(AppState.Player1Model.PlayerName);
            lPlayerNameList.Add(AppState.Player2Model.PlayerName);
            lPlayerNameList.Add(AppState.Player3Model.PlayerName);
            lPlayerNameList.Add(AppState.Player4Model.PlayerName);
            lPlayerNameList.Add(AppState.Player5Model.PlayerName);
            lPlayerNameList.Add(AppState.Player6Model.PlayerName);

            string lResult = Sumo.Serialization.Core.Portable.XmlSerializer.Write(lPlayerNameList);
            IsolatedStorageFileStream lFile = mStorage.OpenFile(aFileName, FileMode.Create);
            StreamWriter lWriter = new StreamWriter(lFile);
            lWriter.Write(lResult);
            lWriter.Dispose();
            lWriter.Close();
        }

        private bool FileExists(string aFileName)
        {
            //IsolatedStorageFileStream lStorageFile = null;
            bool lResult = true;

            lResult = mStorage.FileExists(aFileName);
            //lStorageFile = mStorage.OpenFile(aFileName, FileMode.Open); //await ApplicationData.Current.LocalFolder.GetFileAsync(aFileName);
                        
            //Action lAction = new Action(HackMethod);
            //Task lTask = new Task(lAction);
            //lTask.Start();
            //await lTask;//.AsAsyncAction();

            return lResult;
        }

    }
}
