using System.Collections.Generic;
using System;
  
class MorseCodeDecoder
{
  public static string Decode(string morseCode)
  {
    var charList = new List<char>(morseCode);
    string morseChar = "";
    string sentence = "";
    int lastSpace = 0;
    int i = 0;
    foreach(char ch in charList){
      if(ch != ' '){
        morseChar = morseChar.Insert(morseChar.Length, ch.ToString());
        lastSpace = 0;
      }else if(ch == ' ' && lastSpace <= 1){
        sentence = sentence.Insert(sentence.Length, MorseCode.Get(morseChar));
        morseChar = "";      
        lastSpace++;
      }else if(ch == ' ' && lastSpace == 2){
        sentence = sentence.Insert(sentence.Length, " ");
        lastSpace = 0;
      }
      
      if(sentence == " ") sentence = "";
      
      if(ch != ' ' && i == charList.Count -1){
        sentence = sentence.Insert(sentence.Length, MorseCode.Get(morseChar));
      }
      i++;
    }  
    return sentence.ToUpper();;
  }
}
