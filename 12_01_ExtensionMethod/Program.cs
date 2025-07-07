namespace _12_01_ExtensionMethod
{
    static class ExampleExtension
    {
        public static int NumberWords(this string data)
        {
            if(string.IsNullOrEmpty(data)) return 0;
            return data.Split(new char[] {' ',',','!'}, 
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static int NumberSymbol(this string data, char s)
        {
            if (string.IsNullOrEmpty(data)) return 0;
            int c = 0;

            foreach (var l  in data)
            {
                if (l == s) c++;
            }
            return c;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string str = "Lorem Ipsum is simply dummy text of the " +
                "printing and typesetting industry. ";
            Console.WriteLine("Count off word : " + str.NumberWords());
            Console.WriteLine("Count off word : " + str.NumberSymbol('o'));

        }
    }
}
