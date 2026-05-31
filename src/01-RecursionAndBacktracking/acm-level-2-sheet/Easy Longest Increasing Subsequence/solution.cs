int n = int.Parse(Console.ReadLine()!);

int[] arr = new int[n];
arr = [.. Console.ReadLine()!.Split(' ').Select(int.Parse)];


int ans = longestSubSequance(0, -1);

Console.WriteLine(ans);

int longestSubSequance(int index, int prev_index)
{
    if (index >= n)
    {
        return 0;
    }
    int leave = longestSubSequance(index + 1, prev_index);

    int take = 0;
    if (prev_index == -1 || arr[index] > arr[prev_index])
    {
        take = 1 + longestSubSequance(index + 1, index);
    }

    return Math.Max(take, leave);
}
