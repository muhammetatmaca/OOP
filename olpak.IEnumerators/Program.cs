namespace olpak.IEnumerators
{
    class Program
    {
        static void Main(string[] args)
        {
            var koleksiyon = new List<Product>() 
            { 
                new Product() {Price=4500,ProductId=1,ProductName=" ocak "},
                new Product() {Price=1500,ProductId=2,ProductName=" buzdolabı "},
                new Product() {Price=2500,ProductId=3,ProductName=" fırın "},
                new Product() {Price=4500,ProductId=4,ProductName=" camasir "},



            };

            foreach (var item in koleksiyon)
            {
                Console.WriteLine($"{item.ProductId}"+$"{item.ProductName}"+
                    $"{item.Price}");
            }


            Console.WriteLine(new string('-',25));

            IEnumerator<Product> enumerator = koleksiyon.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine($"{ enumerator.Current.ProductId}"+
                    $"{enumerator.Current.ProductName}"+
                    $"{enumerator.Current.Price}"
                    );
            }
            Console.ReadKey();
        }
    }
}
