using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnInsertLogs_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                LogModel logModel = ToLogModel(i);
                logger.Log(logModel);
            }
        }

        private LogModel ToLogModel(int index)
        {
            var logModel = new LogModel();
            logModel.Message = $@"Message - {index}";
            return logModel;
        }
    }
}
