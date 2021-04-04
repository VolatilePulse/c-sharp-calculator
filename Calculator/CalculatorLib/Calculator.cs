using System;

namespace Calculator.Core
{
    public class Calculator
    {
        private decimal _Reading;
        public event EventHandler ReadingChanged;
        public bool IsReadingValid { get; private set; } = false;
        private decimal _Min = 5;
        private decimal _Factor = 5;

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

        public void NewRange(decimal min, decimal max)
        {
            if (min > max)
                throw new ArgumentException();

            _Min = min;
            _Factor = max - min;
        }

        public void GenerateReading()
        {
            var newReading = (decimal)new Random().NextDouble() * _Factor + _Min;
            IsReadingValid = true;

            Reading = newReading;
        }
    }
}
