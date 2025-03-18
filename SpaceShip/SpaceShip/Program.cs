namespace SpaceShip
{
    internal class Program
    {
        public static float popGrowth(float population, float growth)
        {
            const float timeSpan = 30;
            float growthPercentage = (growth / 100);
            for (int i = 0; i <= timeSpan; i++)
            {
                population += population * growthPercentage;
            }
            return population;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current population of your country: ");
            float populationInput = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the yearly percentage population growth of your country using the following formatting (2,5): ");
            float growthInput = float.Parse(Console.ReadLine());
            float countryGrowthCalculated = popGrowth(populationInput, growthInput);
            Console.WriteLine($"In 30 years the population of your country will reach: {countryGrowthCalculated} given the growth rate is consistant");
        }
    }
}