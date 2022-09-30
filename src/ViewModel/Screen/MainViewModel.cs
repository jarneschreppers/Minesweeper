using Cells;

namespace ViewModel.Screen
{
    public class MainViewModel
    {
        public ICell<ScreenViewModel> CurrentScreen { 
            get; 
        }

        public MainViewModel() {
            CurrentScreen = Cell.Create<ScreenViewModel>(null);
            var startScreen = new SettingsScreenViewModel(CurrentScreen);
            CurrentScreen.Value = startScreen;
        }
      
    }
}
