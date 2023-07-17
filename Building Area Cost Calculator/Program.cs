using System;

namespace ArchitectCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Input the name of the place you're requesting the quote for: \n");
            string place = Console.ReadLine();

            Console.Write("Input the total length of all rectangles in the floorplan in meters: \n");
            double areaRectL = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input the total width of all rectangles in the floorplan in meters: \n");
            double areaRectW = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input the total radius of all circles in the floorplan in meters: \n");
            double areaCircleR = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input the total length of the bottom of all triangles in the floorplan in meters: \n");
            double triangleBottomL = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input the total width of all triangles in the floorplan in meters: \n");
            double triangleWidth = Convert.ToDouble(Console.ReadLine());


            double totalArea = AreaRect(areaRectL, areaRectW) + AreaCircle(areaCircleR) + AreaTriangle(triangleBottomL, triangleWidth);

            double costUSD = Math.Round(totalArea * 10.71, 2);
            double costPeso = Math.Round(totalArea * 180, 2);


            Console.WriteLine($"The area of {place} is {totalArea} meters.\nThe cost of the area amounts to {costUSD} USD, or {costPeso} Mexican Pesos.");

        }

        static double AreaRect(double length, double width)
        {
            double area = length * width;
            return area;
        }

        static double AreaCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        static double AreaTriangle(double bottom, double height)
        {
            double area = 0.5 * bottom * height;
            return area;
        }
    }
}
