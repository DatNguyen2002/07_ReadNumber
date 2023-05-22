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

            string resulst = "";
            int ones = num % 10;
            int tens = (num% 100)/10;

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
            if (num == 0 )
            {
                resulst ="Zero";
            }
            Console.WriteLine(resulst);
        }
    }
}
