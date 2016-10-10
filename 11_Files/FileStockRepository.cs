using System.IO;
using System;
using System.Collections.Generic;

namespace _11_Files
{
    internal class FileStockRepository : IStockRepository, IFileRepository
    {
        private DirectoryInfo repositoryDir;

        List<Stock> StockList = new List<Stock>();

        
        private long Id = 0;

        public object Stockobject { get; private set; }

        public FileStockRepository(DirectoryInfo repositoryDir)
        {
            this.repositoryDir = repositoryDir;
        }

        public long NextId()
        {
            Id++;
            return Id;   
        }

        public string StockFileName(int v)
        {
            return "stock123.txt";
        }

        public object StockFileName(Stock hp)
        {
            return "stock456.txt";
        }

        public void SaveStock(Stock yhoo)
        {
            Stockobject = (int)NextId();
            FileInfo file = new FileInfo(repositoryDir.FullName + "Stock" + Stockobject + ".txt");

           
        }

        public Stock LoadStock(long id)
        {
            FileInfo[] filelist = repositoryDir.GetFiles();
            string nameofFile = "stock" + id + ".txt";

            Stock NewObj = new Stock();

            foreach (FileInfo file in filelist)
            {
                if (nameofFile == file.Name)
                {
                    FileStream fs = file.OpenRead();
                    StreamReader sr = new StreamReader(fs);
                    string symbol = sr.ReadLine();
                    double pricepershare = Convert.ToDouble(sr.ReadLine());
                    int numshares = Convert.ToInt32(sr.ReadLine());

                    sr.Close();
                    fs.Close();

                    NewObj = new Stock(symbol, pricepershare, numshares);



                }
            }
            return NewObj;
        }
    }
}