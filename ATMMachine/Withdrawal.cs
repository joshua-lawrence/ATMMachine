using System;
using System.Collections.Generic;
using System.Text;

namespace ATMMachine
{
    public class Withdrawal : Transaction
    {
        private int accountNumber;
        private decimal amount;


        private Screen screen;
        private Keypad keypad;
        private CashDispenser cashDispenser;
        private BankDatabase bankDatabase;

        public Withdrawal()
        {
            
        }

        public override void Execute()
        {

        }

    }
}
