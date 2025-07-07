namespace _13_GarbageCollector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(Garbage Collector).

            int a = 5;
            string str = "Hello 1";
            string copy = null;//null  " "
            //Console.WriteLine(copy.Length);
            if(true)
            {
                int b = 10;
                string str2 = "Hello 2";
                copy = str2;
                Console.WriteLine(str2);
            }
            Console.WriteLine(str);
            Console.WriteLine(copy);
           // Console.WriteLine(str2);



        }
    }
}
