internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int arrSize = Convert.ToInt32(Console.ReadLine());
        string arrIntegers = Console.ReadLine();
        int[] arr = arrIntegers.Split(' ').Select(int.Parse).ToArray();
        int queries = Convert.ToInt32(Console.ReadLine());
        FrequencyPoint[] frequencies = new FrequencyPoint[queries];
        for (int i = 0; i < queries; i++) {
            int[] lines = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            frequencies[i] = new FrequencyPoint{ Start = lines[0], End = lines[1] };
        }
        Dictionary<int, int> occurances = new Dictionary<int, int>();
        for (int i = 0;i < arr.Length;i++)
        {
            if (occurances.ContainsKey(arr[i]))
                occurances[arr[i]] = occurances[arr[i]] + 1;
            else
                occurances.Add(arr[i], 1);
        }

        for (int i = 0; i< frequencies.Length; i++)
        {
            int sum = 0;
            foreach (var item in occurances)
            {
                if (item.Value >= frequencies[i].Start && item.Value <= frequencies[i].End)
                    sum += item.Key * item.Value;
            }
            Console.WriteLine(sum);
        }
    }
}

class FrequencyPoint
{
    public int Start { get; set; }
    public int End { get; set; }
}