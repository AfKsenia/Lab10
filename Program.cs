using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle(0, 10, 10);
            angle.ToRadians();
            Console.ReadKey();
        }
    }
    class Angle
    {
        int gradus;
        int min;
        int sec;
        double rad;

        public int Gradus
        {
            set
            {
                if (value >= 0)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Значение должно быть положительным");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value >= 0)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Значение должно быть положительным");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Значение должно быть положительным");
                }
            }
            get
            {
                return sec;
            }
        }
        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public void ToRadians()
        {
            rad = (Convert.ToDouble(Gradus) + (Convert.ToDouble(Min) + Convert.ToDouble(Sec) / 60) / 60) * Math.PI / 180;
            Console.WriteLine("{0} {1} {2} \nУгол в радианах {3:F4}", gradus, min, sec, rad);
        }

    }
}
