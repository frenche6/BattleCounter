using System.ComponentModel;

namespace Munchkin.Portable.Core
{
    public class PlayerModel : INotifyPropertyChanged
    {
        private string mPlayerName = "Player";
        public string PlayerName
        {
            get
            {
                return mPlayerName;
            }
            set
            {
                mPlayerName = value;
                RaisePropertyChanged("PlayerName");
            }
        }
        
        private int mPlayerLevel = 1;

        //[System.Xml.Serialization.XmlIgnore()]
        public int PlayerLevel
        {
            get
            {
                return mPlayerLevel;
            }
            set
            {
                mPlayerLevel = value;
                CalculateTotal();
                RaisePropertyChanged("PlayerLevel");
            }
        }

        private int mEquipmentBonus = 0;
        public int EquipmentBonus
        {
            get
            {
                return mEquipmentBonus;
            }
            set
            {
                mEquipmentBonus = value;
                CalculateTotal();
                RaisePropertyChanged("EquipmentBonus");
            }
        }

        private int mTempBonus;
        public int TempBonus
        {
            get
            {
                return mTempBonus;
            }
            set
            {
                mTempBonus = value;
                CalculateTotal();
                RaisePropertyChanged("TempBonus");
            }
        }

        private int mTotalPower = 1;
        public int TotalPower
        {
            get
            {
                return mTotalPower;
            }
            set
            {
                mTotalPower = value;
                RaisePropertyChanged("TotalPower");
            }
        }

        private bool mIsWarrior = false;
        public bool IsWarrior
        {
            get
            {
                return mIsWarrior;
            }
            set
            {
                mIsWarrior = value;
                RaisePropertyChanged("IsWarrior");
            }
        }

        private void CalculateTotal()
        {
            TotalPower = mPlayerLevel + mEquipmentBonus + mTempBonus;
        }

        public void ResetValues()
        {
            PlayerLevel = 1;
            EquipmentBonus = 0;
            TempBonus = 0;
            TotalPower = 1;
            IsWarrior = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
