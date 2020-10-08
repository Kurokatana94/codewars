using System;

public class Kata
{
  public static double Index(int[] array, int n)
  {
    if(n>array.Length-1) return -1;
    else return Math.Pow(array[n],n);
  }
}
