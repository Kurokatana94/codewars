using System;
using System.Collections.Generic;
namespace CodeWars
{
    public class Kata
    {
        public List<string> wave(string str)
        {
          string result = "";
          var list = new List<string>();
          for(int i=0; i<str.Length;i++){
            while(str[i]==' '){
              if(str[i] == ' ' && i==str.Length-1) break;
              i++;
              }
            if(str[i] == ' ' && i==str.Length-1) break;
            for(int j=0;j<str.Length;j++){
              if(j!=i) result+=str[j];
              else result += char.ToUpper(str[i]);
            }
            list.Add(result);
            result = "";
          }
          return list;
        }
    }
}
