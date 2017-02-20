using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskYield
{
    //http://stackoverflow.com/questions/23431595/task-yield-real-usages
    //http://blog.stephencleary.com/2015/04/a-tour-of-task-part-10-promise-tasks.html
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
                list.Add(random.Next(1, 10));
            }
        }

        //Yield guarntess asynch.. so sometimes code returns to UI thread too
        private async void btnWithYield_Click(object sender, EventArgs e)
        {
            dynamic awaitable = Task.Yield();
            await ExecuteWith(awaitable);
            MessageBox.Show("Ok");
        }

        //WithoutYield all work goes on ThreadPool, because normally ThreadPool has more priority then UI thread.
        private async void btnWithoutYield_Click(object sender, EventArgs e)
        {
            dynamic awaitable = Task.FromResult(0);
            await ExecuteWith(awaitable);
            MessageBox.Show("Ok");
        }

        private async Task ExecuteWith(dynamic awaitable)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int value = list[i];
                var result = await FindFib(value, awaitable);
                lblResult.Text = result.ToString();
                lblCounter.Text = i.ToString();
            }
        }

        private async Task<int> FindFib(int value, dynamic awaitable)
        {
            await awaitable;
            if (value <= 1)
            {
                return value;
            }

            
            var value1 = await FindFib(value - 2, awaitable).ConfigureAwait(false);
            var value2 = await FindFib(value - 1, awaitable).ConfigureAwait(false);
            var result = value1 + value2;
            return result;
        }

    }
}
