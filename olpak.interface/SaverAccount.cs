using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olpak.interfaces
{
    public class SaverAccount : IBankAccount
    {
        private decimal _balance;
        public decimal Balance => _balance;
       

        public void PayIn(decimal amount)
        {
            _balance = _balance + amount;
           ;
        }

        public bool WithDraw(decimal amount)
        {
            if (_balance >= amount)
            {
                _balance = _balance - amount;
                return true;
            }
            Console.WriteLine("withdraw çalışmadı");
            return false;
        }

        public override string ToString() => $"GÜNCEL BAKİYE={_balance}";
        
           
        
    }
}
