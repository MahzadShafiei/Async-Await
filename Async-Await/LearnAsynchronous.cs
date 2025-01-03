namespace Async_Await
{
    public class LearnAsynchronous
    {
        public async void MainMethod()
        {
            await DelayedMethod();
            Console.WriteLine("Number 2");
        }

        /// <summary>
        /// Simple Async Method
        /// </summary>
        /// <returns></returns>
        public async Task DelayedMethod()
        {
            await Task.Delay(5000);
            Console.WriteLine("Number 1");
        }

        public async void MakeAsyncCancellation()
        {
            var cts = new CancellationTokenSource();

            Console.CancelKeyPress += (sender, e) =>
            {
                Console.WriteLine("Cncellation Requested");
                cts.Cancel();
                e.Cancel = true;
            };

            await LongRunningOperation(cts.Token);
            Console.ReadKey();
        }

        public async Task LongRunningOperation(CancellationToken cancellationToken)
        {
            int counter = 1;
            while (!cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine( $"Operation Number  {counter++} running...");
                await Task.Delay(1000);
            }
        }

    }
}
