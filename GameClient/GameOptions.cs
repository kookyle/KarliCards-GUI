using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace KarliCards_GUI
{
    [Serializable]
    public class GameOptions : INotifyPropertyChanged
    {
        private ObservableCollection<string> _playerNames = new ObservableCollection<string>();
        public List<string> SelectedPlayers { get; set; }

        public GameOptions()
        {
            SelectedPlayers = new List<string>();
        }

        public ObservableCollection<string> PlayerNames
        {
            get
            {
                return _playerNames;
            }
            set
            {
                _playerNames = value;
                OnPropertyChanged("PlayerNames");
            }
        }
        public void AddPlayer(string playerName)
        {
            if (_playerNames.Contains(playerName))
                return;
            _playerNames.Add(playerName);
            OnPropertyChanged("PlayerNames");
        }
        private bool _playAgainstComputer = true;
        private int _numkberOfPlayers = 2;
        private ComputerSkillLevel _computerSkill = ComputerSkillLevel.Dumb;

        public int NumberOfPlayers
        {
            get { return _numkberOfPlayers; }
            set
            {
                _numkberOfPlayers = value;
                OnPropertyChanged(nameof(NumberOfPlayers));
            }
        }

        public bool PlayAgainstComputer
        {
            get { return _playAgainstComputer; }
            set
            {
                _playAgainstComputer = value;
                OnPropertyChanged(nameof(PlayAgainstComputer));
            }
        }

        public ComputerSkillLevel ComputerSkill
        {
            get { return _computerSkill; }
            set
            {
                _computerSkill = value;
                OnPropertyChanged(nameof(ComputerSkill));
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
    [Serializable]
    public enum ComputerSkillLevel
    {
        Dumb,
        Good,
        Cheats
    }
}
