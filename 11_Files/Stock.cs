using System;
using System.Collections;
using System.Collections.Generic;

namespace _11_Files
{
    public class Stock : IAsset
    {
        private string symbol;
        private double pricepershare;
        private int numshares;


        public Stock(string symbol, double pricepershare, int numshares)
        {
            this.symbol = symbol;
            this.pricepershare = pricepershare;
            this.numshares = numshares;
        }

        public Stock()
        {
        }

        public double PricePerShare
        {
            get

            {
                return pricepershare;
            }
            set
            {
                pricepershare = value;
            }
        }

        public string Symbol
        {
            get
            {
                return symbol;
            }
            set
            {
                symbol = value;
            }
        }

        public int NumShares
        {
            get
            {
                return numshares;
            }
            set
            {
                numshares = value;
            }
        }

        public int Id { get; internal set; }

        public double GetValue()
        {
            return pricepershare * numshares;
        }


        public static double TotalValue(Stock[] stocks)
        {
            double total = 0;
            foreach (Stock s in stocks)
            {
                total = total + s.GetValue();
            }
            return total;
        }

        public override string ToString()
        {
            return "Stock[" + "symbol=" + symbol + "," + "pricePerShare=" + pricepershare + "," + "numShares=" + numshares + "]";

        }

        internal static object TotalValue(IAsset[] portfolio)
        {
            double total = 0;
            foreach (IAsset p in portfolio)
            {
                total = total + p.GetValue();
            }
            return total;
        }

        public override bool Equals(object obj)
        {
            Stock abc = (Stock)obj;
            return (this.Symbol == abc.Symbol && this.NumShares == abc.NumShares && this.PricePerShare == abc.PricePerShare);
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public string GetName()
        {
            return symbol;
        }

    }
}
