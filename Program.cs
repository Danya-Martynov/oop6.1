using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП6._1
{
    class Dom
    {
        int housNum;
        int apartNum;

        public int HousNum
        {
            get { return housNum; }
            set { housNum = value; }
        }

        public int ApartNum
        {
            get { return apartNum; }
            set { apartNum = value; }
        }
        public Dom()
        {

        }
        
        public Dom(int housNum)
        {
            HousNum = housNum;
        }
        public Dom(int housNum, int apartNum)
        {
            HousNum = housNum;
            ApartNum = apartNum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dom d1 = new Dom();
            Dom d2 = new Dom(14);
            Dom d3 = new Dom(34, 13);
        }
    }
}
