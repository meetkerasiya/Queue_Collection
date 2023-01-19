class MyClass
{
    public static string[] tasks = new string[] { "task1", "task2", "task3", "task4", "task5", "task6" };
    public static Queue<string> queue = new Queue<string>(tasks);
    public static void Main(String[] args)
    {
        
        Display();
        QueueFetures();
    }
   
    private static void QueueFetures()
    {
        while (true)
        {
            
            Console.WriteLine("Please enter choise from following. ");
            Console.WriteLine("1 To Enqueue a string into a queue");
            Console.WriteLine("2 To Dequeue a string from a queue");
            Console.WriteLine("3 To check if perticular string is in queue");
            Console.WriteLine("4 To clear the queue");
            Console.WriteLine("5 To quit");

            int choise = -1;
            try
            {
                choise = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Please enter a string to Enqueue");
                    string str = Console.ReadLine();

                    MyClass.queue.Enqueue(str);
                    Display();
                    break;
                case 2:
                    str = queue.Dequeue();
                    Console.WriteLine(str + " Dequeued.");
                    Display();
                    break;
                case 3:
                    Console.WriteLine("Please enter a string to check if it's in queue");
                    str = Console.ReadLine();
                   
                    if (queue.Contains(str))
                    {
                        Console.WriteLine("Yes " + str + " is in queue");
                    }
                    else
                    {
                        Console.WriteLine("No " + str + " is not in queue");
                    }
                    Display();
                    break;
                case 4:
                    queue.Clear();
                    Display();
                    break;
                default:
                    Console.WriteLine("Exiting");
                    Environment.Exit(0);
                    break;
            }
        }
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