using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AwaitableAwaiter.Custom.Basic;
using AwaitableAwaiter.Custom.ButtonAw;
using AwaitableAwaiter.Custom.Func;

namespace AwaitableAwaiter
{
    //https://weblogs.asp.net/dixin/understanding-c-sharp-async-await-2-awaitable-awaiter-pattern
    public partial class MainForm : Form
    {
        private readonly SynchronizationContext uiSynchronizationContext;

        public MainForm()
        {
            InitializeComponent();
            this.uiSynchronizationContext = SynchronizationContext.Current;
            ButtonExtensions.UiSynchronizationContext = SynchronizationContext.Current;
        }

        private async void btnCustomAwaitable_Click(object sender, EventArgs e)
        {
            await new BasicAwaitable();
        }

        private async void btnFuncAwaitable_Click(object sender, EventArgs e)
        {
            lblFuncResult.Text = "Waiting";
            var result = await new FuncAwaitable<int>(() => 1);
            uiSynchronizationContext.Send(() => lblFuncResult.Text = result.ToString());
        }

        private async void btnFuncExtension_Click(object sender, EventArgs e)
        {
            lblFuncResult.Text = "Waiting";
            var result = await new Func<int>(() => 1);
            uiSynchronizationContext.Send(() => lblFuncResult.Text = result.ToString());
        }

        private async void btnActionExtension_Click(object sender, EventArgs e)
        {
            await new Action(() => uiSynchronizationContext.Send(() => MessageBox.Show("Completed")));
        }

        private async void btnButtonAwaitable_Click(object sender, EventArgs e)
        {
            object result1 = await btnAwaitable1;
            object result2 = await btnAwaitable2;

            MessageBox.Show($@"{result1} - {result2}");
        }

        private async void btnObservable1_Click(object sender, EventArgs e)
        {
            IObservable<int> observable = Observable.Range(0, 3).Do(Console.WriteLine);
            var result = await observable;
            uiSynchronizationContext.Send(() => MessageBox.Show(result.ToString()));
        }

        private async void btnObservable2_Click(object sender, EventArgs e)
        {
            IObservable<string> observable = new[]
                {
                    "https://weblogs.asp.net/dixin/understanding-c-sharp-async-await-1-compilation",
                    "https://weblogs.asp.net/dixin/understanding-c-sharp-async-await-2-awaitable-awaiter-pattern",
                    "https://weblogs.asp.net/dixin/understanding-c-sharp-async-await-3-runtime-context",
                }
                .ToObservable()
                .SelectMany(async url => await new WebClient().DownloadStringTaskAsync(url))
                .Select(GetTitleFromHtml)
                .Do(Console.WriteLine);

            string s = await observable;
            uiSynchronizationContext.Send(() => MessageBox.Show(s));
        }

        private string GetTitleFromHtml(string html)
        {
            var regex = new Regex(@".*<head>.*<title>(.*)</title>.*</head>.*", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            var match = regex.Match(html);
            var result = match.Success ? match.Groups[1].Value : null;
            return result;
        }

    }
}
