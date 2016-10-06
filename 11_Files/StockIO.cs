using System;
using System.IO;

namespace _11_Files
{
    internal class StockIO
    {
        internal void WriteStock(StringWriter sw, Stock hp)
        {
            sw.WriteLine(hp.Symbol);
            sw.WriteLine(hp.PricePerShare);
            sw.WriteLine(hp.NumShares);
            sw.Close();
        }

        internal Stock ReadStock(StringReader data)
        {
        double price;
        int number;
      
        string symbol = data.ReadLine();
        string priceAsString = data.ReadLine();
        string numberAsString = data.ReadLine();
        data.Close();
        Double.TryParse(priceAsString, out price);
        int.TryParse(numberAsString, out number);
        return new Stock(symbol, price, number);
    }

        internal void WriteStock(FileInfo output, Stock hp)
        {
            FileStream fs = output.Create();
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(hp.Symbol);
            sw.WriteLine(hp.PricePerShare);
            sw.WriteLine(hp.NumShares);
            sw.Close();

        }

        internal Stock ReadStock(FileInfo output)
        {
            FileStream fs = output.OpenRead();
            StreamReader sw = new StreamReader(fs);
            double price;
            int number;

            string symbol = sw.ReadLine();
            string priceAsString = sw.ReadLine();
            string numberAsString = sw.ReadLine();
            sw.Close();
            Double.TryParse(priceAsString, out price);
            int.TryParse(numberAsString, out number);
            return new Stock(symbol, price, number);
        }
    }
}