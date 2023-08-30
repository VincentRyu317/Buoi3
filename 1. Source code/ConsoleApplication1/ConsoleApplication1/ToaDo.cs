using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ToaDo
    {
        double X;
        double Y;

        public double X1
        {
            get { return X; }
            set { X = value; }
        }
        
        public double Y1
        {
            get { return Y; }
            set { Y = value; }
        }

        public ToaDo(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public ToaDo()
        {
            X = 3.5;
            Y = 2.5;
        }

        public void Xuat(){
            Console.WriteLine("Tọa độ: ({0}, {1})", X, Y);
        }
    }
}
