using System;


public static class JadenCase
{
  public static string ToJadenCase(this string phrase)
  {
    bool isLastSpace = true;
    string lowerPhrase = phrase.ToLower();
    string newPhrase = "";
    for(int i=0;i<lowerPhrase.Length;i++){
      if(lowerPhrase[i] == ' ') {
        isLastSpace = true;
        newPhrase += " ";
      }
      else if(lowerPhrase[i] != ' ' && isLastSpace == true){
        newPhrase += char.ToUpper(lowerPhrase[i]);
        isLastSpace = false;
      }else newPhrase += lowerPhrase[i];
    }
    return newPhrase;
  }
}
