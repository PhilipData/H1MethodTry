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
            bool canItConvert = false;
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
            Console.WriteLine("F to C " + cel);
        }



    }
}
