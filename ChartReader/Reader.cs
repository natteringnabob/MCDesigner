using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using log4net;
using log4net.Config;

namespace ChartReader
{
    public class Reader
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Reader));

        public IEnumerable<string> ReadLines(string fileLocation)
        {
            var lines = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(fileLocation))
                {
                    var line = string.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }                    
                }
            }
            catch (Exception ex)
            {
                //TODO: create custom file not read exception
                log.Error("File Read Error", ex);
                throw ex;
            }


            return lines;
        }
    }
}
