# 001_AsyncAwait
## Asynchronous Execution Example in C# using async/await

In this example, we present C# code demonstrating asynchronous operation execution using the `async` and `await` keywords.

### Code

```csharp
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
            Task task = new(Task);
            task.Start();
            await task;
        }
    }
}
```
## Definitions

- **Task**: `Task` represents a unit of work that can be executed asynchronously. It is an abstraction for working with asynchronous operations.

- **async/await**: The `async` and `await` keywords facilitate asynchronous programming. `async` indicates that a method contains asynchronous code, and `await` suspends the method's execution until an asynchronous operation is completed.

## Result of Code Execution

When running this code, the `OperationAsync` function will be executed asynchronously, resulting in the following output:
```plaintext
General ThreadId <ID of the main thread>
Operation ThreadId <ID of the operation thread>
Begin
End
```
The `OperationAsync` function asynchronously invokes the `Operation` method, which outputs information about the execution thread of the operation, the beginning, and the end. Note that the execution occurs in a single thread (the main thread), even during asynchronous handling of the operation.

