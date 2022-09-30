using Cells;
using Model.MineSweeper;
using System.Windows.Input;

namespace ViewModel.Screen
{
    public class GameScreenViewModel : ScreenViewModel
    {
        public GameViewModel Game { 
            get; 
        }

        protected ICell<ScreenViewModel> CurrentScreen { 
            get; 
        }

        public GameBoardViewModel Board { 
            get; 
        }

        public ICell<GameStatus> GameStatus { 
            get; 
        }

        public ICommand SwitchToSettings { 
            get; 
        }

        public ICommand StartNewGame { 
            get; 
        }

        public ICommand Settings { 
            get; 
        }

        public GameScreenViewModel(ICell<ScreenViewModel> currentScreen, GameViewModel game) : base(currentScreen) {
            this.Game = game;
            this.CurrentScreen = currentScreen;
            this.Board = new GameBoardViewModel(this.Game.Game);
            this.GameStatus = game.Game.Derive(g => g.Status);

            StartNewGame = new ActionCommand(() => CurrentScreen.Value = new GameScreenViewModel(CurrentScreen, new GameViewModel(game.Size, game.Flooding)));
            Settings = new ActionCommand(() => CurrentScreen.Value = new SettingsScreenViewModel(this.CurrentScreen));
        }
    }
}
