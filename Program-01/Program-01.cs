using System.Collections;
class Program
{
    //public delegate void SomeDelegate();
    //public static SomeDelegate somedelobj = null;
    public static void Main()
    {
        //somedelobj = Fun1;
        //somedelobj.Invoke();
        SomeClass x = new SomeClass();
        x.sender += Receiver;
        x.sender += Receiver2;
        //x.sender = null; // event keyword in sender doesn't allow this
        Thread t = new Thread(x.HugeProcess);
        t.Start();  
        Console.WriteLine("Program.cs");
        Console.ReadLine();
    }
    static void Receiver(int i) 
    {
        Console.WriteLine("rec " + i);
    }
    static void Receiver2(int i)
    {
        Console.WriteLine("rec 2 " + i);
    }
    //static void Fun1() 
    //{
    //    Console.WriteLine("helloooo");
    //}   
}

class SomeClass
{
    public delegate void Sender(int i);
    public event Sender sender = null; // without event keyword, it is naked

    public void HugeProcess()

    {
        for (int i = 0; i < 10000; i++)
        {
            Thread.Sleep(2000);
            sender(i); // callback
        }
    }
}