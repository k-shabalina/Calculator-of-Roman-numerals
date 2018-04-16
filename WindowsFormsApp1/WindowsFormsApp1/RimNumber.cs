using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RimNumber
    {
        string RimN
        {
            get;
            set;
        }
        int ArabN
        {
            get;
            set;
        }
        //конструкторы
        public RimNumber()//без параметров
        {
            RimN = "";
            ArabN = 0;
        }
        public RimNumber(string RimN)
        {
            this.RimN = RimN;
            ArabN = GetArabNumber(this.RimN);
        }
        public RimNumber(int ArabN)
        {
            this.ArabN = ArabN;
            RimN = GetRimNumber;
        }
        int GetArabNumber(RimNumber rim)
        {
            int ar;
            return ar;
        }
        RimNumber GetRimNumber(int ar)
        {
            RimNumber rim;
            return rim;
        }
    }
}
