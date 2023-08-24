namespace DatabaseNumberGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Returning path for special folder Documents
            string DocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            /// Rows of random numbers to write to table
            int NumberOfRows = 1000000;

            Random Random = new Random();

            /// Using class StreamWriter to output to a text file in specified path
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(DocPath, "SQLNumbers.txt"))) {
                for (int i = 1; i < NumberOfRows + 1; i++)
                {
                    outputFile.WriteLine($"{i}, {Random.Next(1, 9999)}"); // Comma delimiter for row values
                }
            }

            Console.WriteLine($"{NumberOfRows} row inserts have been written to {DocPath}");
            Console.ReadKey();
        }
    }
}