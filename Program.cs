class MyClass
{
    public static string[] tasks = new string[] { "task1", "task2", "task3", "task4", "task5", "task6" };
    public static Queue<string> queue = new Queue<string>(tasks);
    public static void Main(String[] args)
    {
        
        Display();
    }
   
   

    public static void Display()
    {
        Console.WriteLine("Members in queue are: ");
        foreach (string i in queue)
        {
            Console.Write(i + ", ");
        }
        Console.WriteLine("Total number of elements are " + queue.Count);
        if (queue.Count > 0)
        {
            Console.WriteLine("First Element of the queue is " + queue.Peek());
        }


    }
}