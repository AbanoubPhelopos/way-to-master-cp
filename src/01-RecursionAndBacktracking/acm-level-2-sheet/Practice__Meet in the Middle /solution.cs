int[] input = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int n = input[0];
int sum = input[1];

// Storing items as (weight, value)
long[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);


int mid = n / 2;
List<long> leftSums = new List<long>();
List<long> rightSums = new List<long>();

// Generate all subset sums for both halves
GenerateSums(0, mid, 0, arr, leftSums);
GenerateSums(mid, n, 0, arr, rightSums);

// Sort the right sums to allow binary searching / sorting mechanics
rightSums.Sort();

long totalWays = 0;

// For each sum in the left half, count matching complements in the right half
foreach (long s in leftSums)
{
    long complement = sum - s;
    totalWays += CountOccurrences(rightSums, complement);
}

Console.WriteLine(totalWays);

void GenerateSums(int index, int end, long currentSum, long[] arr, List<long> sums)
{
    if (index == end)
    {
        sums.Add(currentSum);
        return;
    }
    // Choice 1: Leave the element
    GenerateSums(index + 1, end, currentSum, arr, sums);
    // Choice 2: Take the element
    GenerateSums(index + 1, end, currentSum + arr[index], arr, sums);
}

// Binary search helper to find the exact count of a target value in a sorted list
int CountOccurrences(List<long> list, long target)
{
    int first = LowerBound(list, target);
    if (first == list.Count || list[first] != target) return 0;

    int last = UpperBound(list, target);
    return last - first;
}

int LowerBound(List<long> list, long target)
{
    int low = 0, high = list.Count;
    while (low < high)
    {
        int mid = low + (high - low) / 2;
        if (list[mid] >= target) high = mid;
        else low = mid + 1;
    }
    return low;
}

int UpperBound(List<long> list, long target)
{
    int low = 0, high = list.Count;
    while (low < high)
    {
        int mid = low + (high - low) / 2;
        if (list[mid] > target) high = mid;
        else low = mid + 1;
    }
    return low;
}