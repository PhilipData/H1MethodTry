using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1MethodTry
{
    class FahrenheitConverter
    {
        //Method input
        public void InputMethod()
        {

            int result = 0;
            string Choice1;
            bool canItConvert = false;
            bool repeat = false;
            do
            {
                do
                {
                    Console.WriteLine("*** Fahrenheit omregner ***");
                    Console.WriteLine("Input Fahrenheit:");
                    string str = Console.ReadLine();
                    canItConvert = int.TryParse(str, out result);
                }
                while (!canItConvert);

                double c = ConversionMethod(result);
                OutputMethod(c);

                Console.WriteLine("Press 1 to quit");// try again \nPress 2 to End program");
                Choice1 = Console.ReadLine();
                if (Choice1 == "1")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
                //else
                //{
                //    Console.WriteLine("Input valid key");
                //}

            } while (!repeat);
        }






        double ConversionMethod(int fahrenheit) //parameter krav bliver sat
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            double celsius2dec = Math.Round(celsius, 2);

            //if (celsius2dec < 0) return celsius2dec;
            //else return celsius
            return celsius;
        }
        void OutputMethod(double cel)
        {
            Console.WriteLine("This is the Farenheit in Celsius: " + cel);
        }



    }
}
