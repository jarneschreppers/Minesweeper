using Cells;
using Model.MineSweeper;

namespace ViewModel
{
    public class GameBoardViewModel
    {
        private readonly ICell<IGameBoard> board;

        public IEnumerable<RowViewModel> Rows { 
            get; 
        }

        public GameBoardViewModel(ICell<IGame> game) {
            this.board = game.Derive(g => g.Board);
            this.Rows = rows(game);
        }

        private IEnumerable<RowViewModel> rows(ICell<IGame> game) {
            var resultrows = new List<RowViewModel>();
            for (int i = 0; i < board.Value.Width; i++)
            {
                resultrows.Add(new RowViewModel(game, i));
            }
            return resultrows;
        }
    }
}
