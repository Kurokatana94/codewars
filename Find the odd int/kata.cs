namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
      int res = 0;
        for(int i=0;i<seq.Length;i++){
          int n=0;
          for(int j=0;j<seq.Length;j++){
            if(seq[i]==seq[j]) n++;
          }
          if(n%2!=0) {
            res = seq[i];
            break;
          }
        }
        return res;
      }
    }
}
