using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSproject
{
    public class Player
    {   
        //member variables
        public string name;
        public int score;
        public string gesture;

        // constructor
        public Player(string name , int score , string gesture)
        {
            this.name = name;
            this.score = score;
            this.gesture = gesture;

        //member methods
             public string MethodName()
            { 
                System.Console.WriteLine('a method to find {0}', name); 
            
            }
        }
    }
}
