using System;
using System.Globalization;
using System.Windows.Data;

namespace View.Converters
{
    internal class SurroundingBombsConverter : IValueConverter
    {
        public object ZeroSurroundingBombs { 
            get; set; 
        }

        public object OneSurroundingBombs { 
            get; set; 
        }

        public object TwoSurroundingBombs { 
            get; set; 
        }

        public object ThreeSurroundingBombs { 
            get; set; 
        }

        public object FourSurroundingBombs { 
            get; set; 
        }

        public object FiveSurroundingBombs { 
            get; set; 
        }

        public object SixSurroundingBombs { 
            get; set; 
        }

        public object SevenSurroundingBombs { 
            get; set; 
        }

        public object EightSurroundingBombs { 
            get; set; 
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((int)value)
            {
                case 0:
                    return ZeroSurroundingBombs;

                case 1:
                    return OneSurroundingBombs;

                case 2:
                    return TwoSurroundingBombs;

                case 3:
                    return ThreeSurroundingBombs;

                case 4:
                    return FourSurroundingBombs;

                case 5:
                    return FiveSurroundingBombs;

                case 6:
                    return SixSurroundingBombs;

                case 7:
                    return SevenSurroundingBombs;

                case 8:
                    return EightSurroundingBombs;

                default:
                    throw new ArgumentException("No number given.");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("Not yet implemented.");
        }
    }
}
