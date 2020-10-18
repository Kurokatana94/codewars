using System;
using System.Collections.Generic;
public class Josephus
{
   public static List<object> JosephusPermutation(List<object> items, int k)
   {
     Console.WriteLine(" "+k.ToString() + " " + string.Join(",", items));
     var result = new List<object>();
     int n = 0;
     int iterations=items.Count;     
     for(int i=0;i<iterations;i++){
       n+=k-1;
       while(n>=items.Count) n -= items.Count;
       Console.WriteLine(items[n]);
       result.Add(items[n]);
       items.RemoveAt(n);
       if(n==items.Count) n-=items.Count;
     }
       return result;
   }
}
