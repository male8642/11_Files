using System;

namespace _11_Files

{
    internal interface IFileRepository
    {
        long NextId();
        string StockFileName(int v);
        object StockFileName(Stock hp);
        void SaveStock(Stock yhoo);
    }
}