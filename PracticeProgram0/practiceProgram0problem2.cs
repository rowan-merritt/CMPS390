/*
2. Use the “sizeof()” keyword to determine the size in bytes of the basic data types:
int, short int, long int, float, char, unsigned char. Check the example below for hints. 
This example is from JDoodle – if you were to run this in Repl, you may have to 
switch the “%d” to a “%lu”.
*/

#include <iostream>
#include<stdio.h>

main() {
 printf("The size of an int is %d \n", sizeof(int));
 printf("The size of an short int is %d \n", sizeof(short int));
 printf("The size of an long int is %d \n", sizeof(long int));
 printf("The size of an float is %d \n", sizeof(float));
 printf("The size of an unsigned char is %d \n", sizeof(unsigned char));
 printf("The size of an signed char is %d \n", sizeof(signed char));
}