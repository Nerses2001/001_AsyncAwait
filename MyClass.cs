namespace _001_AsyncAwait
{
    internal class MyClass
    {

        public void Operation()
        {
            Console.WriteLine("Operation ThreadId {0}", Environment.CurrentManagedThreadId);
            Console.WriteLine("Begin");
            Console.WriteLine("End");
        }
        public async void OperationAsync()
        {
            Task task = new(Operation);
            task.Start();
            await task;
        }
    }
}
