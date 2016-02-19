using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Munchkin.Portable.Core;

namespace MunchkinApp.Phone.Core
{
    public static class AppState
    {
        public static PlayerModel Player1Model = new PlayerModel() { PlayerName = "Player1" };
        public static PlayerModel Player2Model = new PlayerModel() { PlayerName = "Player2" };
        public static PlayerModel Player3Model = new PlayerModel() { PlayerName = "Player3" };
        public static PlayerModel Player4Model = new PlayerModel() { PlayerName = "Player4" };
        public static PlayerModel Player5Model = new PlayerModel() { PlayerName = "Player5" };
        public static PlayerModel Player6Model = new PlayerModel() { PlayerName = "Player6" };

        public static PlayerContainer PlayerModel = new PlayerContainer();

        public static MonsterModel MonsterModel = new MonsterModel();
    }
}
