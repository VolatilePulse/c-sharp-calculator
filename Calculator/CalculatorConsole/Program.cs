using System;
using Calculator.Core;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCalc = new Calculator.Core.Calculator();
            myCalc.ReadingChanged += MyCalc_ReadingChanged;

            for (int i = 0; i < 10; i ++)
            {
                myCalc.GenerateReading();
            }
        }

        private static void MyCalc_ReadingChanged(object sender, EventArgs e)
        {
            var myCalc = (Calculator.Core.Calculator)sender;
            Console.WriteLine($"Got Event! Reading is: {myCalc.Reading:F2}");
        }
    }
}
