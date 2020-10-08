using System;

public class Kata
{
  public static int[] SortNumbers(int[] nums)
  {
    if (nums == null || nums.Length == 0)return new int[] {};
    else Array.Sort(nums);
    return nums;
  }
}
