#include "Node.h"
// Node class to represent
// a node of the linked list.
// Default constructor
Node::Node(){
    data = 0;
    next = NULL;
}
// Parameterised Constructor
Node::Node(int data)
{
    this->data = data;
    this->next = NULL;
}
