using System;
using System.Collections.Generic;
using System.Text;

namespace DahlKata.Core.Services.PriceGeneratorService.NonRoaldDahlPriceGeneratorService
{
    public class NonRoaldDahlPriceGenerator : INonRoaldDahlPriceGenerator
    {
        public double GetTotalPrice(int numberOfNonRoaldDahlBooks, int priceOfABook)
        {
            return numberOfNonRoaldDahlBooks * priceOfABook;
        }
    }
}
