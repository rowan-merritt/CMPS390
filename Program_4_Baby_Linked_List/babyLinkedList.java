package Program_4_Baby_Linked_List;

/* 
2 Make a showList function and call it after the list has been loaded by the for loop.

3 Add the capability to add a node between two nodes.
    3a Make sure and ask the user which node they want to place the new node after, and the value of the node to be.

4 You will need to make a function that finds the node the user requested.

5 Add the capability to delete a node.

6 Make a small text menu for your program so that you can let the user select the various functions.

Turn in a .pdf that discusses your program, contains the code, and screenshots of each function running.  Due March 6
*/


/*
    1) Write a program that creates a linked list and loads it with the numbers 0 to 9.
        1a)  Create the functions, init, makeNode, and findTail to help with the task. 
             In order to make sure everything is working, the contents of the list will have to be displayed.
*/
import java.util.Scanner;

class node {
    int data;
    node next;
} // end class node

public class babyLinkedList {
    node front;
    
    public void init() {
        front = null;
    }
    
    public node makeNode(int data){
        node newNode;
        newNode = new node();
        newNode.data = data;
        newNode.next = null;
        return newNode;
    } // end makeNode
    
    public node findTail(){
        node current;
        current = front;
        while(current.next != null){
            current = current.next;
        }
        return current;
    } // end findTail

    public void buildSimpleList(int m){
        node tail;
        init();

        for(int j = 0; j < m; j++){
            if(j == 0){
                front = makeNode(j);
            }
            else {
                tail = findTail();
                tail.next = makeNode(j);
            }
        }
    } // end buildSimpleList()
    
    public void showList(){ // we need this to make sure we're correct
        node current;
        System.out.println("list ...");
        current = front;
        while(current != null){
            System.out.print(current.data);
            current = current.next;
        }
    } // end showList()

} // class babyLinkedList

class Main{
    public static void main(String[] args) {
        System.out.print("Enter the length of the list: ");
        Scanner input = new Scanner(System.in);
        int listInt = input.nextInt();

        babyLinkedList list = new babyLinkedList();
        list.init();
        list.buildSimpleList(listInt);
        list.showList();
        input.close();
    } // end of main
}