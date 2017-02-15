using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Windows.Forms;

namespace LogAsync
{
    //http://stackoverflow.com/questions/29577652/calling-an-async-method-without-awaiting
    //http://blog.stephencleary.com/2014/06/fire-and-forget-on-asp-net.html
    //http://hangfire.io/
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            HostingEnvironment.QueueBackgroundWorkItem(Log);
        }

        private Task Log(CancellationToken cancellationToken)
        {
            return LogAsync("Message");
        }

        private Task LogAsync(string message)
        {
            return Task.Run(() => Console.WriteLine(message));
        }
    }
}
