using System;

public class Kata
{
  public static string GetTurkishNumber(int num)
  {
    string numString = num.ToString();
    string newString = "";
    if(numString.Length>1){
      switch(numString[0]){
        case '1':
          newString += "on";
          break;
        case '2':
          newString += "yirmi";
          break;
        case '3':
          newString += "otuz";
          break;
        case '4':
          newString += "kırk";
          break;
        case '5':
          newString += "elli";
          break;
        case '6':
          newString += "altmış";
          break;
        case '7':
          newString += "yetmiş";
          break;
        case '8':
          newString += "seksen";
          break;
        case '9':
          newString += "doksan";
          break;
          
      }
      switch(numString[1]){
        case '1':
          newString += " bir";
          break;
        case '2':
          newString += " iki";
          break;
        case '3':
          newString += " üç";
          break;
        case '4':
          newString += " dört";
          break;
        case '5':
          newString += " beş";
          break;
        case '6':
          newString += " altı";
          break;
        case '7':
          newString += " yedi";
          break;
        case '8':
          newString += " sekiz";
          break;
        case '9':
          newString += " dokuz";
          break;
        }
    }else{
      switch(numString){
        case "0":
          newString += "sıfır";
          break;
        case "1":
          newString += "bir";
          break;
        case "2":
          newString += "iki";
          break;
        case "3":
          newString += "üç";
          break;
        case "4":
          newString += "dört";
          break;
        case "5":
          newString += "beş";
          break;
        case "6":
          newString += "altı";
          break;
        case "7":
          newString += "yedi";
          break;
        case "8":
          newString += "sekiz";
          break;
        case "9":
          newString += "dokuz";
          break;
      }
    }
    return newString;
  }
}
