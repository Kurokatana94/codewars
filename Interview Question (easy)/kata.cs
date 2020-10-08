using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
    public static string GetStrings(string city)
    {
      var list = new List<string>();
      city = city.ToLower();
      string newString = "";
      for(int i=0; i<city.Length;i++){
        if(city[i] == ' ') continue;
        else if(Kata.CheckInString(list, city[i] + ":*") == false){
          list.Add(city[i] + ":*");
        }
        else{
          for(int j=0;j<list.Count;j++){
            if(list[j].Contains(city[i])){
              list[j] += "*";
            }
          }
        }
      }
      for(int i=0;i<list.Count;i++){
        if(i<list.Count-1) newString += list[i] + ",";
        else newString += list[i];
      }
      return newString;
    }
  public static bool CheckInString(List<string> list, string str){
    for(int i = 0;i<list.Count;i++){
      if(list[i].Contains(str)) return true;
    }
    return false;
  }
}
