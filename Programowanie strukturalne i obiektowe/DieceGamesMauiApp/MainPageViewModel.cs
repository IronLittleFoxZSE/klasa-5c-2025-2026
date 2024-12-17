using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieceGamesMauiApp
{
    public class MainPageViewModel : BindableObject
    {
        private int gameValue;
        public int GameValue
        {
            get { return gameValue; }
            set { gameValue = value; OnPropertyChanged(); }
        }

        private int totalGameValue;
        public int TotalGameValue
        {
            get { return totalGameValue; }
            set { totalGameValue = value; OnPropertyChanged(); }
        }

        private ObservableCollection<int> diceValues;
        public ObservableCollection<int> DiceValues
        {
            get { return diceValues; }
            set { diceValues = value; OnPropertyChanged(); }
        }

        private Command rollDiceCommand;
        public Command RollDiceCommand
        {
            get
            {
                if (rollDiceCommand == null)
                    rollDiceCommand = new Command(
                        () =>
                        {
                            DiceValues = new ObservableCollection<int>();
                            Random random = new Random();
                            for (int i = 0; i < 5; i++)
                            {
                                DiceValues.Add(random.Next(1, 7));

                                GameValue = DiceValues.GroupBy(n => n).Where(g => g.Count() > 1).Sum(g => g.Sum());
                                TotalGameValue += GameValue;
                            }
                        }
                        );
                return rollDiceCommand;
            }
        }

        private Command resetCommand;
        public Command ResetCommand
        {
            get
            {
                if (resetCommand == null)
                    resetCommand = new Command(
                        () =>
                        {
                            GameValue = 0;
                            TotalGameValue = 0;
                            DiceValues = new ObservableCollection<int>(Enumerable.Repeat(0, 5));
                        }
                        );
                return resetCommand;
            }
        }


        public MainPageViewModel()
        {
            ResetCommand.Execute(this);
        }
    }
}
