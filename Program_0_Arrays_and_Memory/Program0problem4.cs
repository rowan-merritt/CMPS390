/*
Write a C program that fills creates an identity matrix. (An identity matrix is a square 
matrix that has all 1's on the diagonal.) 
Example of a 5 by 5 identity matrix:
1 0 0 0 0
0 1 0 0 0 
0 0 1 0 0 
0 0 0 1 0
0 0 0 0 1

a. Use conventional array accessing methods to create a 5 by 5 identity matrix. DONE

b. Use conventional array accessing methods to display the matrix. DONE

c. Use the pointer/addressing methods discussed in the chapter to display the 
matrix.

d. Use the pointer/addressing methods discussed in the chapter to fill the matrix.

e. Use pointer/addressing methods to exchange rows 0 and 4 of the identity 
matrix. 

f. Write out the result; it should appear as below:
0 0 0 0 1
0 1 0 0 0 
0 0 1 0 0 
0 0 0 1 0
1 0 0 0 0


*/
#include <iostream>
#include <stdio.h>

int main(){
    int arr[4][4];
    int j, k; 
    int (*mptn)[4];
    mptn = &(arr[0][0]);
    std::cout << "Steps a. to b. Running: \n";
    
    for(j = 0; j < 4; j++){ // loop going through the rows
        for(k = 0; k < 4; k++){ // loop going through the columns
            if(j == k){ // compare the position of the row with the row and inputing 1
                arr[j][k] = 1;
            }
            else{ // putting 0 if the row num and column aren't the same number
                arr[j][k] = 0;
            }
            std::cout << arr[j][k] << "\t";
        }
        std::cout <<  std::endl;
    }
    
    std::cout << "Steps c - f Running: \n";
    
    for(j = 0; j < 4; j++){ // loop going through the rows
        for(k = 0; k < 4; k++){ // loop going through the columns
            if(j == k){ // compare the position of the row with the row and inputing 1
                mptn[j][k] = 1; // using memory pointer
            }
            else{ // putting 0 if the row num and column aren't the same number
                mptn[j][k] = 0; // using memory pointer
            }
            
            int temp = *mptn[0]; // saving the value at 1st row
            *mptn[0] = *mptn[3]; // swapping the value at the 1st row with the 4th row value
            *mptn[3] = temp; // swapping the value at the 4th row with the 1st row value
            arr[3][3] = 0;
            arr[0][3] = 1;
            
            std::cout << mptn[j][k] << "\t";
        }
        std::cout <<  std::endl;
    }
}