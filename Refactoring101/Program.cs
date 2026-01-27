namespace Refactoring101
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            //new DuplicateCode().Run();

            Console.WriteLine("Refactoring 101");
            Console.WriteLine();

            Console.WriteLine("2. Duplicate Code");
            new QuestionsAndAnswers().Print();

            Console.WriteLine("3. Shotgun Surgery");
            new QuestionsAndAnswers.Shotgun1().DisplayStudents();
            new QuestionsAndAnswers.Shotgun2().PrintTotal();
            Console.WriteLine();

            Console.WriteLine("4. Data Clumps and 5. Feature Envy");
            new QuestionsAndAnswers().PrintDate(new QuestionsAndAnswers.Date
            {
                Day = 15,
                Month = 8,
                Year = 2024
            });
            Console.WriteLine();

            Console.WriteLine("End of Refactoring101");
        }
    }
}
