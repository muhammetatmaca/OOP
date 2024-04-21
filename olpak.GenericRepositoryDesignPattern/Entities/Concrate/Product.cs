using olpak.GenericRepositoryDesignPattern.Entities.Abstract;

namespace olpak.GenericRepositoryDesignPattern.Entities.Concrate
{
    public class Product:IEntitycs
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stok { get; set; }
    }
}
