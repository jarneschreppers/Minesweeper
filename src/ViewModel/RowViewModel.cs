using Cells;
using Model.Data;
using Model.MineSweeper;

namespace ViewModel
{
    public class RowViewModel
    {
        public IEnumerable<SquareViewModel> Squares { 
            get; 
        }

        public RowViewModel(ICell<IGame> game, int rowIndex) {
             this.Squares = row(game, rowIndex);
        }

        private IEnumerable<SquareViewModel> row(ICell<IGame> game, int rowIndex) {
            var resultingRow = new List<SquareViewModel>();
            for (int i = 0; i < game.Derive(g => g.Board).Value.Width; i++) {
                var pos = new Vector2D(i, rowIndex);
                var squarevm = new SquareViewModel(game, pos);
                resultingRow.Add(squarevm);
            }
            return resultingRow;
        }
    }
}
