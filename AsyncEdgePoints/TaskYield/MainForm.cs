using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskYield
{
    //http://blog.stephencleary.com/2015/04/a-tour-of-task-part-10-promise-tasks.html
    //http://vunvulearadu.blogspot.com.tr/2012/07/taskyield-taskdelay.html
    public partial class MainForm : Form
    {
        private readonly List<int> list;

        public MainForm()
        {
            InitializeComponent();
            var random = new Random();

            list = new List<int>();
            for (int i = 0; i < 1000000; i++)
            {
                list.Add(random.Next(2, 2));
            }
        }

        //Yield guarntess asynch..
        private async void btnWithYield_Click(object sender, EventArgs e)
        {
            foreach (int value in list)
            {
                await Task.Yield();
                await Process(value);
            }

            MessageBox.Show("Ok");
        }

        private async void btnWithoutYield_Click(object sender, EventArgs e)
        {
            foreach (int value in list)
            {
                await Process(value);
            }
            MessageBox.Show("Ok");
        }

        private async Task<int> Process(int value)
        {
            var result = await FindFib(value);
            return result;
        }

        private async Task<int> FindFib(int value)
        {
            if (value <= 1)
            {
                return value;
            }

            var result = await FindFib(value - 2) + await FindFib(value - 1);
            return result;
        }

    }
}
