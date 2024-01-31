using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    public static class clsConvert
    {
        public static long ConvertFromBinaryToDecimal(string Binary)
        {
            long Decimal = 0;
            short Length = (short)(Binary.Length - 1);

            for (int i = Length; i >= 0; i--)
            {
                if (Binary[i] == '1')
                {
                    Decimal += (long)Math.Pow(2, (Length - i));
                }
            }

            return Decimal;

            // built-in function
            //return Convert.ToInt64(Binary, 2);
        }
        public static string ConvertFromBinaryToHexadecimal(string Binary)
        {
            long Decimal = ConvertFromBinaryToDecimal(Binary);

            return ConvertFromDecimalToHexadecimal(Decimal);
        }
        public static string ConvertFromBinaryToOctal(string Binary)
        {
            long Decimal = ConvertFromBinaryToDecimal(Binary);

            return ConvertFromDecimalToOctal(Decimal);
        }

        public static string ConvertFromDecimalToBinary(long Decimal)
        {
            if (Decimal == 0)
                return "0";

            StringBuilder sbBinary = new StringBuilder();

            byte Remainder = 0;

            while (Decimal > 0)
            {
                Remainder = (byte)(Decimal % 2);
                Decimal /= 2;

                sbBinary.Insert(0, (char)('0' + Remainder)); // '0' -> (char)48  & '1' -> (char)49
            }


            return sbBinary.ToString();

            // built-in function
            //return Convert.ToString(_Decimal, 2);
        }
        public static string ConvertFromDecimalToHexadecimal(long Decimal)
        {
            if (Decimal == 0)
                return "0";

            StringBuilder sbHexa = new StringBuilder();

            Dictionary<byte, char> keyValueHexa = new Dictionary<byte, char>()
                  {
                      { 0  , '0'  },
                      { 1  , '1'  },
                      { 2  , '2'  },
                      { 3  , '3'  },
                      { 4  , '4'  },
                      { 5  , '5'  },
                      { 6  , '6'  },
                      { 7  , '7'  },
                      { 8  , '8'  },
                      { 9  , '9'  },
                      { 10 , 'A' },
                      { 11 , 'B' },
                      { 12 , 'C' },
                      { 13 , 'D' },
                      { 14 , 'E' },
                      { 15 , 'F' }
                  };

            byte Remainder = 0;

            while (Decimal > 0)
            {
                Remainder = (byte)(Decimal % 16);
                Decimal /= 16;

                sbHexa.Insert(0, keyValueHexa[Remainder]);
            }

            return sbHexa.ToString();

            // built-in function
            //return _Decimal.ToString("X");
        }
        public static string ConvertFromDecimalToOctal(long Decimal)
        {
            if (Decimal == 0)
                return "0";

            StringBuilder sbOctal = new StringBuilder();

            byte Remainder = 0;

            while (Decimal > 0)
            {
                Remainder = (byte)(Decimal % 8);
                Decimal /= 8;

                sbOctal.Insert(0, Remainder);
            }

            return sbOctal.ToString();

            //build-in function
            //return Convert.ToString(Decimal, 8);
        }

        public static long ConvertFromHexadecimalToDecimal(string Hexadecimal)
        {
            long Decimal = 0;

            Dictionary<char, byte> keyValueHexa = new Dictionary<char, byte>()
                  {
                     { '0' , 0  },
                     { '1' , 1  },
                     { '2' , 2  },
                     { '3' , 3  },
                     { '4' , 4  },
                     { '5' , 5  },
                     { '6' , 6  },
                     { '7' , 7  },
                     { '8' , 8  },
                     { '9' , 9  },
                     { 'A' , 10 },
                     { 'B' , 11 },
                     { 'C' , 12 },
                     { 'D' , 13 },
                     { 'E' , 14 },
                     { 'F' , 15 }
                  };

            short Length = (short)(Hexadecimal.Length - 1);

            for (short i = Length; i >= 0; i--)
            {
                Decimal += keyValueHexa[char.ToUpper(Hexadecimal[i])] * (long)Math.Pow(16, (Length - i));
            }

            return Decimal;

            //built-in function
            //return Convert.ToInt64(Hexadecimal, 16);
        }
        public static string ConvertFromHexadecimalToBinary(string Hexadecimal)
        {
            long Decimal = ConvertFromHexadecimalToDecimal(Hexadecimal);

            return ConvertFromDecimalToBinary(Decimal);
        }
        public static string ConvertFromHexadecimalToOctal(string Hexadecimal)
        {
            long Decimal = ConvertFromHexadecimalToDecimal(Hexadecimal);

            return ConvertFromDecimalToOctal(Decimal);
        }

        public static long ConvertFromOctalToDecimal(string Octal)
        {
            long Decimal = 0;

            short Length = (short)(Octal.Length - 1);

            for (short i = Length; i >= 0; i--)
            {
                Decimal += byte.Parse(Octal[i].ToString()) * (long)Math.Pow(8, (Length - i));
            }

            return Decimal;

            //build-in function
            //return Convert.ToInt64(Octal, 8);
        }
        public static string ConvertFromOctalToBinary(string Octal)
        {
            long Decimal = ConvertFromOctalToDecimal(Octal);

            return ConvertFromDecimalToBinary(Decimal);
        }
        public static string ConvertFromOctalToHexadecimal(string Octal)
        {
            long Decimal = ConvertFromOctalToDecimal(Octal);

            return ConvertFromDecimalToHexadecimal(Decimal);
        }
    }
}
