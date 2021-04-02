using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForm
{
    public partial class CalculatorForm : Form, INotifyPropertyChanged
    {
        private decimal _LastReading;
        private string myString = "Fred";

        public event PropertyChangedEventHandler PropertyChanged;

        public CalculatorForm()
        {
            InitializeComponent();
            Calc = new Calculator.Core.Calculator();
            Calc.ReadingChanged += Calc_ReadingChanged;
            ReadingTextBox.DataBindings.Add("Text", this, "MyString");
        }
        public string MyString
        {
            get => myString; set
            {
                myString = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyString)));
            }
        }
        public Calculator.Core.Calculator Calc { get; }
        public decimal LastReading
        {
            get => _LastReading; private set
            {
                _LastReading = value;
                MyString = _LastReading.ToString("F2");
            }
        }

        private void NewReading_Click(object sender, EventArgs e)
        {
            Calc.GenerateReading();
        }

        private void Calc_ReadingChanged(object sender, EventArgs e)
        {
            var myCalc = (Calculator.Core.Calculator)sender;
            LastReading = myCalc.Reading;
        }
    }
}
