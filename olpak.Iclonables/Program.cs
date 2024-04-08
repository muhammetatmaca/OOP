namespace olpak.Iclonables
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book()
            {
                Id = 1,
                Price = 30.5,
                Tittle="SUÇ VE KADİR"
            };

            var book2 = (Book)book1.Clone();
            book2.Tittle = "SEFİLS";
            Console.WriteLine(book1.Tittle);
            Console.WriteLine(book2.Tittle);
            Console.ReadKey();
        }
    }

}