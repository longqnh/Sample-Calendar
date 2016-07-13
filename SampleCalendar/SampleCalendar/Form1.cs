using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pabo.Calendar;

namespace SampleCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color color = new Color();
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime from = dt_From.Value;
            DateTime to = dt_To.Value;
            TimeSpan ts = to - from;
            int num = (int)Math.Ceiling(ts.TotalDays) + 1;

            if (num <= 0)
            {
                MessageBox.Show("To must be greater than From", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    color = colorDialog1.Color;
                }
                DateItem[] item = new DateItem[num];
                item.Initialize();
                for (int i = 0; i < num; i++)
                {
                    item[i] = new DateItem();
                    item[i].Date = (Convert.ToDateTime(dt_From.Value.ToShortDateString())).AddDays(i);
                    item[i].BackColor1 = color;
                }
                Calendar.AddDateInfo(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        SelectedDatesCollection dates;
        private void Calendar_DaySelected(object sender, DaySelectedEventArgs e)
        {
            dates = Calendar.SelectedDates;
            dt_From.Value = dates[0];
            dt_To.Value = dates[dates.Count - 1];
            if (dates.Count > 1)
            {
                DateTime from = dt_From.Value;
                DateTime to = dt_To.Value;
                TimeSpan ts = to - from;
                int num = (int)Math.Ceiling(ts.TotalDays) + 1;

                if (num <= 0)
                {
                    MessageBox.Show("To must be greater than From", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    {
                        color = colorDialog1.Color;
                    }
                    DateItem[] item = new DateItem[num];
                    item.Initialize();
                    for (int i = 0; i < num; i++)
                    {
                        item[i] = new DateItem();
                        item[i].Date = (Convert.ToDateTime(dt_From.Value.ToShortDateString())).AddDays(i);
                        item[i].BackColor1 = color;
                    }
                    Calendar.AddDateInfo(item);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Nguyễn Thành Long - HCM University of Information Technology\n"
                       + "Email: ntlong0208@gmail.com","About");
        }

    }
}
