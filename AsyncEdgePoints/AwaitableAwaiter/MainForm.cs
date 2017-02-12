using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AwaitableAwaiter.Custom.Basic;
using AwaitableAwaiter.Custom.Func;

namespace AwaitableAwaiter
{
    //https://weblogs.asp.net/dixin/understanding-c-sharp-async-await-2-awaitable-awaiter-pattern
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnCustomAwaitable_Click(object sender, EventArgs e)
        {
            await new BasicAwaitable();
        }

        private async void btnFuncAwaitable_Click(object sender, EventArgs e)
        {
            var result = await new FuncAwaitable<int>(() => 1);
            lblFuncResult.Text = result.ToString();
        }

        private async void btnFuncExtension_Click(object sender, EventArgs e)
        {
            var result = await new Func<int>(() => 1);
            lblFuncResult.Text = result.ToString();
        }

        private async void btnActionExtension_Click(object sender, EventArgs e)
        {
            await new Action(() => Debug.WriteLine("Demo"));
        }

        private async void btnObservable1_Click(object sender, EventArgs e)
        {
            IObservable<int> observable = Observable.Range(0, 3).Do(Console.WriteLine);
            await observable;
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
            Console.WriteLine(s);
        }

        public static string GetTitleFromHtml(string html)
        {
            AsyncSubject<object> v;

            var regex = new Regex(@".*<head>.*<title>(.*)</title>.*</head>.*", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            var match = regex.Match(html);
            var result = match.Success? match.Groups[1].Value : null;
            return result;
        }
    }
}
