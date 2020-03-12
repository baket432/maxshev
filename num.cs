using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace num
{
    public class num
    {
        public bool qwe(string x)
        {
            string letter = "АВЕКМНОРСТУХ";
            string chislo = "123456789";
            int[] region = Enumerable.Range(01, 99).ToArray();

            if ((x.Length == 8 || x.Length == 9) && chislo.Contains(x[1]) && chislo.Contains(x[2]) && chislo.Contains(x[3]) && letter.Contains(x[0]) && letter.Contains(x[4]) && letter.Contains(x[5]) && region.Contains(x[6]) && region.Contains(x[7]))
            {
                return true;
            }
            else if (((x.Length == 8 || x.Length == 9) && chislo.Contains(x[1]) && chislo.Contains(x[2]) && chislo.Contains(x[3]) && letter.Contains(x[0]) && letter.Contains(x[4]) && letter.Contains(x[5]) && region.Contains(x[6]) && region.Contains(x[7]) && region.Contains(x[8])))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
