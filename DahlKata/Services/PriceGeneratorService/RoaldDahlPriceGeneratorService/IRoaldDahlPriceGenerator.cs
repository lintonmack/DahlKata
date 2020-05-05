using System;
using System.Collections.Generic;
using System.Text;

namespace DahlKata.Core.Services.PriceGeneratorService.RoaldDahlPriceGeneratorService
{
    public interface IRoaldDahlPriceGenerator
    {
        double GetTotalPrice(int numberOfRoaldDahlUniqueBooks, int priceOfABook);
    }
}
