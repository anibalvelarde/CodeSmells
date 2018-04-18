using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Smells.Lib.Smells
{
    public class Bloaters
    {
        #region LongParameterList
        public void LongParameterList_CallingCode()
        {
            double basePrice, quantity = 5, itemPrice = 2.50;

            basePrice = quantity * itemPrice;
            double seasonDiscount = this.GetSeasonDiscount();
            double fees = this.GetFees();

            double finalPrice = this.DiscountedPrice(basePrice, seasonDiscount, fees);

        }

        public void LongParameterList_CallingCode_Refactored()
        {
            double basePrice, quantity = 5, itemPrice = 2.50;
            basePrice = quantity * itemPrice;

            double finalPrice = this.DiscountedPriceRefactored(basePrice);
        }

        private double DiscountedPriceRefactored(double basePrice)
        {
            return (basePrice + this.GetFees()) - this.GetSeasonDiscount(); 
        }

        private double DiscountedPrice(double basePrice, double seasonDiscount, double fees)
        {
            // logic for discounted price...
            return (basePrice + fees) - seasonDiscount;
        }

        private double GetFees()
        {
            // logic to get fees
            return 2.55;
        }

        private double GetSeasonDiscount()
        {
            // logic to get discount
            return 0.10;
        }

        #endregion
    }
 }
