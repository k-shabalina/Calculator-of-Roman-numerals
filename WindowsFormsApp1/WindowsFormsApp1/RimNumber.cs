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
            RimN = GetRimNumber(this.ArabN);
        }
        int GetArabNumber(string rim)
        {
            int ar=0;
            char[] mass = rim.ToCharArray();
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] == 'M')
                    ar += 1000;
                else if (mass[i] == 'D')
                    ar += 500;
                else if ((mass[i] == 'C') && (mass[i + 1] == 'M'))
                    ar += 900;
                else if ((mass[i] == 'C') && (mass[i + 1] == 'D'))
                    ar += 400;
                else if (mass[i] == 'C')
                    ar += 100;
                else if (mass[i] == 'L')
                    ar += 50;
                else if ((mass[i] == 'X') && (mass[i + 1] == 'C'))
                    ar += 90;
                else if ((mass[i] == 'X') && (mass[i + 1] == 'L'))
                    ar += 40;
                else if (mass[i] == 'X')
                    ar += 10;
                else if (mass[i] == 'V')
                    ar += 5;
                else if ((mass[i] == 'I') && (mass[i + 1] == 'X'))
                    ar += 9;
                else if ((mass[i] == 'I') && (mass[i + 1] == 'X'))
                    ar += 4;
                else if (mass[i] == 'I')
                    ar += 1;
            }
                    return ar;
        }
        string GetRimNumber(int ar)
        {
            string rim = "";
            char[] mass = (Convert.ToString(ar).ToCharArray());
            for (int i=mass.Length; i>0; i--)
            {
                if (i == 1)
                {
                    if (mass[i] == '1')
                        rim += 'I';
                    else if (mass[i] == '2')
                        rim += "II";
                    else if (mass[i] == '3')
                        rim += "III";
                    else if (mass[i] == '4')
                        rim += "IV";
                    else if (mass[i] == '5')
                        rim += "V";
                    else if (mass[i] == '6')
                        rim += "VI";
                    else if (mass[i] == '7')
                        rim += "VII";
                    else if (mass[i] == '8')
                        rim += "VIII";
                    else if (mass[i] == '9')
                        rim += "IX";
                }
                else
                {
                    if (i == 2)
                        if (mass[i] == '1')
                            rim += 'X';
                        else if (mass[i] == '2')
                            rim += "XX";
                        else if (mass[i] == '3')
                            rim += "XXX";
                        else if (mass[i] == '4')
                            rim += "XL";
                        else if (mass[i] == '5')
                            rim += "L";
                        else if (mass[i] == '6')
                            rim += "LX";
                        else if (mass[i] == '7')
                            rim += "LXX";
                        else if (mass[i] == '8')
                            rim += "LXXX";
                        else if (mass[i] == '9')
                            rim += "XC";
                }
                    else
                     if (i == 2)
                        if (mass[i] == '1')
                            rim += 'X';
                        else if (mass[i] == '2')
                            rim += "XX";
                        else if (mass[i] == '3')
                            rim += "XXX";
                        else if (mass[i] == '4')
                            rim += "XL";
                        else if (mass[i] == '5')
                            rim += "L";
                        else if (mass[i] == '6')
                            rim += "LX";
                        else if (mass[i] == '7')
                            rim += "LXX";
                        else if (mass[i] == '8')
                            rim += "LXXX";
                        else if (mass[i] == '9')
                            rim += "XC";


            }                
            return rim;
        }
    }
}
