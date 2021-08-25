using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            long result = await Sum();
            button1.Text = result.ToString();
        }

        private async Task<long> Sum()
        {
            long sum = 0;

            Task task1 = Task.Run(() =>
            {
                for (long i = 0; i < 10000000000; i++)
                {
                    sum += i;
                }
            });
            await task1;

            return sum;
        }
    }
}
