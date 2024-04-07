namespace olpak.abstractc
{
    public abstract partial class Heap
    {
        protected SortedSet<int> _list;

        public Heap()
        {
            _list = new SortedSet<int>();
        }

        public void Insert(int i)
        {
            _list.Add(i);
        }

        public  abstract int Extract();
    }

}