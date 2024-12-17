namespace Async_Await
{
    public class LearnAsynchronous
    {
        public void MainMethod()
        {
            DelayedMethod();
            Console.WriteLine("Number 2");
        }

        public async void DelayedMethod()
        {
            await Task.Delay(5000);                      
            Console.WriteLine("Number 1");
        }
    }
}
