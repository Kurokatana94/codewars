public class Kata
{
  public static string Rot13(string message)
  {
    string alphabet = "abcdefghijklmnopqrstuvwxyz";
    string caps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string result = "";
    for (int i=0;i<message.Length;i++){
      if(alphabet.Contains(message[i])){
        for(int j=0;j<alphabet.Length;j++){
          if(alphabet[j]==message[i]){
            if(j+13>alphabet.Length-1) result += alphabet[(j+13)-alphabet.Length];
            else result += alphabet[j+13];
           }
        }
      }else if(caps.Contains(message[i])){
        for(int j=0;j<caps.Length;j++){
          if(caps[j]==message[i]){
            if(j+13>caps.Length-1) result += caps[(j+13)-caps.Length];
            else result += caps[j+13];
          }
        }
      }else result += message[i];
    }
    return result;
  }
}
