using System;
using System.Collections.Generic;
using System.Text;

namespace ATMMachine
{
    public class Account
    {
        private int accountNumber;
        private int pin;

        private decimal AvailableBalance;
        private decimal TotalBalance;

        public bool ValidatePin()
        {
            return true;
        }
    }
}
