int t = int.Parse(Console.ReadLine()!);

while (t-- > 0)
{
    var parts = Console.ReadLine()!.Split();
    long n = long.Parse(parts[0]);
    long m = long.Parse(parts[1]);

    Console.WriteLine(CanMake(n, m) ? "YES" : "NO");
}

static bool CanMake(long n, long m)
{
    // Base case: we already have a pile of exactly m
    if (n == m)
        return true;

    // Pruning: can't create a pile larger than what we have,
    // and the pile must be divisible by 3 to split (one part = n/3, other = 2n/3)
    if (n < m || n % 3 != 0)
        return false;

    // Recursive case: split pile n into (n/3) and (2n/3)
    // Check if target m is reachable from either sub-pile
    return CanMake(n / 3, m) || CanMake(2 * n / 3, m);
}
