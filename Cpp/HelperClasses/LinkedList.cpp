#include "LinkedList.h"
#include "Node.h"
#include <iostream>


HelperObjects::LinkedList::LinkedList(){
    head = NULL;
}

void HelperObjects::LinkedList::InsertNode(int data)
{
    // Create the new Node.
    Node* newNode = new Node(data);

    // Assign to head
    if (head == NULL) {
        head = newNode;
        return;
    }

    // Traverse till end of list
    Node* temp = head;
    while (temp->next != NULL) {

        // Update temp
        temp = temp->next;
    }

    // Insert at the last.
    temp->next = newNode;
}


void HelperObjects::LinkedList::PrintList()
{
    Node* temp = head;

    // Check for empty list.
    if (head == NULL) {
        std::cout << "List empty" << std::endl;
        return;
    }

    // Traverse the list.
    while (temp != NULL) {
        std::cout << temp->data << " ";
        temp = temp->next;
    }
}