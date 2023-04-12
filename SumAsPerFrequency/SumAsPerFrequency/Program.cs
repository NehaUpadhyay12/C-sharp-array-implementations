internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int arrSize = Convert.ToInt32(Console.ReadLine());
        string arrIntegers = Console.ReadLine();
        int[] arr = arrIntegers.Split(' ').Select(int.Parse).ToArray();

        int queriesString = Convert.ToInt32(Console.ReadLine());
        FrequencyPoint[] queries = new FrequencyPoint[queriesString];
        for (int i = 0; i < queriesString; i++) {
            int[] lines = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            queries[i] = new FrequencyPoint{ Start = lines[0], End = lines[1] };
        }

        Dictionary<int, int> occurances = new Dictionary<int, int>();
        for (int i = 0;i < arr.Length;i++)
        {
            if (occurances.ContainsKey(arr[i]))
                occurances[arr[i]] = occurances[arr[i]] + 1;
            else
                occurances.Add(arr[i], 1);
        }

        for (int i = 0; i< queries.Length; i++)
        {
            int sum = 0;
            var items = occurances.Where(o => o.Value >= queries[i].Start && o.Value <= queries[i].End).Select(s => s.Key * s.Value);

            foreach (var item in items)
            {
                sum += item;
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