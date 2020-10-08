public class Kata
{
    public static string Shark(
      float pontoonDistance, 
      float sharkDistance, 
      float yourSpeed, 
      float sharkSpeed, 
      bool dolphin)
    {
        if(dolphin){
          if(sharkDistance/(sharkSpeed/2) > pontoonDistance/yourSpeed) return"Alive!";
          else return "Shark Bait!";
        }else{
          if(sharkDistance/sharkSpeed > pontoonDistance/yourSpeed) return"Alive!";
          else return "Shark Bait!";
        }
    }
}
