using CitiCreditUnion;
using Interfaces;
using NationalCreditUnion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Providers
{
    public class CreditUnionFactoryProvider
    {
        public static ICreditUnionFactory GetCreditUnionFactory(string accountNo)
        {
            if (accountNo.Contains("Sehir")) { return new CitiCreditUnionFactory(); }
            else
            if (accountNo.Contains("Ulusal")) { return new NationalCreditUnionFactory(); }
            else
                return null;
        }
    }
}
