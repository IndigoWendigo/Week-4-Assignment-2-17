
namespace Week4Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the minimum amount for your rectangle's values: ");

            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the maximum amount for your rectangle's values: ");

            int max = Convert.ToInt32(Console.ReadLine());

            if (max < min)
            {
                Console.WriteLine("Invalid amounts detected, minimum is larger than maximum. Please restart the program.");
            }
            else
            {
                int length = makeRectangle(min, max);
                int width = makeRectangle(min, max);

                Rectangle rekt = new Rectangle();

                Console.WriteLine("Length: " + length);
                Console.WriteLine("Width: " + width);
                Console.WriteLine("Perimeter: " + rekt.getPerimeter(length,width));
                Console.WriteLine("Area: " + rekt.getArea(length,width));
            }

        }

        static int makeRectangle(int min, int max)
        {
            Random ranDUMB= new Random();
            int value = ranDUMB.Next(min, max);
            return value;
        }

        class Rectangle
        {

            public Rectangle()
            {

            }

            public int getPerimeter(int length, int width)
            {
                return (length + width) * 2;
            }

            public int getArea(int length, int width)
            {
                return length * width;
            }
        }
    }
}