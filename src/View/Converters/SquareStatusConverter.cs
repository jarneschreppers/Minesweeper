using Model.MineSweeper;
using System;
using System.Globalization;
using System.Windows.Data;

namespace View.Converters
{
    internal class SquareStatusConverter : IValueConverter
    {
        public object UncoveredSquare { 
            get; set;
        }

        public object CoveredSquare { 
            get; set; 
        }

        public object FlaggedSquare { 
            get; set; 
        }

        public object MineSquare { 
            get; set; 
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var squareStatus = (SquareStatus)value;
            switch (squareStatus)
            {
                case SquareStatus.Uncovered:
                    return UncoveredSquare;

                case SquareStatus.Covered:
                    return CoveredSquare;

                case SquareStatus.Mine:
                    return MineSquare;

                case SquareStatus.Flagged:
                    return FlaggedSquare;

                default:
                    throw new ArgumentException("No square given.");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("Not yet implemented.");
        }
    }
}
