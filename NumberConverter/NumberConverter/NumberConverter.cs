using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverter
{
    // class for converting string to number and back for any valid radix (base)
    class NumberConverter
    {

        private enum State
        {
            Ok,
            UnsupportedRadix,
            ParseException,
            OverflowException
        }

        // alphabet of digits
        public readonly string Alphabet;

        public NumberConverter(string alphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ") => Alphabet = alphabet;

        // check wether the radix is valid for current alphabet
        public bool IsValidRadix(int radix) => radix > 1 && radix <= Alphabet.Length;

        // main parsing function
        // return 
        private (State state, long value) _parse(string str, int radix, bool caseSensitive)
        {
            if (!IsValidRadix(radix)) return (State.UnsupportedRadix, 0);
            string alphabet = Alphabet;
            // for case insensitive parsing make both strings in upper case
            if (!caseSensitive)
            {
                alphabet = Alphabet.ToUpper();
                str = str.ToUpper();
            }
            long value = 0;
            long power = 1;
            try
            {
                for (int i = str.Length-1; i >= 0; i--)
                    checked
                    {
                        int digit = alphabet.IndexOf(str[i]);
                        if (digit < 0 || digit >= radix) return (State.ParseException, value);
                        value += power * digit;
                        power *= radix;
                    }
            } catch
            {
                return (State.OverflowException, value);
            }
            return (State.Ok, value);
        }

        // parse string and return wether it was successful
        public bool TryParse(string str, int radix, out long value, bool caseSensitive = false)
        {
            State state;
            (state, value) = _parse(str, radix, caseSensitive);
            return state == State.Ok;
        }

        // either returns parsed number or throws corresponding exception
        public long Parse(string str, int radix, bool caseSensitive = false)
        {
            var (state, value) = _parse(str, radix, caseSensitive);
            switch (state)
            {
                case State.Ok:
                    return value;
                case State.OverflowException:
                    throw new OverflowException("The number is over 64 bits in size.");
                case State.ParseException:
                    throw new FormatException("The number contains invalid digit.");
                case State.UnsupportedRadix:
                    throw new ArgumentOutOfRangeException("The radix is less 2 or above the alpahabet.");
                default:
                    throw new Exception("Unknown state.");
            }
        }

        // converts given number to string accorting to the radix
        public string Stringify(long value, int radix)
        {
            if (radix < 2 || radix >= Alphabet.Length) throw new ArgumentOutOfRangeException("The base is less 2 or above the alpahabet.");
            if (value < 0) throw new ArgumentOutOfRangeException("Negative numbers aren't supported.");
            if (value == 0) return Alphabet.Substring(0, 1);
            StringBuilder str = new StringBuilder((int)(Math.Log(value, radix)) + 1);
            while (value > 0)
            {
                str.Insert(0, Alphabet[(int)(value % radix)]);
                value = (int)(value / radix);
            }
            return str.ToString();
        }
    }

    class Task1 
    { 
        static void Main(string[] args)
        {
            NumberConverter converter = new NumberConverter();
            // get source radix
            Console.Write("Enter source number base: ");
            int sourceRadix;
            if (!ReadRadix(converter.IsValidRadix, out sourceRadix)) return;
            // get target radix
            Console.Write("Enter target number base: ");
            int targetRadix;
            if (!ReadRadix(converter.IsValidRadix, out targetRadix)) return;

            if (sourceRadix == targetRadix)
            {
                Console.WriteLine("Useless convertation.");
                Console.ReadLine();
                return;
            }

            Console.Write("Enter the number: ");
            string sourceNumber = Console.ReadLine();
            // try to parse the number and stringify to target radix
            if (converter.TryParse(sourceNumber, sourceRadix, out long number))
            {
                string targetNumber = converter.Stringify(number, targetRadix);
                Console.WriteLine($"Your result is {targetNumber}");
            }
            else
            {
                Console.WriteLine("Couldn't parse or stringify the number.");
            }

            Console.ReadLine();
        }

        // reads radix and check wether it's valid
        static bool ReadRadix(Func<int, bool> check, out int radix)
        {
            string strBase = Console.ReadLine();
            switch (strBase)
            {
                case "b":
                case "binary":
                    radix = 2;
                    break;
                case "o":
                case "octal":
                    radix = 8;
                    break;
                case "d":
                case "decimal":
                    radix = 10;
                    break;
                case "h":
                case "hex":
                case "heximal":
                    radix = 16;
                    break;
                default:
                    if (int.TryParse(strBase, out radix) && check(radix))
                    {
                        return true;
                    }
                    Console.WriteLine("This radix is not supported.");
                    Console.ReadLine();
                    return false;
            }
            return check(radix);

        }
    }
}
