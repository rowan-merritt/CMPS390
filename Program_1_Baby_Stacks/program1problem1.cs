/******************************************************************************

1. Implement the basic methods of the stack in procedural code. Set the stack up 
   so that it can work with characters. Use the push and pop methods to load and 
   unload the following strings from the stack, print out the results. 
        a. “bob”
        b. “aet nomel”
        c. “snoino dna revil etah I”
        d. “SELUR LOBOC”

*******************************************************************************/

#include <iostream>
#include <stdio.h>
#include <string>


    
class Stack{
    char* s; // initializing a memory pointer for char s
    int top; // declaring int top for the top of the stack
    int size; // declaring int size that is used in different methods 
    
public:
    Stack(int stackSize = 50){ // creating a method of the same name as the class
        size = stackSize; // changing the value of size; should change the size used in methods isStackEmpty/Full as well
        s = new char[size]; // referencing char s in declaring a char at position of the size value
        top = -1; // declaring that the top  
    }
    
    bool isStackEmpty() { // this is a bool so it can either be true or false, meaning I don't need an if statement to change its value
        return (top == -1); // if the top == -1 then there is nothing left to remove from the stack
    } 
    
    bool isStackFull() { // checking if the stack is full
        return (top == size - 1); //
    } 
    
    void push(char c){ // take in a char as the parameter
        if (!isStackFull()) { // when the stack is not full we want to...
            top++; // increase the position of top and
            s[top] = c; // change the value of our string at the position of top to our parameter
        }
        else {
            std::cout << "Woomp woomp"; // so we know that it didn't work
        }
    } // end push()
    
    char pop(){ 
        if (!isStackEmpty()) { // when the stack isn't full we want to "pop" 
            char c = s[top]; // the char value at the top of the stack through...
            top--; //... reducing its current position
            return c; // give us the popped char
        }
        else {
            std::cout << "Woomp woomp"; // so we know that it didn't work
            return 0; // complier said I needed to return something
        }
    } // end pop()
    
    void showStack(){ // gotten from the notes
        for (int j = 0; j <= top; j++) { // loop to help with looking through every value in a stack
            std::cout << s[j];
        } 
    } // end showStack()
    
    void decode(std::string s) {
        std::cout << "The result of pushing and popping the string '" << s << "' is: ";
        
        for (int j = 0; j < s.length(); ++j) {
            char c = s[j]; // "c = s.charAt(j);" wasn't working but reading the 
            push(c); // reaching the push method to push our current char
        }
        
        while(!isStackEmpty()){ // from the notes but instead of isStackEmpty() == false it's just !isStackEmpty()
            std::cout << pop(); // keep popping until there is nothing left to pop and isStackEmpty() == true
        }
        std::cout << "\n";
    } // end decode()
}; // end class

int main(){
    Stack init; // bringing in the Stack method we made
    std::string str[] = {"bob", "aet nomel", "snoino dna revil etah I", "SELUR LOBOC"}; // array storing the strings we want to push and pop; Couldn't do Scanner
    
    for (std::string &s : str) { // referencing aa str value as our variable and array s as the range
        init.decode(s); // 
    }
} // end main