namespace DNA
{
    internal class Program
    {
        /// <summary>
        ///  Enum created which includes the four base elements in a DNA string.
        ///  This is to be used later in the two arrays we must compare with
        ///  one another to find the hamming-distance.
        /// </summary>
        public enum bases 
        {
            A, T, C, G
        };


        /// <summary>
        /// initializes a counter for meassuring the hamming distance
        /// </summary>
        public static int HammingDistance(bases[] arrayX, bases[] arrayY)
        {

            
            int distance = 0; 
            for (int i = 0; i < arrayX.Length; i++)
            {
                if (arrayX[i] != arrayY[i]) // Compares each index to check if the value stored under each index are identical
                {
                    distance++; // Increase count if bases are different
                }
            }

            return distance; // Return total hamming distance
        }

        /// <summary>
        /// Two arrays are created. One being the "Original (array1)" which the clone (array2) needs to be compared with.
        /// By comparing the clone with the Original we will find the hamming-distance.
        /// </summary>
        /// <param name="array1">The first DNA sequence eg. the original</param>
        /// <param name="array2">The clone which is to be compared with the original</param>
        /// 
        /// <summary>
        /// Calls the HammingDistance method to calculate the difference between two DNA sequences.
        /// Stores the result in the 'distance' variable.
        /// </summary>
        /// 
        /// <summary>
        /// Outputs the calculated Hamming Distance to the console, indicating how many positions differ between the two DNA sequences.
        /// </summary>
        static void Main(string[] args)
        {
            bases[] DNA1 = new bases[10] {bases.A, bases.T, bases.C, bases.G, bases.G, bases.C, bases.T, bases.C, bases.G, bases.A };
            bases[] DNA2 = new bases[10] { bases.A, bases.C, bases.C, bases.G, bases.G, bases.T, bases.T, bases.C, bases.G, bases.T };


            int distance = HammingDistance(DNA1, DNA2);

            Console.WriteLine("Calculating Hamming-distance of following DNA sequences:");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A T C G G C T C G A");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(500);
            Console.WriteLine("A C C G G T T C G T");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1000);
            Console.WriteLine($"The Hamming-Distance is {distance}");
            Console.WriteLine($"{DNA1.ToString}");
        }
    }
}
