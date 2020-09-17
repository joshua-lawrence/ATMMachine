using System;
using System.Collections.Generic;
using System.Text;

namespace ATMMachine
{
    class Account
    {
        int accountNumber;
        int pin;

        Decimal AvailableBalance;
        Decimal TotalBalance;

        public bool ValidatePin()
        {
            return true;
        }
    }
}
