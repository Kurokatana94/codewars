public class Kata
{
  public static string Rgb(int r, int g, int b) 
  {
    if(r>255) r=255;
    else if(r<0) r=0;
    
    if(g>255) g=255;
    else if(g<0) g=0;
    
    if(b>255) b=255;
    else if(b<0) b=0;
    
    string result = "" + r.ToString("X2") + g.ToString("X2") + b.ToString("X2");
    return result;
  }
}
