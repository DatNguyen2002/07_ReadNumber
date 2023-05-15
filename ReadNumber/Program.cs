using System;

namespace Readnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Nhap so nguyen can doc: ");
            num = int.Parse(Console.ReadLine());

            string resulst = "";
            int ones = num % 10;
            int tens = (num % 100) / 10;
            int hundreds = num / 100;

            switch (hundreds)
            {
                case 1:
                    resulst += "one hundred";
                    break;
                case 2:
                    resulst += "two hundred";
                    break;
                case 3:
                    resulst += "three hundred";
                    break;
                case 4:
                    resulst += "four hundred";
                    break;
                case 5:
                    resulst += "five hundred";
                    break;
                case 6:
                    resulst += "six hundred";
                    break;
                case 7:
                    resulst += "seven hundred";
                    break;
                case 8:
                    resulst += "eight hundred";
                    break;
                case 9:
                    resulst += "nine hundred";
                    break;
            }

            if (hundreds > 0 && (tens > 0 || ones > 0))
            {
                resulst += " and ";
            }

            switch (tens)
            {
                case 1:
                    switch (ones)
                    {
                        case 0:
                            resulst += "ten";
                            break;
                        case 1:
                            resulst += "eleven";
                            break;
                        case 2:
                            resulst += "twelve";
                            break;
                        case 3:
                            resulst += "thirteen";
                            break;
                        case 4:
                            resulst += "fourteen";
                            break;
                        case 5:
                            resulst += "fifteen";
                            break;
                        case 6:
                            resulst += "sixteen";
                            break;
                        case 7:
                            resulst += "seventeen";
                            break;
                        case 8:
                            resulst += "eighteen";
                            break;
                        case 9:
                            resulst += "nineteen";
                            break;
                    }
                    break;
                case 2:
                    resulst += "twenty";
                    break;
                case 3:
                    resulst += "thirty";
                    break;
                case 4:
                    resulst += "forty";
                    break;
                case 5:
                    resulst += "fifty";
                    break;
                case 6:
                    resulst += "sixty";
                    break;
                case 7:
                    resulst += "seventy";
                    break;
                case 8:
                    resulst += "eighty";
                    break;
                case 9:
                    resulst += "ninety";
                    break;
            }

            if (tens != 1 && ones > 0)
            {
                if (hundreds > 0 || tens > 0)
                {
                    resulst += " ";
                }
                switch (ones)
                {
                    case 1:
                        resulst += "One";
                        break;
                    case 2:
                        resulst += "two";
                        break;
                    case 3:
                        resulst += "Three";
                        break;
                    case 4:
                        resulst += "four";
                        break;
                    case 5:
                        resulst += "Five";
                        break;
                    case 6:
                        resulst += "Six";
                        break;
                    case 7:
                        resulst += "Seven";
                        break;
                    case 8:
                        resulst += "Eight";
                        break;
                    case 9:
                        resulst += "Nine";
                        break;
                }
                if (num == 0)
                {
                    resulst = "Zero";
                }
                Console.WriteLine(resulst);
            }
        }
    }
}
