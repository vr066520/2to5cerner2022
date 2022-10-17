
using System; 
    
public class GFG{ 
      
    // cerner_2^5_2022 
    static int getdays(int year, int month)  
    { 
        int days = DateTime.DaysInMonth(year, month);
          
        return days;
    } 
      
    static public void Main () 
    {  
        int Y = 2020; 
        int M = 07; 
          
        Console.WriteLine("Total days in ("
        + Y + "/" + M + ") : "+ getdays(Y, M)); 
    }  
}
