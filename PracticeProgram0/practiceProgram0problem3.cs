/*
3. In C/C++ create the classes myData0 and myData1 as shown at top of page 9 and in the example below.
*/

#include <iostream>
#include <stdio.h>

class myData0 {
    short int height; // 2
    long int hairCount; // 8
    long int numFreckles; // 8 
    short int weight; // 2
};

class myData1 {
    short int height; // 2
    short int weight; // 2
    long int hairCount; // 8
    long int numFreckles; // 8
};

// Use a main program like the one shown below to verify the actual size of the two classes.

main() {
printf("size of myData0 in bytes = %d \n", sizeof(myData0));
printf("size of myData1 in bytes = %d \n", sizeof(myData1));
}