public class Kata
{
  public static string DuplicateEncode(string word)
  {
    string newWord = "";
    for(int i=0;i<word.Length;i++){
      int n = 0;
      for(int j=0;j<word.Length;j++){
        if(char.ToLower(word[i]) == char.ToLower(word[j])) n++;
      }
      if(n>1)newWord+=")";
      else newWord+="(";
    }
    return newWord;
  }
}
