using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static string PigIt(string str)
  {
    var list = new List<string>(str.Split(" ").ToList());
    str = "";
    int n=0;
    foreach(string s in list.ToList()){
      string newString = "";
      if(n>0) newString += " ";
      for(int i=0;i<s.Length;i++){
        if(Char.IsPunctuation(s[i])) newString+=s[i];
        else if(i<s.Length-1) newString += s[i+1];
        else newString += s[0] + "ay";
      }
      n++;
      str += newString;
    }
    return str;
  }
}
