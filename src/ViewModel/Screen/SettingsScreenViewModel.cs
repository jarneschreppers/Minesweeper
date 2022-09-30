using Cells;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel.Screen
{
    public class SettingsScreenViewModel : ScreenViewModel
    {
        public ICommand SwitchToGame { get; }
        public ICommand EasyGame { get; }
        public ICommand MediumGame { get; }
        public ICommand HardGame { get; }
        
        public ICell<int> Size { get; }
        public ICell<double> Probability { get; }
        public int min { get; }
        public int max { get; }
        public double minProb { get; }
        public double maxProb { get; }
        public ICell<bool> Flooding { get; }
        public SettingsScreenViewModel(ICell<ScreenViewModel> currentScreen, GameViewModel game = null) : base(currentScreen)
        {
            this.min = IGame.MinimumBoardSize;
            this.max = IGame.MaximumBoardSize;
            this.minProb = 0.1;
            this.maxProb = 1.0;

            this.Size = game != null ? Cell.Create(game.Size) : Cell.Create(5);
            this.Flooding = game != null ? Cell.Create(game.Flooding) : Cell.Create(true);

            SwitchToGame = new ActionCommand(() => CurrentScreen.Value = new GameScreenViewModel(CurrentScreen, new GameViewModel(Size.Value, Flooding.Value)));

        }
    }
}
