using System;
using System.Collections.Generic;

public class Kata
{
  public static int DuplicateCount(string str){
    int res = 0;
    str = str.ToLower();
    var list = new List<char>();
    for(int i=0;i<str.Length;i++){
      int n=0;
      for(int j=0;j<str.Length;j++)
        if(str[i] == str[j] && list.Contains(str[i])==false) n++;
      if(n>1) {
        res++;
        list.Add(str[i]);
        }
    }
    return res;
  }
}
