internal class Program
{
    private static void Main(string[] args)
    {
        string firstLine = Console.ReadLine();
        int[] arr = firstLine.Split(' ').Select(int.Parse).ToArray();
        int numberOfQuestions = arr[0];
        int maxDifficulty = arr[1];

        string questionsStr = Console.ReadLine();
        int[] questions = questionsStr.Split(' ').Select(int.Parse).ToArray();

        int attemptedQusetions = 0;
        int skippedCount = 0;

        for (int i = 0; i < numberOfQuestions; i++)
        {
            if (questions[i] > maxDifficulty && skippedCount < 2)
            {
                skippedCount++;
                if (skippedCount == 2) break;
            }
            else
            {
                attemptedQusetions++;
            }
        }

        Console.WriteLine(attemptedQusetions.ToString());
    }
}