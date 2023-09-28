#include "easy_MergeTwoSortedLists.h"

// Function to delete the
// node at given position
void Linkedlist::deleteNode(int nodeOffset)
{
    Node* temp1 = head, * temp2 = NULL;
    int ListLen = 0;

    if (head == NULL) {
        std::cout << "List empty." << std::endl;
        return;
    }

    // Find length of the linked-list.
    while (temp1 != NULL) {
        temp1 = temp1->next;
        ListLen++;
    }

    // Check if the position to be
    // deleted is less than the length
    // of the linked list.
    if (ListLen < nodeOffset) {
        std::cout << "Index out of range"
            << std::endl;
        return;
    }

    // Declare temp1
    temp1 = head;

    // Deleting the head.
    if (nodeOffset == 1) {

        // Update head
        head = head->next;
        delete temp1;
        return;
    }

    // Traverse the list to
    // find the node to be deleted.
    while (nodeOffset-- > 1) {

        // Update temp2
        temp2 = temp1;

        // Update temp1
        temp1 = temp1->next;
    }

    // Change the next pointer
    // of the previous node.
    temp2->next = temp1->next;

    // Delete the node
    delete temp1;
}

// Function to insert a new node.
void Linkedlist::insertNode(int data)
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

// Function to print the
// nodes of the linked list.
void Linkedlist::printList()
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


Node* MergeTwoSortedLists(){
    Linkedlist l1;
    Linkedlist l2;

    l1.insertNode(1);
    l1.insertNode(3);
    l1.insertNode(5);

    l2.insertNode(0);
    l2.insertNode(2);
    l2.insertNode(4);
    return new Node(3);
}

Node* MergeTwoSortedListsHelper(Node* l1, Node* l2) { 
    

    if (l1 == NULL) return l2;
    if (l2 == NULL) return l1;

    if (l1->data <= l2->data) {
        l1->next = MergeTwoSortedLists(l1->next, l2);
        return l1;
    }
    else {
        l2->next = MergeTwoSortedLists(l1, l2->next);
        return l2;
    }
}

