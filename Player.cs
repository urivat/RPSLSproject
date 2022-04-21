using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSproject
{
    public abstract class Player
    {   
        //member variables
        public string name;
        public int score;
        public string action;

        // constructor
        public Player(string name , int score , string gesture)
        {
            this.name = name;
            this.score = score;
            this.action = gesture;

        //member methods
        void MethodName()
            { 
                Console.WriteLine("a method to find {0}", name); 
            
            }

            
        }   
    }
}
