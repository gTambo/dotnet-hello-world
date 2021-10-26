
using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    // Your code here
    int positiveSum = 0;
    
    foreach (int i in arr)
      {
      
        if( i > 0)
          {
          
            positiveSum += i;
          
          }
      
      }
    
    return positiveSum;
  }
}