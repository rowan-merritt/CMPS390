/*
1. Write a C program that does the following:
    a. Declare a 1-dimensional array of length 10.
    
    b. Using conventional array access methods, fill the array with consecutive 
       numbers starting with 0.
    
    c. Print out the contents of the array using conventional array access methods.

    d. Now using a memory pointer, fill the array with consecutive numbers starting 
       with 100.
    
    e. Print out the contents of the array using a memory pointer.
*/

#include <iostream>
#include <stdio.h>

int main(){
    int arr[10];
    int j;
    
    std::cout << "Here is the contents of the array using conventional methods: \n";
    
    for(j = 0 ; j <= 10; j++){
        arr[j] = j;
        std::cout  << arr[j] << "\n";
    }
    
    std::cout << "Here is the contents of the array using memory pointer: \n";
    
    int *mptn;
    mptn = &(arr[0]);

    for(j = 100 ; j < 110 ; j++){
        *mptn=j;
        mptn++;
    }
    

    mptn = &(arr[0]);
    for(j = 0 ; j <= 10 ; j++){
        std::cout  << *mptn << "\n";
        mptn++;
    }
}