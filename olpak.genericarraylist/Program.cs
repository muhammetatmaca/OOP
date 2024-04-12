using System.Collections;

namespace olpak.genericarraylist
{
     class Program
    {
        static void Main(string[] args)
        {
            var arr2 = new Array<Book>(
                new Book(1, "sefiller", 34),
                new Book(2, "yumuta", 34),
                new Book(3, "mımıtta", 34),
                new Book(4, "kukrurta", 34),
                new Book(5, "buuruuts", 34));

            var arr3 = new Array<Company>(
                new Company()
                    { Country="dsfdsf",Id=5,Name="muhammet"},
                new Company()
                    { Country="dsdf",Id=23,Name="juju"});

            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------------------");
            foreach (var item in arr3) {  Console.WriteLine(item); }
           
            Console.ReadKey();
        }

        private static void NewMethod2()
        {
            var stack = new Stack<Company>();
            stack.Push(new Company()
            { Country = "assl", Id = 1, Name = "muhammet" });
            Console.WriteLine(stack.Peek());
        }

        private static void NewMethod1()
        {
            var list = new LinkedList<Book>();
            list.AddFirst(new Book(1, "YORGUNLAR", 67));
            list.AddFirst(new Book(2, "SEFİLLER", 78));
            list.AddFirst(new Book(3, "HUGO", 45));
            list.AddFirst(new Book(4, "CUDO", 23));

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }

        private static void NewMethod()
        {
            var arr = new Array<int>(1, 2, 3, 4, 5, 6, 7, 8, 9);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}