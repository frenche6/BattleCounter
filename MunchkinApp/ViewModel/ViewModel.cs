using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Munchkin.Portable.Core;

namespace MunchkinApp.ViewModel
{
    public class ViewModel
    {
        public List<PlayerModel> mPlayerModelList = new List<PlayerModel>();
        
        public void PopulateList()
        {
            DefaultPopulateList();
        }

        private void DefaultPopulateList()
        {
            mPlayerModelList.Add(new PlayerModel() { PlayerName = "Player1" });
            mPlayerModelList.Add(new PlayerModel() { PlayerName = "Player2" });
            mPlayerModelList.Add(new PlayerModel() { PlayerName = "Player3" });
            mPlayerModelList.Add(new PlayerModel() { PlayerName = "Player4" });
            mPlayerModelList.Add(new PlayerModel() { PlayerName = "Player5" });
            mPlayerModelList.Add(new PlayerModel() { PlayerName = "Player6" });

        }

    }
}
