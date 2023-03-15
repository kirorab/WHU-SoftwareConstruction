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
            shapeType s = shapeType.emptyShape;
            int[] list = null;
            for (int i = 0; i < 10; i++)
            {
                int k = r.Next(0, 3);
                switch (k)
                {
                    case 0:
                        list = new int[3];
                        s = shapeType.triangle;
                        for (int j = 0; j < list.Length; j++)
                        {
                            list[j] = r.Next(0, 100);
                        }
                        break;
                    case 1:
                        list = new int[2];
                        s = shapeType.rectangle;
                        for (int j = 0; j < list.Length; j++)
                        {
                            list[j] = r.Next(0, 100);
                        }
                        break;
                    case 2:
                        list = new int[1];
                        s = shapeType.square;
                        for (int j = 0; j < list.Length; j++)
                        {
                            list[j] = r.Next(0, 100);
                        }
                        break;
                    default:
                        break;
                }
                
                try
                {
                    Shape sh = Shapefactory.Createshape(s, list);
                    areaSum += sh.Getarea();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }
            Console.WriteLine("The sum of area is " + areaSum);
        }
    }
}