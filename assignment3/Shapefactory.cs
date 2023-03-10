using System;
using System.Diagnostics;
using System.IO;

namespace shapeCreate
{
    public class Shapefactory
    {
        private static Triangle Createtriangle(int f, int s, int t)
        {
            Triangle tri = new Triangle(f, s, t);
            return tri;
        }
        
        private static Square Createsquare(int side)
        {
            Square s = new Square(side, side, side, side);
            return s;
        }
        private static Rectangle createreRectangle(int l, int w)
        {
            Rectangle r = new Rectangle(l, l, w, w);
            return r;
        }
        
        
        public static Shape Createshape(string shape, params int []list)
        {
            switch (shape)
            {
                case "triangle":
                    if (list.Length != 3)
                    {
                        throw new IOException("The length of array should be 3");
                    }

                    return Createtriangle(list[0], list[1], list[2]);
                
                case "rectangle":
                    if (list.Length != 2)
                    {
                        throw new IOException("The length of array should be 2");
                    }

                    return createreRectangle(list[0], list[1]);
                
                case "square":
                    if (list.Length != 1)
                    {
                        throw new IOException("The length of array should be 1");
                    }

                    return Createsquare(list[0]);
                default:
                    throw new IOException("The shape should be 'triangle', 'rectangle' or 'square'");
            }
        }
    }
}