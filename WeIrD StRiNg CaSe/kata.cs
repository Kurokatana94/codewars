using System;

public class Kata
{
  public static string ToWeirdCase(string s)
  {
    int n = 0;
    string result = "";
     for(int i=0;i<s.Length;i++){
       if(s[i] == ' ') {
         result+=s[i];
         n=0;
         continue;
        }
       else{
         n++;
         if(n%2 == 0) result += Char.ToLower(s[i]);
         else{
           result+=Char.ToUpper(s[i]);
         }
       }
     }
    return result;
  }
}
