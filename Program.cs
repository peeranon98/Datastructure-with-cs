using System;
using System.IO;

namespace testrun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (var reader = new StreamReader(@"C:\Users\peeranon98\Desktop\BeforeLunch\testrun\testrun\test - แผ่น1.csv"))
            {
                Stack A = new Stack();
                Queue B = new Queue();
                LinkedList C = new LinkedList();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    A.push(values[0]);
                    B.enqueue(values[1]);
                    C.addLast(values[2]);
                }
                A.list.printAllNodes();
                Console.WriteLine();
                B.list.printAllNodes();
                Console.WriteLine();
                C.printAllNodes();
                Console.WriteLine("\n test pop");
                Object a = A.pop();
                //Console.WriteLine(a);
                A.list.printAllNodes();
                Console.WriteLine("\n test deqeue");
                Object b = B.dequeue();
                //Console.WriteLine(a);
                B.list.printAllNodes();
                Console.WriteLine("aaaaa" + C.getElementAtIndex(3));
            }
            
            Console.ReadKey();
        }
    }
}
