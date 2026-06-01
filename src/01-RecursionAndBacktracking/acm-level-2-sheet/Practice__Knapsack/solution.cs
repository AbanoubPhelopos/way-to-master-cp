int[] input = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int n = input[0];
int w = input[1];

// Storing items as (weight, value)
List<KeyValuePair<int, int>> arr = new List<KeyValuePair<int, int>>();
for (int i = 0; i < n; i++)
{
    input = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    arr.Add(new KeyValuePair<int, int>(input[0], input[1]));
}

int ans = Knapsack(0, w);
Console.WriteLine(ans);

int Knapsack(int index, int remaining_weight)
{
    // Base case: no more items left to consider
    if (index >= n)
    {
        return 0;
    }

    // Option 1: Leave the current item
    int leave = Knapsack(index + 1, remaining_weight);

    // Option 2: Take the current item (only if it fits)
    int take = 0;
    if (arr[index].Key <= remaining_weight)
    {
        take = arr[index].Value + Knapsack(index + 1, remaining_weight - arr[index].Key);
    }

    return Math.Max(take, leave);
}