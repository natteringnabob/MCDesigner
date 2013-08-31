using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using log4net;
using log4net.Config;

namespace ChartReader
{

    public interface IReader
    {
        IEnumerable<string> ReadLines(string fileLocation);
    }

    public class Reader: IReader
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Reader));

        public IEnumerable<string> ReadLines(string fileLocation)
        {
            var lines = new List<string>();

            try
            {
                using (var sr = new StreamReader(fileLocation))
                {
                    string line;
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
