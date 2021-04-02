using System;

namespace Calculator.Core
{
    public class Calculator
    {
        private decimal _Reading;
        public event EventHandler ReadingChanged;
        public bool IsReadingValid { get; private set; } = false;

        public decimal Reading
        {
            get
            {
                return _Reading;
            }
            private set
            {
                _Reading = value;
                ReadingChanged?.Invoke(this, null);
            }
        }

        public void GenerateReading()
        {
            var newReading = (decimal)new Random().NextDouble() * 5 + 5;
            IsReadingValid = true;

            Reading = newReading;
        }
    }
}
