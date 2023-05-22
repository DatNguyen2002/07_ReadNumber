using System;

namespace ReadNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Nhap so nguyen can doc: ");
            num = int.Parse(Console.ReadLine());

            string result = "";
            int hundreds = num / 100;
            int tens = (num % 100) / 10;
            int ones = num % 10;

            switch (hundreds)
            {
                case 1:
                    result += "one hundred";
                    break;
                case 2:
                    result += "two hundred";
                    break;
                case 3:
                    result += "three hundred";
                    break;
                case 4:
                    result += "four hundred";
                    break;
                case 5:
                    result += "five hundred";
                    break;
                case 6:
                    result += "six hundred";
                    break;
                case 7:
                    result += "seven hundred";
                    break;
                case 8:
                    result += "eight hundred";
                    break;
                case 9:
                    result += "nine hundred";
                    break;
            }

            if (hundreds > 0 && (tens > 0 || ones > 0))
            {
                result += " and ";
            }

            switch (tens)
            {
                case 1:
                    switch (ones)
                    {
                        case 0:
                            result += "ten";
                            break;
                        case 1:
                            result += "eleven";
                            break;
                        case 2:
                            result += "twelve";
                            break;
                        case 3:
                            result += "thirteen";
                            break;
                        case 4:
                            result += "fourteen";
                            break;
                        case 5:
                            result += "fifteen";
                            break;
                        case 6:
                            result += "sixteen";
                            break;
                        case 7:
                            result += "seventeen";
                            break;
                        case 8:
                            result += "eighteen";
                            break;
                        case 9:
                            result += "nineteen";
                            break;
                    }
                    break;
                case 2:
                    result += "twenty";
                    break;
                case 3:
                    result += "thirty";
                    break;
                case 4:
                    result += "forty";
                    break;
                case 5:
                    result += "fifty";
                    break;
                case 6:
                    result += "sixty";
                    break;
                case 7:
                    result += "seventy";
                    break;
                case 8:
                    result += "eighty";
                    break;
                case 9:
                    result += "ninety";
                    break;
            }

            if (tens != 1 && ones > 0)
            {
                if (hundreds > 0 || tens > 0)
                {
                    result += " ";
                }

                switch (ones)
                {
                    case 1:
                        result += "one";
                        break;
                    case 2:
                        result += "two";
                        break;
                    case 3:
                        result += "three";
                        break;
                    case 4:
                        result += "four";
                        break;
                    case 5:
                        result += "five";
                        break;
                    case 6:
                        result += "six";
                        break;
                    case 7:
                        result += "seven";
                        break;
                    case 8:
                        result += "eight";
                        break;
                    case 9:
                        result += "nine";
                        break;
                }
            }
            if (num == 0)
            {
                result = "zero";
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
        
    }
}
