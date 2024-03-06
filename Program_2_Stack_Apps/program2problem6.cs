
/*
Implement the following algorithms in code using the stack and queue methods 
developed in exercises 1, 2 and 3:
    a. Parentheses/equation validation 
    b. Infix to postfix expression conversion
    c. Postfix equation evaluation
Create a text file with the following data input. 
    (5+3)
    (5+3)*8+(2)
    (5+3)*((2+4)*3))
    (((4)))
    (1/2)*(2+3)/2
    (2+3)*(8*9)/2)
    ((2+3)*((8*9)/2)
    (2+3)*((8*9)/2)

Using your programs, first do a parentheses check. If the equation passes the parentheses 
check, convert the equation to postfix, then evaluate the postfix equation.

*/

#include <iostream>
#include <string>

class CharStack{
    public: // needed so our evaluate method can access pop and push
    int top;
    char c;
    char arr[100];
    std::string string = "";

    CharStack(){
        top = -1;
    }
    void push(char ch){
        top++;
        arr[top] = ch;
    }
    char pop(){
        c = arr[top];
        top--;
        return c;
    }
    bool isStackEmpty(){
        bool answer = false;
        if(top == -1){
            answer = true;
        }
        return answer;
    }
    void showStack() {
        for(int j = 0; j <= 0; j++){
            std::cout << (arr[j]);
        }
    }
    std::string stackToString(){
        for (int q = 0; q <= 100; q++){
            string += arr[q];
        }
        return string;
    }
};

bool validate(std::string ex){ // the method that parentheses/equation validation 
    CharStack charStack; // so we can use all the methods in class CharStack (Note: to self don't set this equal to new CharStack() it broke it for some reason)
    for (char c : ex) { // declare char variable c over the range of string ex
        if (c == '(') { 
            charStack.push(c); // when we find a ( , just push it to the stack
        }
        else if (c == ')') {
            if (charStack.isStackEmpty()){
                return false;
            }
            charStack.pop();
        }
        // reminder to not put 'return charStack.isStackEmpty();' here
    }
    return charStack.isStackEmpty();
} // end of validate()

std::string convert (std::string infix){ // the method that does the infix to postfix expression conversion
    CharStack operatorStack; // so we can use stack methods on our operators seperately from the numbers
    std::string postfix; // we need a place to store our postfix
    // std::cout << infix;
    for(char c: infix) { 
        if (std::isdigit(c)) { 
            postfix += c;
        }
        else if (c == '+' || c == '-' || c == '/' || c == '*') {
            operatorStack.push(c);
        }
        else if (c == ')') { // we need to pop all that is in the operatorStack to the postfix
            postfix += operatorStack.pop();
        }
    }
    
    while(operatorStack.isStackEmpty() == false) { // need to pop the leftover operators after the last ')'
        postfix += operatorStack.pop();
    }
    return postfix; // give the postfix back to us
} // end of convert()


int evaluate(std::string postfix){ // the method that does the postfix equation evaluation
    CharStack charStack;
    int z;
    
    for(char c : postfix){ // look through each element of the postfix
        if(std::isdigit(c)){ // if the element is a number we can push it it to the stack // DO NOT USE &&
            charStack.push(c -'0');
        }
        else if (c == '+' || c == '-' || c == '/' || c == '*'){ // 
            int y = charStack.pop();
            int x = charStack.pop();
            
            // since we are doing the same thing in repition (the thing being seeing if c is = to something)we can use a switch case
            switch(c){
                case '+':
                    z = y + x;
                    break;
                case '-':
                    z = y - x;
                    break;
                case '/':
                    z = y / x;
                    break;
                case '*':
                    z = y * x;
                    break;
            } // Note: not sure if this was actually less to code, so this might be more helpfully when dealing with more cases
            charStack.push(z);
        }
    } // end for
    
    return charStack.pop(); // this is returning a postfix fix
} // end of evaluate()

int main (){
    std::string inputData[] = {
    
        "(5+3)",
        "(5+3)*8+(2)",
        "(5+3)*((2+4)*3))",
        "(1/2)*(2+3)/2",
        "(2+3)*(8*9)/2)",
        "((2+3)*((8*9)/2)",
        "(2+3)*((8*9)/2)"
    };
    
    for (std::string ex : inputData) {
        //std::cout << "Our string is " << ex;
        if (validate(ex)) { // checking if a statement is valid is important for the resr of these
            std::cout << "\tParentheses are valid for: " << ex << std::endl; // std::endl keeps the formatting nice, don't delete
            
            std::string postfix = convert(ex); // our infix need to be converted to postfix and stored
            std::cout << "\tInfix to postfix expression conversion: " << postfix << std::endl;
            std::cout << "\tEvaluated infix: " << evaluate(postfix) << std::endl;
            
        } else {
            std::cout << "\tParentheses are NOT valid for: " << ex << std::endl;
        }
    }
    
    return 0;
    
}