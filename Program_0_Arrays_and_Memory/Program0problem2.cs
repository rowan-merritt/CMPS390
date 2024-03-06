/*
    Write a C program that fills a 5 by 5 2d array with consecutive numbers, in row major 
    fashion. An example of the array is below:
        0  1  2  3  4
        5  6  7  8  9
        10 11 12 13 14
        15 16 17 18 19
        20 21 22 23 24

    a. Use conventional array accessing methods to create a 5 by 5 array.
    
    b. Use conventional array accessing methods to display the array.
    
    c. Use the pointer/addressing methods discussed in the chapter to display the 
       array.
    
    d. Use the pointer/addressing methods discussed in the chapter to fill the array.
    
    e. Now load the matrix so that consecutive number go down the columns 
       (similar to column major fashion) using pointer/addressing methods as 
       discussed in the chapter. 

    f. Write out the result; it should appear as below:
        0 5 10 15 20
        1 6 11 16 21 
        2 7 12 17 22 
        3 8 13 18 23
        4 9 14 19 24
*/

#include <iostream>
#include <stdio.h>

int main(){
    int arr[5][5];
    int j, k;
    int value = 0;

    for(j = 0; j < 5; j++){
        for(k = 0; k < 5; k++){
            arr[j][k] = value;
            value = value + 1;
            std::cout << arr[j][k] << ", ";
            
        }
    }
}