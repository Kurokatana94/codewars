public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
      int counter = 0;
      bool isGood = false;
      foreach(char ch in input){
        if(ch == '(') counter++;
        else if(ch == ')')counter--;
        else continue;
        if (counter < 0){
          isGood = false;
          break;
        }
        }
      if(counter == 0){
        isGood = true;    
      }
      return isGood;
    }
}
