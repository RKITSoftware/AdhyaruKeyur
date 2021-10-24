using System;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Button Click
        private void button1_Click(object sender, EventArgs e)
        {
            get_age(dateTimePicker1.Value);
        }
        #endregion Button Click

        #region Get Age
        public void get_age(DateTime dob)
        {
            int age = 0;
            age = DateTime.Now.Subtract(dob).Days;
            age = age / 365;
            label1.Text = age.ToString();
            // return age;
        }
        #endregion Get Age

    }
}
