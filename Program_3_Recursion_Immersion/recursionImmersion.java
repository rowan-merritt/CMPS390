// Use this editor to write, compile and run your Java code online
/* 
Write iterative and recursive functions for the summation of a number.  
Show your code and screenshots of it running.  
Put it all in a .pdf and submit it in moodle.  
Due March 6.
*/

package Program_3_Recursion_Immersion;
import java.util.Scanner;

public class recursionImmersion {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        boolean complete = false;
        int counter = 0;
        
        while (!complete) { // I wanted to check multiple times without having to run again
            if (counter == 0){
            System.out.println("Would you like to use iterative and recursive functions for the summation of a number? "); // giving the user a choice to continue summations or stop
            }
            else{
                System.out.println("Continue?");
            }
			System.out.println("\t1) Yes.");
			System.out.println("\t2) Nope.");
			
			double pick = input.nextDouble(); // taking in the user's choice
			
			if (pick == 1) {
			    System.out.print("Enter a number: "); //Prompting the user to input a value, and... 
                int userInput = input.nextInt(); // ... taking in their value
			    if (userInput < 0) {
                System.out.print("Only use positive numbers. Try again. \n");
                }
                else {
            
                    System.out.print("The summation of " + userInput + " using a recursive function is " + recursive(userInput)+ "\n");
                    System.out.print("The summation of " + userInput + " using a iterative function is " + iterative(userInput) + "\n");
                    System.out.println();
                }
            }
            
            if (pick == 2) {
                System.out.print("Goodbye");
                complete = true;
            }
            
            counter++;
        } // end while
        input.close();
    } // end of main
    
    public static int recursive(int num){
        if(num == 1){ // using a recursive function on 1 would just result in 1.
            return 1; 
        }
        else{
            return (num * recursive(num - 1)); // multiply the num with the value of your called recursive value of the number below it, e.i   4 * recursive(3)
        }
    } // end of recursive
    
    public static int iterative(int x){
        int factorial = 1; // can't go lower than 1 when using iterative or recursive functions, that just wouldn't make sense
        
        for (int j = 1; j <= x; j++) { 
            factorial = factorial * j; 
        }
        return factorial;
    } // end of iterative
    
} // end of recursionImmersion