using System;

namespace shapeCreate
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int areaSum = 0;
            // 随机创建10个形状对象，计算这些对象的面积之和
            string s = null;
            int[] list = null;
            for (int i = 0; i < 10; i++)
            {
                int k = r.Next(0, 3);
                switch (k)
                {
                    case 0:
                        list = new int[3];
                        s = "triangle";
                        for (int j = 0; j < list.Length; j++)
                        {
                            list[j] = r.Next(0, 100);
                        }
                        break;
                    case 1:
                        list = new int[2];
                        s = "rectangle";
                        for (int j = 0; j < list.Length; j++)
                        {
                            list[j] = r.Next(0, 100);
                        }
                        break;
                    case 2:
                        list = new int[1];
                        s = "square";
                        for (int j = 0; j < list.Length; j++)
                        {
                            list[j] = r.Next(0, 100);
                        }
                        break;
                    default:
                        break;
                }

                Shape sh = Shapefactory.Createshape(s, list);
                if (!sh.Islegal())
                {
                    Console.WriteLine("This shape is illegal");
                }
                else
                {
                    Console.WriteLine("This shape is legal");
                    areaSum += sh.Getarea();
                }
                
            }

            
            Console.WriteLine("The sum of area is " + areaSum);
        }
    }
}