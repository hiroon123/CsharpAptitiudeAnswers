using System.Collections;

public class Queue
{
    private Stack s1 = new Stack();
    private Stack s2 = new Stack();

    public void Enqueue()
    {
        int stack1Count = s1.Count;
        for (int i = 0; i < stack1Count; i++)
        {
            s2.Push(s1.Pop());
        }

        int stack2Count = s2.Count;
        for (int i = 0; i < stack2Count; i++)
        {
            s1.Push(s2.Pop());
        }
    }


    public int Dequeue()
    {
        if (s1.Count == 0)
        {
            Console.WriteLine("Queue is emplty");
        }
        return(int) s1.Pop();
    }
}
