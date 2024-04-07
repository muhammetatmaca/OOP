namespace olpak.abstractc
{
     class Program 
    {
        static void Main(String[] args)
        {
            var arr=new int[] {1,2,3,5,6};
            var minheap = new MinHeap();
            var maxheap = new MaxHeap();

            foreach(int i in arr)
            {
                minheap.Insert(i);
                maxheap.Insert(i);
            }

            Console.WriteLine(minheap.Extract());
            Console.WriteLine(maxheap.Extract());
        }


    }


}