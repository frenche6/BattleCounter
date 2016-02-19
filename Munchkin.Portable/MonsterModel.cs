using System.ComponentModel;


namespace Munchkin.Portable.Core
{
    public class MonsterModel : INotifyPropertyChanged
    {
        private int mMonsterLevel = 1;
        public int MonsterLevel
        {
            get
            {
                return mMonsterLevel;
            }
            set
            {
                mMonsterLevel = value;
                CalculateTotal();
                RaisePropertyChanged("MonsterLevel");
            }
        }

        private int mTemporaryBonus = 0;
        public int TemporaryBonus
        {
            get
            {
                return mTemporaryBonus;
            }
            set
            {
                mTemporaryBonus = value;
                CalculateTotal();
                RaisePropertyChanged("TemporaryBonus");
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

        private void CalculateTotal()
        {
            TotalPower = mMonsterLevel + mTemporaryBonus;
        }

        public void ResetValues()
        {
            MonsterLevel = 1;
            TemporaryBonus = 0;
            TotalPower = 1;
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
