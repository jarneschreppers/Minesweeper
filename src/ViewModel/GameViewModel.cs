using Cells;
using Model.MineSweeper;

namespace ViewModel
{
    public class GameViewModel
    {
        
        public ICell<IGame> Game { 
            get; 
        }

        public GameBoardViewModel Board { 
            get; 
        }

        public int Size { 
            get; 
        }
        public bool Flooding { 
            get; 
        }

        public GameViewModel(int size, bool flooding) {
            this.Size = size;
            this.Flooding = flooding;

            Game = Cell.Create(IGame.CreateRandom(size, 0.3, flooding));
            this.Board = new GameBoardViewModel(Game);
        }
    }
}
