using System;

public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    { 
        //Moment of truth...
      if ((flower1 + flower2) % 2 == 1)
        {
        return true;
        }
      else 
        {
          return false;
        }
    }
}