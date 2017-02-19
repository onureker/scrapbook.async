using System;
using System.CodeDom;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SynchronizationContextDeep.Custom1;
using SynchronizationContextDeep.Custom2;

namespace SynchronizationContextDeep
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSynchronizationContext_Click(object sender, EventArgs e)
        {
            var form = new Demo01.InvokeBy.MainForm();
            form.Show(this);
        }

        private void btnMyPrimitiveSynchronisationContext_Click(object sender, EventArgs e)
        {
            var form = new Demo02.PrimitiveSyncContext.MainForm();
            form.Show(this);
        }

        private void btnStaSynchronizationContext_Click(object sender, EventArgs e)
        {
            var form = new Demo03.StaSyncContext.MainForm();
            form.Show(this);
        }

        private void btnWCFSynchronizationContext_Click(object sender, EventArgs e)
        {
            //TODO:
            //https://www.codeproject.com/Articles/32119/Understanding-SynchronizationContext-Part-III
        }

    }
}
