using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CCS
{
    public class FileLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log()
        {  
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
