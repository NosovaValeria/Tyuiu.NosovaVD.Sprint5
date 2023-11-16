using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NosovaVD.Sprint5.Task1.V28.Lib
{
    public class DataService : ISprint5Task1V28
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Cos(x)/(x-0.7) - Math.Sin(x) * 12.0 * x + 2), 2);
                strY = Convert.ToString(y);
                if (x != stopValue && (x - 0.7) != 0)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                if (x != stopValue && (x - 0.7) == 0)
                {
                    File.AppendAllText(path, "0" + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
