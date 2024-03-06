package Program_3_Recursion_Immersion;
/* 
Write iterative and recursive functions for the summation of a number.  
Show your code and screenshots of it running.  
Put it all in a .pdf and submit it in moodle.  
Due March 6.
*/
#include <iostream>

int factorial(int x) {
        if(x == -1){
            return 1;
        }
        else{
            return (x*factorial(x-1)); 
        }
    }

int main(){
    factorial(3);
}