namespace _11_Files
{
    internal class Stock
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
    }
}