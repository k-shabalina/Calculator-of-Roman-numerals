using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
/*
В общем, тебе нужно писать:
public string Plus(string A, string B)
{
RimNumber rim1=new RimNumber(A);
RimNumber rim2=new RimNumber(B);
return rim1+rim2;
}
это для 5 бинарных опеаций
Для смены араб->рим
Public int RimToArab(string rim)
{
return rim.ChangeRimToArab;
}
и наоборот
*/
{
    class RimNumber
    {
        public string RimN { get; set; }
        public int ArabN { get; set; }
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
            int ar = 0;
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
            for (int i = mass.Length; i > 0; i--)
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
                    if (i == 2)
                {
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
                    if (i == 3)
                {
                    if (mass[i] == '1')
                        rim += 'C';
                    else if (mass[i] == '2')
                        rim += "CC";
                    else if (mass[i] == '3')
                        rim += "CCC";
                    else if (mass[i] == '4')
                        rim += "CD";
                    else if (mass[i] == '5')
                        rim += "D";
                    else if (mass[i] == '6')
                        rim += "DC";
                    else if (mass[i] == '7')
                        rim += "DCC";
                    else if (mass[i] == '8')
                        rim += "DCCC";
                    else if (mass[i] == '9')
                        rim += "CM";
                }
                else
                    if (i == 4)
                {
                    if (mass[i] == '1')
                        rim += 'M';
                    else if (mass[i] == '2')
                        rim += "MM";
                    else if (mass[i] == '3')
                        rim += "MMM";
                }
            }
            return rim;
        }
        public static string operator +(RimNumber A, RimNumber B)
        {
            RimNumber C = new RimNumber(A.ArabN + B.ArabN);
            return C.RimN;
        }
        public static string operator -(RimNumber A, RimNumber B)
        {
            RimNumber C = new RimNumber(A.ArabN - B.ArabN);
            return C.RimN;
        }
        public static string operator *(RimNumber A, RimNumber B)
        {
            RimNumber C = new RimNumber(A.ArabN * B.ArabN);
            return C.RimN;
        }
        public static string operator /(RimNumber A, RimNumber B)//div
        {
            RimNumber C = new RimNumber(A.ArabN / B.ArabN);
            return C.RimN;
        }
        public static string operator %(RimNumber A, RimNumber B)//mod
        {
            RimNumber C = new RimNumber(A.ArabN % B.ArabN);
            return C.RimN;
        }
        public int ChangeRimToArab(string rim)
        {
            RimNumber A = new RimNumber(rim);
            return A.ArabN;
        }
        public string ChangeArabToRim(int arab)
        {
            RimNumber A = new RimNumber(arab);
            return A.RimN;
        }
        public static bool CheckArabNumber(int arab)
        {
            bool ok = true;
            if (arab < 0)
                ok = false;
            if (arab > 3999)
                ok = false;
            return ok;
        }
    }
}