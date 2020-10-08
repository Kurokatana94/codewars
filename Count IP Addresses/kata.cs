using System;
public class CountIPAddresses
{
   public static long IpsBetween(string start, string end)
   {
     string[] firstIPs = start.Split('.', StringSplitOptions.RemoveEmptyEntries);
     string[] secondIPs = end.Split('.', StringSplitOptions.RemoveEmptyEntries);
     int[] firstIPn = Array.ConvertAll(firstIPs, s => int.Parse(s));
     int[] secondIPn = Array.ConvertAll(secondIPs, x => int.Parse(x));
     long first = Convert.ToInt64(firstIPn[0]*Math.Pow(2,24) + firstIPn[1]*Math.Pow(2,16) + firstIPn[2]*Math.Pow(2,8) + firstIPn[3]);
     long result = Convert.ToInt64(secondIPn[0]*Math.Pow(2,24)+secondIPn[1]*Math.Pow(2,16)+secondIPn[2]*Math.Pow(2,8)+secondIPn[3]);
     return result -= first;
   }
}
