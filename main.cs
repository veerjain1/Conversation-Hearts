using System;
using System.Threading;

class Program {
  public static void Main (string[] args) {//MAIN FUNCTION

    string checker = "yes";

    while(checker == "yes")
    {

    Console.ForegroundColor = ConsoleColor.Red;//CHANGES FOREGROUND TO RED
    Random rng = new Random();//SETUP THE RANDOM NUMBER GENERATOR
    Console.WriteLine("Welcome to the Conversation Hearts Program! To have a message for your significant other, first fill in some information... Click Enter to begin.");//WELCOME MESSAGE
    Console.ReadLine();//FOR USER INTERFACE FOR USER TO CLICK ENTER TO PROCEEED

    Console.WriteLine("Pleas enter your name here");//ASK FOR THE USERS NAME
    string userN = Console.ReadLine();//SAVES THE USER INPUT

    Console.WriteLine("Pleas enter your valentine's name here");//ASK FOR THEIR SIGNIFICANT OTHERS NAME
    string userV = Console.ReadLine();//SAVE THEIR INPUT

    int num = rng.Next(1, 3);// RANDOMLY GENERATE A NUMBER BETWEEN 1-3 (INCLUSIVE) AND SAVE THE NUUMBER
    if(num ==1)//IF THE NUMBER GENERATED IS 1, CALL THE FIRST FUNCTION
    {
      Console.WriteLine(Val1(userN, userV));
    }
  if(num ==2)//IF THE NUMBER GENERATED IS 2, CALL THE 2ND FUNCTION
    {
      Console.WriteLine(Val2(userN, userV));
    }
  if(num ==3)// IF THE NUMBER GENERATED IS 3, CALL THE 3RD FUNCTION
    {
      Console.WriteLine(Val3(userN, userV));
    }
  Thread.Sleep(3000);//AFTER PRINTING ONE OF THE FIRST THE MESSAGES, TO KEEP USER INTERFACE FRIENDLY, WAIT 3 SECONDS TO PRINT THE NEXT MESSAGE
    Console.ForegroundColor = ConsoleColor.DarkRed;//CHANGE THE NEXT MESSAGE COLOR TO DARK RED
    num = rng.Next(4, 7);// RANDOMLY GENERATE ANOTHER NUMBER BETWEEN 4 AND 7, INCLUSIVE. 
    if(num ==4)// IF THE NUMBER GENERATED IS 4, PRINT THE 4TH FUNCTION
    {
      Console.WriteLine(Val4(userN, userV));
    }
    if(num ==5)// IF THE NUMBER GENERATED IS 5, PRINT THE 5TH FUNCTION
    {
      Console.WriteLine(Val5(userN, userV));
    }
    if(num ==6)// IF THE NUMBER GENERATED IS 6, PRINT THE 6TH FUNCTION
    {
      Console.WriteLine(Val6(userN, userV));
    }
    if(num ==7)// IF THE NUMBER GENERATED IS 7, PRINT THE 7TH FUNCTION
    {
      Console.WriteLine(Val7(userN, userV));
    }
   Thread.Sleep(3000);//AFTER PRINTING ONE OF THE FIRST THE MESSAGES, TO KEEP USER INTERFACE FRIENDLY, WAIT 3 SECONDS TO PRINT THE NEXT MESSAGE
    Console.ForegroundColor = ConsoleColor.Magenta;//CHANGE THE NEXT MESSAGE COLOR TO MAGENTA

    num = rng.Next(8, 10);// RANDOMLY GENERATE ANOTHER NUMBER BETWEEN 8 AND 10, INCLUSIVE. 
    if(num ==8)// IF THE NUMBER GENERATED IS 8, PRINT THE 8TH FUNCTION
    {
      Console.WriteLine(Val8(userN, userV));
    }
    if(num ==9)// IF THE NUMBER GENERATED IS 9, PRINT THE 9TH FUNCTION
    {
      Console.WriteLine(Val9(userN, userV));
    }
    if(num ==10)// IF THE NUMBER GENERATED IS 10, PRINT THE 10TH FUNCTION
    {
      Console.WriteLine(Val10(userN, userV));
    }
  Thread.Sleep(3000);//AFTER PRINTING ONE OF THE FIRST THE MESSAGES, TO KEEP USER INTERFACE FRIENDLY, WAIT 3 SECONDS TO PRINT THE NEXT MESSAGE

      Console.WriteLine("Want to play again? Type 'yes' or 'no' ");
      checker = Console.ReadLine();

    }
    Console.ForegroundColor = ConsoleColor.Cyan;//CHANGE THE NEXT MESSAGE COLOR TO CYAN
    Sig();//RUN THE SIGNATURE FUNCTION TO END THE PROGRAM
  
  
    

  }

