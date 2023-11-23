using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NosovaVD.Sprint5.Task5.V12.Lib
{
    public class DataService : ISprint5Task5V12
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            double summp = 0;
            double summo = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    if(Convert.ToDouble(line) > 0 && Convert.ToDouble(line) % 1 == 0)
                    {
                        summp += Convert.ToDouble(line);
                    }
                    else if (Convert.ToDouble(line) < 0 && Convert.ToDouble(line) % 1 == 0)
                    {
                        summo += Convert.ToDouble(line);
                    }
                }
            }
            res = summp - summo;
            return res;
        }
    }
}
