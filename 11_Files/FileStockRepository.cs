using System.IO;
using System;
using System.Collections.Generic;

namespace _11_Files
{
    internal class FileStockRepository : IStockRepository
    {
        private DirectoryInfo repositoryDir;

        public FileStockRepository(DirectoryInfo repositoryDir)
        {
            this.repositoryDir = repositoryDir;
        }
    }
}