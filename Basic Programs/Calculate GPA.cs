using System;  
class Program  
{   static void Main()   
    {  
      double English, Hindi, Maths, Science, SocialStudy, CGPA, CGPAper ;  // direct value input could be changed to user input 
  
                  English = 9.1;  
                  Hindi = 8.5;  
                  Maths = 9.5;  
                  Science =9.6;  
                  SocialStudy = 8.6;  
                  CGPA = (9.1+8.5+9.5+9.6+8.6)/(5.0);  
                  CGPAper = (float)(9.5 * (CGPA));  
  
        Console.WriteLine("CGPA percentage is:"+CGPAper);  
    }  
}  
