using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using LesGraphingCalc;
using calculator;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorCombination
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcForm calcForm = new CalcForm();
            calcForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
