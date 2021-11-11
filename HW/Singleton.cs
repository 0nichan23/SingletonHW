using System;
using System.Collections.Generic;
using System.Text;

namespace singleton
{
    class Singleton
    {
        public static Singleton Instance;
        public float MoneyInAtm;
        private Singleton()
        {
            Instance = this;
            MoneyInAtm = 10000000;
        }

        public float DrawMoney(float amount)
        {
            if (MoneyInAtm - amount >= 0)
            {
                Console.WriteLine("here are " + amount + " $");
                MoneyInAtm -= amount;
                return amount;
            }
            else
            {
                Console.WriteLine("not enough money in the atm");
                return 0;
            }
        }
    }
}
