public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
      bool isTriangle = false;
      if(a+b > c && a+c > b && b+c > a)isTriangle = true;
      else isTriangle = false;
      return isTriangle;
    }
}
