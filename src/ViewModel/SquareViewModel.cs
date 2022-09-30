using Cells;
using Model.Data;
using Model.MineSweeper;
using System.Windows.Input;

namespace ViewModel
{
    public class SquareViewModel
    {
        public ICell<Square> Square { 
            get; 
        }

        public ICommand Uncover { 
            get; 
        }

        public ICommand Flag { 
            get; 
        }

        public ICell<SquareStatus> BombHit { 
            get; 
        }

        public SquareViewModel(ICell<IGame> game, Vector2D position) {
            this.Square = game.Derive(g => g.Board[position]);
            this.Uncover = new UncoverSquareCommand(game, position);
            this.Flag = new FlagSquareCommand(game, position);
            this.BombHit = game.Derive(g => {
                if (g.Status == GameStatus.Lost) {
                    if (g.Mines.Contains(position)) {
                        return SquareStatus.Mine;
                    }
                }
                return g.Board[position].Status;
            });
        }
    }
}
