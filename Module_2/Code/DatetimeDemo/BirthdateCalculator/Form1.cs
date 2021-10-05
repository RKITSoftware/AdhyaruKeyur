using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdateCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngetage_Click(object sender, EventArgs e)
        {
            #region Get The Age
            DateTime dob = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime objdatenow = DateTime.Now;
            int Years = new DateTime(DateTime.Now.Subtract(dob).Ticks).Year - 1;
            DateTime PastYearDate = dob.AddYears(Years);
            int Months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (PastYearDate.AddMonths(i) == objdatenow)
                {
                    Months = i;
                    break;
                }
                else if (PastYearDate.AddMonths(i) >= objdatenow)
                {
                    Months = i - 1;
                    break;
                }
            }
            int Days = objdatenow.Subtract(PastYearDate.AddMonths(Months)).Days;
            int Hours = objdatenow.Subtract(PastYearDate).Hours;
            int Minutes = objdatenow.Subtract(PastYearDate).Minutes;
            int Seconds = objdatenow.Subtract(PastYearDate).Seconds;
            #endregion Get The Age

            #region Set To Labels
            lblmin.Text = Minutes.ToString();
            lbldays.Text = Days.ToString();
            lblhour.Text = Hours.ToString();
            lblmonth.Text = Months.ToString();
            lblsec.Text = Seconds.ToString();
            lblyear.Text = Years.ToString();
            #endregion Set To Labels
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            #region Reset All Labels
            lblmin.Text = "0";
            lbldays.Text = "0";
            lblhour.Text = "0";
            lblmonth.Text = "0";
            lblsec.Text = "0";
            lblyear.Text = "0";
            #endregion Reset All Labels
        }

       
    }
}
