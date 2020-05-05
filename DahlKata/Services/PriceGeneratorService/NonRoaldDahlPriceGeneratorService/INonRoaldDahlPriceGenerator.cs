using System;
using System.Collections.Generic;
using System.Text;

namespace DahlKata.Core.Services.PriceGeneratorService.NonRoaldDahlPriceGeneratorService
{
    public interface INonRoaldDahlPriceGenerator
    {
        double GetTotalPrice(int numberOfNonRoaldDahlBooks, int priceOfABook);
    }
}
