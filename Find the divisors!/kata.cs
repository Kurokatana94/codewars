using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static int[] Divisors(int n)
  {
    List<int> l = new List<int>();
    for (int i = 2; i <= Math.Sqrt(n); i++) if (n % i == 0) l.Add(i);
    if (l.Count == 0) return null;
    List<int> k = new List<int>(Enumerable.Reverse(l.ToArray().Select(x => n / x).ToArray().Where(x => !l.Contains(x))));
    l.AddRange(k);
    Console.Write(" n="+n);
    return l.ToArray();
  }
}
