namespace qiao
{
    internal class Program
    {
        static async Task Main(string[] args)
        { CancellationTokenSource cts = new CancellationTokenSource();
            cts.CancelAfter(5000);
            CancellationToken cToken = cts.Token;
            await DownloadAsync("https://battlelog.battlefield.com/bf4/zh/", 100, cToken);
        }
        static async Task DownloadAsync(string url, int n, CancellationToken cancellationToken)
        {
            using (HttpClient httpclient = new HttpClient())
            {
                for (int i = 0; i < n; i++)
                {
                    string html = await httpclient.GetStringAsync(url);
                    await Console.Out.WriteLineAsync($"{DateTime.Now}:{html}");
                  
                    cancellationToken.ThrowIfCancellationRequested();

                }


            }
        }

    }
}