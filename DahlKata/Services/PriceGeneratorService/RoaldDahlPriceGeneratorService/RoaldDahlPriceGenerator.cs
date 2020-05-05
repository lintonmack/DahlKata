using System;
using System.Collections.Generic;
using System.Text;

namespace DahlKata.Core.Services.PriceGeneratorService.RoaldDahlPriceGeneratorService
{
    public class RoaldDahlPriceGenerator : IRoaldDahlPriceGenerator
    {
        public double GetTotalPrice(int numberOfRoaldDahlUniqueBooks, int priceOfABook)
        {
            double totalPriceToReturn = 0.00;

            var totalPricePreDiscount = priceOfABook * numberOfRoaldDahlUniqueBooks;

            if (numberOfRoaldDahlUniqueBooks == 1)
            {
                totalPriceToReturn += totalPricePreDiscount;
            }
            else if (numberOfRoaldDahlUniqueBooks == 2)
            {
                totalPriceToReturn += (totalPricePreDiscount - totalPricePreDiscount * 0.05);
            }
            else if (numberOfRoaldDahlUniqueBooks == 3)
            {
                totalPriceToReturn += (totalPricePreDiscount - totalPricePreDiscount * 0.10);
            }
            else if (numberOfRoaldDahlUniqueBooks == 4)
            {
                totalPriceToReturn += (totalPricePreDiscount - totalPricePreDiscount * 0.20);
            }
            else if (numberOfRoaldDahlUniqueBooks == 5)
            {
                totalPriceToReturn += (totalPricePreDiscount - totalPricePreDiscount * 0.25);
            }

            return totalPriceToReturn;
        }
    }
}
