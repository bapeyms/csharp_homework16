namespace csharp_homework16;

class Program
{
    static void Main(string[] args)
    {
        // 1
        int a = 10;
        int b = 20;
        Console.WriteLine($"- Before Swap method: a = {a}, b = {b}");
        SwapHelper.Swap(ref a, ref b);
        Console.WriteLine($"- After Swap method: a = {a}, b = {b}\n");
        
        // 2
        PriorityQueue<string> queue = new PriorityQueue<string>();
        queue.Enqueue("Task 1", 1);
        queue.Enqueue("Task 2", 2);
        queue.Enqueue("Task 3", 3);
        queue.Enqueue("Task 4", 5);
        
        Console.WriteLine($"Number of elements in the queue: {queue.Count}");
        Console.WriteLine($"Element with high priority: {queue.Peek()}");
        Console.WriteLine($"Deletion: {queue.Dequeue()}");
        Console.WriteLine($"Deletion: {queue.Dequeue()}");
        Console.WriteLine($"Deletion: {queue.Dequeue()}");
        Console.WriteLine($"Deletion: {queue.Dequeue()}");
        Console.WriteLine($"Number of elements in the queue: {queue.Count}");
        Console.WriteLine($"Queue is empty: {queue.IsEmpty}\n");
        
        // 3
        CircularQueue<int> circularQueue = new CircularQueue<int>(5);
        circularQueue.Enqueue(10);
        circularQueue.Enqueue(20);
        circularQueue.Enqueue(30);
        circularQueue.Enqueue(40);
        circularQueue.Enqueue(50);
        
        Console.WriteLine($"Number of elements in the circular queue: {circularQueue.Count}");
        Console.WriteLine($"Element with high priority: {circularQueue.Peek()}");
        Console.WriteLine($"Deletion: {circularQueue.Dequeue()}");
        Console.WriteLine($"Deletion: {circularQueue.Dequeue()}");
        
        circularQueue.Enqueue(60);
        circularQueue.Enqueue(70);
        Console.WriteLine($"New number of elements in the circular queue: {circularQueue.Count}");
        while(!circularQueue.IsEmpty)
            Console.WriteLine(circularQueue.Dequeue());
    }
}