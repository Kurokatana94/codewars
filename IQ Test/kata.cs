using System;
using System.Linq;
using System.Collections.Generic;

public class IQ
    {
        public static int Test(string numbers)
        { 
          var numList = new List<int>();
          int evenCounter = 0;
          int oddCounter = 0;
          int firstOdd = 0;
          int firstEven = 0;
          string toTranslate = "";
          
          for(int i=0;i<numbers.Length;i++){
            if(numbers[i] != ' ')
              if(i < numbers.Length - 1 && numbers[i+1] != ' ')
                toTranslate = numbers[i].ToString() + numbers[i+1].ToString();
              else numList.Add(int.Parse(numbers[i].ToString()));
          }
          
          for(int i=0; i<numList.Count;i++){
            if(numList[i]%2 != 0){
              oddCounter++;
              if(oddCounter == 1) firstOdd = (i+1);                
            }else{
              evenCounter++;
              if(evenCounter == 1) firstEven = (i+1);
            }
          }
          
          if(evenCounter > oddCounter) return firstOdd;
          else return firstEven;
        }
    }