  static string Val1( string userN, string userV)//CREATE 1ST FUNCTION WHICH HAS A RETURN VALUE OF A STRING, AND TAKES TO PARAMETERS, THE USERS NAME, AND THEY VALENTINES NAME
  {
     string v1 = (@"       ________           ________
     /  ______  \       /  ______  \
   /  /        \  \   /  /        \  \
 /  /            \     /            \  \
|  |               \ /               |  |
|  |                                 |  |
|  |                                 |  |
 |  |                                |  |
        Happy Valentines Day "+userV+@"  
    |  |                         |  |
      |  |                     |  |
        |  |                 |  |
          |  |             |  |
            |  |         |  |
              |  |     |  |
                |  | |  |
                  | | |
                   | |
                    |

------------------------------------------------
");

return v1;
    
  }

static string Val2( string userN, string userV)//CREATE 2ND FUNCTION WHICH HAS A RETURN VALUE OF A STRING, AND TAKES TO PARAMETERS, THE USERS NAME, AND THEY VALENTINES NAME
  {
     string v2 = (@"       ________           ________
     /  ______  \       /  ______  \
   /  /        \  \   /  /        \  \
 /  /            \     /            \  \
|  |               \ /               |  |
|  |                                 |  |
|  |                                 |  |
 |  |                                |  |
           Happy "+userV+ @" Day   
    |  |                         |  |
      |  |                     |  |
        |  |                 |  |
          |  |             |  |
            |  |         |  |
              |  |     |  |
                |  | |  |
                  | | |
                   | |
                    |

------------------------------------------------
");

return v2;
    
  }

  static string Val3( string userN, string userV)//CREATE 3RD FUNCTION WHICH HAS A RETURN VALUE OF A STRING, AND TAKES TO PARAMETERS, THE USERS NAME, AND THEY VALENTINES NAME
  {
     string v3 = (@"       ________           ________
     /  ______  \       /  ______  \
   /  /        \  \   /  /        \  \
 /  /            \     /            \  \
|  |               \ /               |  |
|  |                                 |  |
|  |                                 |  |
 |  |                                |  |
          Dear, "+userV+@" baby,    
    |  |                         |  |
      |  |                     |  |
        |  |                 |  |
          |  |             |  |
            |  |         |  |
              |  |     |  |
                |  | |  |
                  | | |
                   | |
                    |

------------------------------------------------
");

return v3;
    
  }

  static string Val4( string userN, string userV)//CREATE 4TH FUNCTION WHICH HAS A RETURN VALUE OF A STRING, AND TAKES TO PARAMETERS, THE USERS NAME, AND THEY VALENTINES NAME
  {
     string v4 = (@"       ________           ________
     /  ______  \       /  ______  \
   /  /        \  \   /  /        \  \
 /  /            \     /            \  \
|  |               \ /               |  |
|  |                                 |  |
|  |                                 |  |
 |  |                                |  |
        You are my everything...    
    |  |                         |  |
      |  |                     |  |
        |  |                 |  |
          |  |             |  |
            |  |         |  |
              |  |     |  |
                |  | |  |
                  | | |
                   | |
                    |

------------------------------------------------
");

return v4;
    
  }
static string Val5( string userN, string userV)//CREATE 5TH FUNCTION WHICH HAS A RETURN VALUE OF A STRING, AND TAKES TO PARAMETERS, THE USERS NAME, AND THEY VALENTINES NAME
  {
     string v5 = (@"       ________           ________
     /  ______  \       /  ______  \
   /  /        \  \   /  /        \  \
 /  /            \     /            \  \
|  |               \ /               |  |
|  |                                 |  |
|  |                                 |  |
 |  |                                |  |
        You mean the world to me...    
    |  |                         |  |
      |  |                     |  |
        |  |                 |  |
          |  |             |  |
            |  |         |  |
              |  |     |  |
                |  | |  |
                  | | |
                   | |
                    |

------------------------------------------------
");

return v5;
    
  }

  static string Val6( string userN, string userV)//CREATE 6TH FUNCTION WHICH HAS A RETURN VALUE OF A STRING, AND TAKES TO PARAMETERS, THE USERS NAME, AND THEY VALENTINES NAME
  {
     string v6 = (@"       ________           ________
     /  ______  \       /  ______  \
   /  /        \  \   /  /        \  \
 /  /            \     /            \  \
|  |               \ /               |  |
|  |                                 |  |
|  |                                 |  |
 |  |                                |  |
        I think about you every day...    
    |  |                         |  |
      |  |                     |  |
        |  |                 |  |
          |  |             |  |
            |  |         |  |
              |  |     |  |
                |  | |  |
                  | | |
                   | |
                    |

------------------------------------------------
");

return v6;
    
  }

  static string Val7( string userN, string userV)//CREATE 7TH FUNCTION WHICH HAS A RETURN VALUE OF A STRING, AND TAKES TO PARAMETERS, THE USERS NAME, AND THEY VALENTINES NAME
  {
     string v7 = (@"       ________           ________
     /  ______  \       /  ______  \
   /  /        \  \   /  /        \  \
 /  /            \     /            \  \
|  |               \ /               |  |
|  |                                 |  |
|  |                                 |  |
 |  |                                |  |
              I miss you...    
    |  |                         |  |
      |  |                     |  |
        |  |                 |  |
          |  |             |  |
            |  |         |  |
              |  |     |  |
                |  | |  |
                  | | |
                   | |
                    |

------------------------------------------------
");

return v7;
    
  }

   static string Val8( string userN, string userV)//CREATE 8TH FUNCTION WHICH HAS A RETURN VALUE OF A STRING, AND TAKES TO PARAMETERS, THE USERS NAME, AND THEY VALENTINES NAME
  {
     string v8 = (@"       ________           ________
     /  ______  \       /  ______  \
   /  /        \  \   /  /        \  \
 /  /            \     /            \  \
|  |               \ /               |  |
|  |                                 |  |
|  |                                 |  |
 |  |                                |  |
              Love, "+userN+@"    
    |  |                         |  |
      |  |                     |  |
        |  |                 |  |
          |  |             |  |
            |  |         |  |
              |  |     |  |
                |  | |  |
                  | | |
                   | |
                    |

------------------------------------------------
");

return v8;
    
  }
  static string Val9( string userN, string userV)//CREATE 9TH FUNCTION WHICH HAS A RETURN VALUE OF A STRING, AND TAKES TO PARAMETERS, THE USERS NAME, AND THEY VALENTINES NAME
  {
     string v9 = (@"       ________           ________
     /  ______  \       /  ______  \
   /  /        \  \   /  /        \  \
 /  /            \     /            \  \
|  |               \ /               |  |
|  |                                 |  |
|  |                                 |  |
 |  |                                |  |
          Your lover, "+userN+@"    
    |  |                         |  |
      |  |                     |  |
        |  |                 |  |
          |  |             |  |
            |  |         |  |
              |  |     |  |
                |  | |  |
                  | | |
                   | |
                    |

------------------------------------------------
");

return v9;
    
  }

    static string Val10( string userN, string userV)//CREATE 10TH FUNCTION WHICH HAS A RETURN VALUE OF A STRING, AND TAKES TO PARAMETERS, THE USERS NAME, AND THEY VALENTINES NAME
  {
     string v10 = (@"       ________           ________
     /  ______  \       /  ______  \
   /  /        \  \   /  /        \  \
 /  /            \     /            \  \
|  |               \ /               |  |
|  |                                 |  |
|  |                                 |  |
 |  |                                |  |
         Your secret admirer "+userN+@"    
    |  |                         |  |
      |  |                     |  |
        |  |                 |  |
          |  |             |  |
            |  |         |  |
              |  |     |  |
                |  | |  |
                  | | |
                   | |
                    |

------------------------------------------------
");

return v10;
    
  }

  static void Sig()//CREATING A VOID FUNCTION WHICH DOES NOT RETURN ANYTHING TO THE MAIN FUNCTION, DOES NOT TAKE ANY PARAMETERS, JUST PRINTS A SIGNATURE TO INDICATE THE PROGRAM HAS ENDED AND WAS CREATED BY VEER
  {
    Console.WriteLine(@"   _..._  ,s$$$s.
 VEERJAI.   RJAINVE
 VEERJAINV . ERJAINVE
 VEERJAINVEERJAINVE
 VEERJAINVEERJAINVE
  VEERJAINVEERJAIN
    VEERJAINVEERJ
     VEERJAINVEE
       VEERJAI
        VEERJ
          ;
         ;
         ;
         ',
          ;
         ,'
         ;
         ',
          ',
           ;
          '
Veer Was Here...

------------------------------------------------

");
  }


  



  


}