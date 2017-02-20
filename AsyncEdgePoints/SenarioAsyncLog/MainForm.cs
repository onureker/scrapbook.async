using System;
using System.Linq;
using System.Web.Hosting;
using System.Windows.Forms;

namespace SenarioAsyncLog
{
    public partial class MainForm : Form
    {
        private readonly Logger logger;

        public MainForm()
        {
            InitializeComponent();
            logger = new Logger();
        }

        private void btnConsoleLog_Click(object sender, EventArgs e)
        {
            Enumerable.Range(0, 1000).Select(ToLogModel).ToList().ForEach(model => logger.LogConsole(model));
            MessageBox.Show("OK");
        }

        private void btnTraceLog_Click(object sender, EventArgs e)
        {
            Enumerable.Range(0, 1000).Select(ToLogModel).ToList().ForEach(model => logger.LogTrace(model));
            MessageBox.Show("OK");
        }

        private void btnDBLog_Click(object sender, EventArgs e)
        {
            Enumerable.Range(0, 10).Select(ToLogModel).ToList().ForEach(model => logger.LogDb(model));
            MessageBox.Show("OK");
        }

        private LogModel ToLogModel(int index)
        {
            var logModel = new LogModel();
            logModel.Message = $@"Message - {index}";
            return logModel;
        }

        private void btnHostingEnviornment_Click(object sender, EventArgs e)
        {
            Enumerable.Range(0, 10).Select(ToLogModel).ToList().ForEach(model => HostingEnvironment.QueueBackgroundWorkItem(token => logger.LogTrace(model)));
            MessageBox.Show("OK");
        }
    }
}
