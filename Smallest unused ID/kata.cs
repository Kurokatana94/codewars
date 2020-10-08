using System;

public class Kata
{
  public static int NextId(int[] ids)
  {
    int smallestId = 0;
    Array.Sort(ids);
    for(int i=0; i<ids.Length+1;i++){
      if(i == ids.Length){
        smallestId = i++;
        break;
      }
      if(i < ids[i]){
         smallestId = i;
         break;
      }
    }
    return smallestId;
  }
}
