using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab01_part03
{
    internal class Point3D
    {
        private int X,Y,Z;
       

        public void setX(int x) { X = x; }
        public void setY(int y) { Y = y; }
        public void setZ(int z) { Z = z; }

        public int getX() { return X; }
        public int getY() { return Y; }
        public int getZ() { return Z; }

        public void Display()
        {
            Console.WriteLine($"({getX()},{getY()},{getZ()})\n");

        }

        public int CalculateDistance(Point3D p1,Point3D p2)

        {
          int  x1=p1.getX();
            int x2=p2.getX();

           int x3 = (x2 - x1);


           /* x3=Math.Abs(x3);
            return x3;*/
           
            if (x3>=0)
            return x3 ;
            else
            {
                x3 *= -1;
                return x3;
            }
           

        }
    }
}
