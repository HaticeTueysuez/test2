using System;
using System.Text;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder Ergebnis = new StringBuilder();

            int number      = 11    ;
            string snumber  = Convert.ToString(number); // Konvertiert den Typ integer in einen Typ String

            int[] valueHunderter    = {100, 400, 500, 900, 1000};  
            string[] romanHunderter = {"C", "CD", "D", "CM", "M"};  

            int[] valueZehner       = {10, 40, 50, 90};
            string[] romanZehner    = {"X", "XL", "L", "XC"};

            int[] valueEinser       = {1, 4, 5, 9};
            string[] romanEinser    = {"I", "IV", "V", "IX"};
            

            // Überprüfe ob die Zahl im Hunderter Bereich ist
            if(snumber.Length == 3)
            {
                while(number > 100)
                {
                     // Ausgabe von der Hunderter Zahl
                    for (int i = valueHunderter.Length - 1; i >= 0; i--)
                        if (number / valueHunderter[i] >= 1)
                        {
                            number = number - valueHunderter[i];
                            Ergebnis.Append(romanHunderter[i]);
                            break;
                        }  
                }
            }



             // Überprüfe ob die Zahl im Zehner Bereich ist
            if(snumber.Length >= 2) 
            {
                while(number > 10)
                {
                    // Ausgabe von der Zehner Zahl
                    for (int i = valueZehner.Length - 1; i >= 0; i--)
                        if (number / valueZehner[i] >= 1)
                        {
                            number = number - valueZehner[i];
                            Ergebnis.Append(romanZehner[i]);
                            break;
                        }  
                }
            }


             // Überprüfe ob die Zahl im Einser Bereich ist
            if(snumber.Length >= 1)
            {
                while(number > 0)
                {
                    // Ausgabe von der Einser Zahl
                    for (int i = valueEinser.Length - 1; i >= 0; i--)
                        if (number / valueEinser[i] >= 1)
                        {
                            number = number - valueEinser[i];
                            Ergebnis.Append(romanEinser[i]);
                            break;
                        }  
                }
            }

            Console.WriteLine(Ergebnis);

        }
    }
} 
