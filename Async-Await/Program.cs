namespace Async_Await
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            var learnAsynchronous = new LearnAsynchronous();
            //learnAsynchronous.MainMethod();
            learnAsynchronous.MakeAsyncCancellation();
            Console.ReadKey();
        }
        
    }

}
