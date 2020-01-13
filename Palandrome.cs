using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingChallege1
{
 class Palandrome
    {
       string teststring ="";
        public Palandrome(string teststring)
        {
            teststring.Replace(" ", "");
            
            this.teststring = teststring.ToLower();


        }
        public bool TestPalandrome()
        {
            teststring.ToLower();
            for (int i = 0; i < teststring.Length/2; i++) {
                if (teststring[i] != teststring[teststring.Length - i - 1]){
                    return false;
                }

            }
            return true;
        }
    }
}
