using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// класс для преобразования вектора исходных значений к внутреннем виду
namespace diplom
{
    class ImgVector
    {
        //поля класса
        private int size;
        private double[] values;

        //функции класса

        public double[] getCoords()
        {
            double x,y = 0;
            double[] coords = new double[2];
            coords[0] = 1;
            coords[1] = 1;
            return coords;
        }
    }
}
