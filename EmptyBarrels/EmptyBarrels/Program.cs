namespace EmptyBarrels
{
    internal class Program
    {
        public static float vol(float radius, float height)
        {
            float pi = 3.14f;
            float calVol = ((pi * (radius * radius)) * height);
            return calVol;
        }
        public static float area (float radius, float height)
        {
            float pi = 3.14f;
            float calArea = 2 * pi * (radius * radius) + 2 * pi * radius * height;
            return calArea;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please write the radius of your cylinder (units must be consistent): ");
            float radiusInput = float.Parse(Console.ReadLine());
            Console.WriteLine("Please write the height of your cylinder (units must be consistent): ");
            float heightInput = float.Parse(Console.ReadLine());
            float volumeCalculated = vol(radiusInput, heightInput);
            Console.WriteLine("The VOLUME of your cylinder is: ");
            Console.WriteLine(volumeCalculated);
            float areaCalculated = area(radiusInput, heightInput);
            Console.WriteLine("The AREA of your cylinder is: ");
            Console.WriteLine(areaCalculated);
        }
    }
}
