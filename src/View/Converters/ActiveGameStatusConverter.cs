using Model.MineSweeper;
using System;
using System.Globalization;
using System.Windows.Data;

namespace View.Converters
{
    internal class ActiveGameStatusConverter : IValueConverter
    {
        public object LostGameStatus { 
            get; set; 
        }

        public object WonGameStatus { 
            get; set; 
        }

        public object InProgressGameStatus { 
            get; set; 
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var activeGameStatus = (GameStatus)value;

            switch (activeGameStatus)
            {
                case GameStatus.Lost:
                    return LostGameStatus;

                case GameStatus.Won:
                    return WonGameStatus;

                case GameStatus.InProgress:
                    return InProgressGameStatus;

                default:
                    throw new ArgumentException("No active game status.");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("Not yet implemented.");
        }
    }
}
