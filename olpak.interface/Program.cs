namespace olpak.interfaces
{
    partial class Program
    {

        static void Main(string[] args)
        {
            var saver = new SaverAccount();
            saver.PayIn(500);
            saver.WithDraw(34);
            saver.WithDraw(600);
            Console.WriteLine(saver);


            Console.WriteLine(saver);

            Console.ReadKey();
        }
    }



}