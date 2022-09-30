using Cells;
using Model.Data;
using Model.MineSweeper;
using System.Windows.Input;

namespace ViewModel
{
    public class FlagSquareCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public ICell<IGame> game { 
            get; 
        }

        public Vector2D position { 
            get; 
        }

        public FlagSquareCommand(ICell<IGame> game, Vector2D position)
        {
            this.game = game;
            this.position = position;
        }

        public bool CanExecute(object? parameter) {
            if (game.Value.Status == GameStatus.InProgress)
            {
                if (game.Value.Board[position].Status == SquareStatus.Uncovered)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public void Execute(object? parameter) {
            game.Value = game.Value.ToggleFlag(position);
        }
    }
}
