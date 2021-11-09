// Andrew O'Brien
// 28 Oct 2020
// U4GE1_Temp
// Temperature Conversion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4GE1_Temp
{
    public partial class ConvertingTemperature : Form
    {
        public ConvertingTemperature()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // converts text box tempInput to an int
            int temp = Int32.Parse(tempInput.Text);
            // calculates celsius from fahrenheit
            int celsius = (temp-32) * 5/9;
            // displays to labels 
            farenheitOutput.Text = temp + " degrees Fahrenheit is";
            celsiusOutput.Text = celsius + " degrees Celsius";

        }
    }
}
