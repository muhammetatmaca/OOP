namespace olpak.interfaces
{
    
        public interface IBankAccount
        { 
            void PayIn(decimal amount);
            bool WithDraw(decimal amount);

            decimal Balance { get; }
        }
   



}